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
                             "password=root;";
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
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void closeHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void closeAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //ENROLLMENT SUBMENU BUTTONS
        private void button1_Click_1(object sender, EventArgs e)
        {
            Enroll_Course.BringToFront();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Enroll_Subject.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            student_billing.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adjust_billing.BringToFront();
        }

       
    }
}
