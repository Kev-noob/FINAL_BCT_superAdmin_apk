using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FINAL_BCT_superAdmin_apk
{
    public partial class Admin_Dashboard : Form
    {
        //SIDEBAR BOOL
        bool sidebarExpand;
        //FOR EDITING COURSES
        private int selectedCourseId = 0;

        public Admin_Dashboard()
        {
            InitializeComponent();

            //SLIDE ANTI FLICKER
            this.DoubleBuffered = true;
            // Enable for the panel with background image
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, Home_panel, new object[] { true });
        }

        //FORM LOAD
        private void Admin_Dashboard_Load(object sender, EventArgs e)
        {
            //FORM CORNERS-->
            int radius = 20;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }


        //DATABASE CONNECTION--->
        private MySqlConnection GetConnection()
        {
            string connStr = "server=localhost;" +
                             "port=3306;" +
                             "database=BCT_db;" +
                             "user=root;" +
                             "password=;";
            return new MySqlConnection(connStr);
        }//<----


        //COLLAPSE SIDEBAR METHOD
        private void CollapseSidebar()
        {
            if (sideBar_container.Width <= sideBar_container.MinimumSize.Width)
                return;

            sidebarExpand = true;
            side_panel_timer.Start();
        }
        //SIDEBAR TIMER
        private void side_panel_timer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sideBar_container.Width -= 10;
                if (sideBar_container.Width == sideBar_container.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    side_panel_timer.Stop();
                }

            }
            else
            {
                sideBar_container.Width += 10;
                if (sideBar_container.Width == sideBar_container.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    side_panel_timer.Stop();
                }
            }
        }




        //------------------------------------------------MENU Buttons------------------------------------------------

        //SIDEBAR BUTTONS
        private async void home__Click(object sender, EventArgs e)
        {
            CollapseSidebar();
            await Task.Delay(150);
            Home_panel.BringToFront();
        }
        private async void enroll__Click(object sender, EventArgs e)
        {
            CollapseSidebar();
            await Task.Delay(150);
            Manage_Enroll.BringToFront();
            LoadCourses();
        }
        private async void billing__Click(object sender, EventArgs e)
        {
            CollapseSidebar();
            await Task.Delay(150);
            Billing.BringToFront();
        }
        private async void admins__Click(object sender, EventArgs e)
        {
            CollapseSidebar();
            await Task.Delay(150);
            Admin_Manage.BringToFront();
        }
        private async void button5_Click(object sender, EventArgs e)
        {
            CollapseSidebar();
            await Task.Delay(150);
            Manage_Instructor.BringToFront();
        }

        private void logOut__Click(object sender, EventArgs e)
        {
            Landing_login Admin = new Landing_login();
            this.Hide();
            Admin.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sideBar_container.BringToFront();
            side_panel_timer.Start();
        }


        //CLOSE BUTTON
        private void closeAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //ENROLLMENT SUBMENU BUTTONS

            //displays courses in datagridview
        private void LoadCourses()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT id, course_code, course_name, department FROM courses ORDER BY course_name";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    courses_DataGridView.DataSource = dt;
                    courses_DataGridView.Columns["id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Enroll_Course.BringToFront();
            LoadCourses();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Enroll_Subject.BringToFront();
            LoadSubjects();
        }

        // When a cell is clicked, populate the textboxes with the course data for editing
        private void courses_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = courses_DataGridView.Rows[e.RowIndex];

                // Fill textboxes with selected row data
                entr_course_code.Text = row.Cells["course_code"].Value.ToString();
                entr_course_name.Text = row.Cells["course_name"].Value.ToString();
                entr_department.Text = row.Cells["department"].Value?.ToString() ?? "";

                // Store the ID for updating
                selectedCourseId = Convert.ToInt32(row.Cells["id"].Value);
            }
        }
        
        
        //EDIT BUTTON CLICK
        private void editCourse_Click(object sender, EventArgs e)
        {
            // Check if a course is selected
            if (selectedCourseId == 0)
            {
                MessageBox.Show("Please select a course from the list to edit!");
                return;
            }

            // Get values from textboxes
            string courseCode = entr_course_code.Text.Trim();
            string courseName = entr_course_name.Text.Trim();
            string department = entr_department.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(courseCode) || string.IsNullOrEmpty(courseName))
            {
                MessageBox.Show("Please fill in Course Code and Course Name!");
                return;
            }

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    // Update the course in database
                    string sql = "UPDATE courses SET course_code=@code, course_name=@name, department=@dept WHERE id=@id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@code", courseCode);
                        cmd.Parameters.AddWithValue("@name", courseName);
                        cmd.Parameters.AddWithValue("@dept", department);
                        cmd.Parameters.AddWithValue("@id", selectedCourseId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Course updated successfully!");

                // Refresh the DataGridView
                LoadCourses();

                // Clear textboxes
                entr_course_code.Clear();
                entr_course_name.Clear();
                entr_department.Clear();

                // Reset selected ID
                selectedCourseId = 0;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Course code already exists!");
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
        //DELATE BUTTON CLICK
        private void delateCourse_Click(object sender, EventArgs e)
        {
            // Check if a course is selected
            if (selectedCourseId == 0)
            {
                MessageBox.Show("Please select a course from the list to delete!");
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this course?\nThis action cannot be undone!",
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
                    string sql = "DELETE FROM courses WHERE id=@id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", selectedCourseId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Course deleted successfully!");

                // Refresh the DataGridView
                LoadCourses();

                // Clear textboxes
                entr_course_code.Clear();
                entr_course_name.Clear();
                entr_department.Clear();

                // Reset selected ID
                selectedCourseId = 0;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451) // Foreign key constraint error
                {
                    MessageBox.Show("Cannot delete this course! Students are enrolled in it or subjects are aligned to it.");
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
        //CLEAR INPUTS BUTTON CLICK
        private void clear_inputs_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            entr_course_code.Clear();
            entr_course_name.Clear();
            entr_department.Clear();

            // Reset selected course ID
            selectedCourseId = 0;

            // Optional: Deselect row in DataGridView
            courses_DataGridView.ClearSelection();
        }




        //BILLING SUBMENU BUTTONS
        private void button4_Click(object sender, EventArgs e)
        {
            student_billing.BringToFront();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            adjust_billing.BringToFront();
        }

        //ADD COURSE BUTTON CLICK
        private void addCourse_Click(object sender, EventArgs e)
        {
            string courseCode = entr_course_code.Text.Trim();
            string courseName = entr_course_name.Text.Trim();
            string department = entr_department.Text.Trim();

            if (string.IsNullOrEmpty(courseCode) || string.IsNullOrEmpty(courseName))
            {
                MessageBox.Show("Please Complete Inputs!");
                return;
            }

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    string sql = "INSERT INTO courses (course_code, course_name, department) VALUES (@code, @name, @dept)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@code", courseCode);
                        cmd.Parameters.AddWithValue("@name", courseName);
                        cmd.Parameters.AddWithValue("@dept", department);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Course added successfully!");
                LoadCourses(); // Refresh GRID

                // Clear textboxes
                entr_course_code.Clear();
                entr_course_name.Clear();
                entr_department.Clear();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) 
                    MessageBox.Show("Course code already exists!");
                else
                    MessageBox.Show("Error: " + ex.Message);
            }
        }

        
    }
}
