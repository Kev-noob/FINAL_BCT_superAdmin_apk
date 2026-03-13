using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace FINAL_BCT_superAdmin_apk  
{
    public partial class Admin_Dashboard : Form
    {
        //FOR EDITING COURSES
        private int selectedSubjectId = 0;


        //LOAD SUBJECTS TO DATAGRIDVIEW
        private void LoadSubjects()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id, subject_code, subject_name, units FROM subjects ORDER BY subject_name";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    subjects_dataGridView.DataSource = dt;
                    subjects_dataGridView.Columns["id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }

        // CLICK TABLE TO SHOW IN THE TEXTBOXES
        private void subjects_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = subjects_dataGridView.Rows[e.RowIndex];

                // Fill textboxes with selected row data
                subject_code.Text = row.Cells["subject_code"].Value.ToString();
                subject_name.Text = row.Cells["subject_name"].Value.ToString();
                subject_units.Text = row.Cells["units"].Value?.ToString() ?? "";

                // Store the ID for updating
                selectedSubjectId = Convert.ToInt32(row.Cells["id"].Value);
            }
        }

        //ADD SUBJECT
        private void addSub_Click(object sender, EventArgs e)
        {
            string Code = subject_code.Text.Trim();
            string Name = subject_name.Text.Trim();
            string Units = subject_units.Text.Trim();

            if (string.IsNullOrEmpty(Code) || string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Please Complete Inputs!");
                return;
            }

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string sql = "INSERT INTO subjects (subject_code, subject_name, units) VALUES (@code, @name, @unit)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@code", Code);
                        cmd.Parameters.AddWithValue("@name", Name);
                        cmd.Parameters.AddWithValue("@unit", Units);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Subject added successfully!");
                LoadSubjects(); // Refresh GRID

                // Clear textboxes
                subject_code.Clear();
                subject_name.Clear();
                subject_units.Clear();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("Subject code already exists!");
                else
                    MessageBox.Show("Error: " + ex.Message);
            }
        }

        //CLEAR TEXTBOX
        private void clear_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            subject_code.Clear();
            subject_name.Clear();
            subject_units.Clear();

            // Reset selected course ID
            selectedSubjectId = 0;

            // Optional: Deselect row in DataGridView
            subjects_dataGridView.ClearSelection();
        }

        //EDIT BUTTON
        private void editSub_Click(object sender, EventArgs e)
        {
            // Check if a course is selected
            if (selectedSubjectId == 0)
            {
                MessageBox.Show("Please select a subject from the list to edit!");
                return;
            }

            // Get values from textboxes
            string Code = subject_code.Text.Trim();
            string Name = subject_name.Text.Trim();
            string Units = subject_units.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(Code) || string.IsNullOrEmpty(Name))
            {
                MessageBox.Show("Please fill in Subject Code and Subject Name!");
                return;
            }

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    // Update the course in database
                    string sql = "UPDATE subjects SET subject_code=@code, subject_name=@name, units=@units WHERE id=@id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@code", Code);
                        cmd.Parameters.AddWithValue("@name", Name);
                        cmd.Parameters.AddWithValue("@units", Units);
                        cmd.Parameters.AddWithValue("@id", selectedSubjectId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Subject updated successfully!");

                // Refresh the DataGridView
                LoadSubjects();

                // Clear textboxes
                subject_code.Clear();
                subject_name.Clear();
                subject_units.Clear();

                // Reset selected ID
                selectedSubjectId = 0;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Subject code already exists!");
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //DELATE BUTTON
        private void delateSub_Click(object sender, EventArgs e)
        {
            // Check if a course is selected
            if (selectedSubjectId == 0)
            {
                MessageBox.Show("Please select a Subject from the list to delete!");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this Subject?\nThis action cannot be undone!",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                return; // User cancelled
            }

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    // Delete the course from database
                    string sql = "DELETE FROM subjects WHERE id=@id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedSubjectId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Subject deleted successfully!");

                // Refresh the DataGridView
                LoadSubjects();

                // Clear textboxes
                subject_code.Clear();
                subject_name.Clear();
                subject_units.Clear();

                // Reset selected ID
                selectedSubjectId = 0;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451) // Foreign key constraint error
                {
                    MessageBox.Show("Cannot delete this subject!\n\nIt is currently linked to existing students or schedules.\nRemove those links first before deleting.",
                                "Delete Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}