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

namespace FINAL_BCT_superAdmin_apk
{
    public partial class Landing_login : Form
    {
        public Landing_login()
        {
            InitializeComponent();
        }

        //BUTTON CORNERS METHOD-->
        private void RoundButton(System.Windows.Forms.Button btn, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int d = radius * 2;

            path.AddArc(0, 0, d, d, 180, 90);                    // top-left
            path.AddArc(btn.Width - d, 0, d, d, 270, 90);        // top-right
            path.AddArc(btn.Width - d, btn.Height - d, d, d, 0, 90); // bottom-right
            path.AddArc(0, btn.Height - d, d, d, 90, 90);        // bottom-left
            path.CloseFigure();

            btn.Region = new Region(path);

        }

        //LOASDING PAGE METHOD
        private void Landing_login_Load(object sender, EventArgs e)
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

            //Rounding the corners of the buttons
            RoundButton(go_to_login, 20);
            RoundButton(login_btn, 5);

            //Password txt box hiding
            login_password_txtbox.PasswordChar = '•';

        }


        //LANDING PAGE TERRIRORY---------------------------------<<<<>>>>>--------------------------------------------
        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void go_to_login_Click(object sender, EventArgs e)
        {
            Login.BringToFront();
        }




        //LOGIN PAGE TERRIRORY-------------------------------<<<<>>>>>-------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (login_password_txtbox.PasswordChar == '•')
            {
                login_password_txtbox.PasswordChar = '\0';
                login_eye.Image = Properties.Resources.eye_on;
            }
            else
            {
                login_password_txtbox.PasswordChar = '•';
                login_eye.Image = Properties.Resources.eye_off;
            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            Landing.BringToFront();
        }

      

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (login_ID_txtbox.Text == "super admin" && login_password_txtbox.Text == "super admin")
            {

                Admin_Dashboard Admin = new Admin_Dashboard();
                this.Hide();
                Admin.Show();
            }
            else if (login_ID_txtbox.Text == "1" && login_password_txtbox.Text == "1")
            {
                Admin_Dashboard Admin = new Admin_Dashboard();
                this.Hide();
                Admin.Show();
            }
            else
            {
                MessageBox.Show("Invalid ID or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
