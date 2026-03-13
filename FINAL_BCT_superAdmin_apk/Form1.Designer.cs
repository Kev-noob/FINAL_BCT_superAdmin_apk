namespace FINAL_BCT_superAdmin_apk
{
    partial class Landing_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Button();
            this.LogIn_container = new System.Windows.Forms.Panel();
            this.login_eye = new System.Windows.Forms.Button();
            this.Pass_label = new System.Windows.Forms.Label();
            this.Id_Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginEye_btn = new System.Windows.Forms.Button();
            this.login_password_txtbox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_ID_txtbox = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.Landing = new System.Windows.Forms.Panel();
            this.close_btn = new System.Windows.Forms.Button();
            this.go_to_login = new System.Windows.Forms.Button();
            this.Login.SuspendLayout();
            this.LogIn_container.SuspendLayout();
            this.Landing.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.BackgroundImage = global::FINAL_BCT_superAdmin_apk.Properties.Resources.login_F;
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login.Controls.Add(this.back);
            this.Login.Controls.Add(this.LogIn_container);
            this.Login.Controls.Add(this.close);
            this.Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(1020, 720);
            this.Login.TabIndex = 1;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.BackgroundImage = global::FINAL_BCT_superAdmin_apk.Properties.Resources.arrow;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.ForeColor = System.Drawing.Color.Transparent;
            this.back.Location = new System.Drawing.Point(537, 94);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(33, 29);
            this.back.TabIndex = 7;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // LogIn_container
            // 
            this.LogIn_container.BackColor = System.Drawing.Color.Transparent;
            this.LogIn_container.Controls.Add(this.login_eye);
            this.LogIn_container.Controls.Add(this.Pass_label);
            this.LogIn_container.Controls.Add(this.Id_Label);
            this.LogIn_container.Controls.Add(this.panel2);
            this.LogIn_container.Controls.Add(this.loginEye_btn);
            this.LogIn_container.Controls.Add(this.login_password_txtbox);
            this.LogIn_container.Controls.Add(this.panel4);
            this.LogIn_container.Controls.Add(this.login_btn);
            this.LogIn_container.Controls.Add(this.login_ID_txtbox);
            this.LogIn_container.Location = new System.Drawing.Point(529, 150);
            this.LogIn_container.Name = "LogIn_container";
            this.LogIn_container.Size = new System.Drawing.Size(397, 403);
            this.LogIn_container.TabIndex = 6;
            // 
            // login_eye
            // 
            this.login_eye.BackColor = System.Drawing.Color.White;
            this.login_eye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_eye.FlatAppearance.BorderSize = 0;
            this.login_eye.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.login_eye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.login_eye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_eye.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_eye.ForeColor = System.Drawing.Color.Black;
            this.login_eye.Image = global::FINAL_BCT_superAdmin_apk.Properties.Resources.eye_off;
            this.login_eye.Location = new System.Drawing.Point(321, 194);
            this.login_eye.Name = "login_eye";
            this.login_eye.Size = new System.Drawing.Size(36, 26);
            this.login_eye.TabIndex = 20;
            this.login_eye.UseVisualStyleBackColor = false;
            this.login_eye.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Pass_label
            // 
            this.Pass_label.AutoSize = true;
            this.Pass_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_label.ForeColor = System.Drawing.Color.White;
            this.Pass_label.Location = new System.Drawing.Point(36, 158);
            this.Pass_label.Name = "Pass_label";
            this.Pass_label.Size = new System.Drawing.Size(92, 24);
            this.Pass_label.TabIndex = 22;
            this.Pass_label.Text = "Password";
            // 
            // Id_Label
            // 
            this.Id_Label.AutoSize = true;
            this.Id_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Label.ForeColor = System.Drawing.Color.White;
            this.Id_Label.Location = new System.Drawing.Point(36, 56);
            this.Id_Label.Name = "Id_Label";
            this.Id_Label.Size = new System.Drawing.Size(85, 24);
            this.Id_Label.TabIndex = 21;
            this.Id_Label.Text = "Admin Id";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.ForeColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(37, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 2);
            this.panel2.TabIndex = 20;
            // 
            // loginEye_btn
            // 
            this.loginEye_btn.BackColor = System.Drawing.Color.White;
            this.loginEye_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginEye_btn.FlatAppearance.BorderSize = 0;
            this.loginEye_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.loginEye_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.loginEye_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginEye_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginEye_btn.ForeColor = System.Drawing.Color.Black;
            this.loginEye_btn.Location = new System.Drawing.Point(321, 194);
            this.loginEye_btn.Name = "loginEye_btn";
            this.loginEye_btn.Size = new System.Drawing.Size(36, 27);
            this.loginEye_btn.TabIndex = 19;
            this.loginEye_btn.UseVisualStyleBackColor = false;
            // 
            // login_password_txtbox
            // 
            this.login_password_txtbox.BackColor = System.Drawing.Color.White;
            this.login_password_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_password_txtbox.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password_txtbox.ForeColor = System.Drawing.Color.Maroon;
            this.login_password_txtbox.Location = new System.Drawing.Point(37, 194);
            this.login_password_txtbox.Name = "login_password_txtbox";
            this.login_password_txtbox.Size = new System.Drawing.Size(320, 26);
            this.login_password_txtbox.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.ForeColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(37, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 2);
            this.panel4.TabIndex = 14;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Transparent;
            this.login_btn.FlatAppearance.BorderSize = 2;
            this.login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(125, 281);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(146, 41);
            this.login_btn.TabIndex = 9;
            this.login_btn.Text = "Log in";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_ID_txtbox
            // 
            this.login_ID_txtbox.BackColor = System.Drawing.Color.White;
            this.login_ID_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login_ID_txtbox.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_ID_txtbox.ForeColor = System.Drawing.Color.Maroon;
            this.login_ID_txtbox.Location = new System.Drawing.Point(37, 90);
            this.login_ID_txtbox.Name = "login_ID_txtbox";
            this.login_ID_txtbox.Size = new System.Drawing.Size(320, 26);
            this.login_ID_txtbox.TabIndex = 6;
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.ForeColor = System.Drawing.Color.Transparent;
            this.close.Image = global::FINAL_BCT_superAdmin_apk.Properties.Resources.x;
            this.close.Location = new System.Drawing.Point(972, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 20);
            this.close.TabIndex = 5;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.button1_Click);
            // 
            // Landing
            // 
            this.Landing.BackgroundImage = global::FINAL_BCT_superAdmin_apk.Properties.Resources.landing_F;
            this.Landing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Landing.Controls.Add(this.close_btn);
            this.Landing.Controls.Add(this.go_to_login);
            this.Landing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Landing.Location = new System.Drawing.Point(0, 0);
            this.Landing.Name = "Landing";
            this.Landing.Size = new System.Drawing.Size(1020, 720);
            this.Landing.TabIndex = 0;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.ForeColor = System.Drawing.Color.Transparent;
            this.close_btn.Image = global::FINAL_BCT_superAdmin_apk.Properties.Resources.x;
            this.close_btn.Location = new System.Drawing.Point(972, 12);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(20, 20);
            this.close_btn.TabIndex = 4;
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // go_to_login
            // 
            this.go_to_login.BackColor = System.Drawing.Color.Transparent;
            this.go_to_login.FlatAppearance.BorderSize = 0;
            this.go_to_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.go_to_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.go_to_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.go_to_login.Font = new System.Drawing.Font("Noto Sans JP Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.go_to_login.ForeColor = System.Drawing.Color.White;
            this.go_to_login.Location = new System.Drawing.Point(36, 476);
            this.go_to_login.Name = "go_to_login";
            this.go_to_login.Size = new System.Drawing.Size(350, 136);
            this.go_to_login.TabIndex = 0;
            this.go_to_login.Text = "LOG IN";
            this.go_to_login.UseVisualStyleBackColor = false;
            this.go_to_login.Click += new System.EventHandler(this.go_to_login_Click);
            // 
            // Landing_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 720);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Landing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Landing_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Landing_login_Load);
            this.Login.ResumeLayout(false);
            this.LogIn_container.ResumeLayout(false);
            this.LogIn_container.PerformLayout();
            this.Landing.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Landing;
        private System.Windows.Forms.Panel Login;
        private System.Windows.Forms.Button go_to_login;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel LogIn_container;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button loginEye_btn;
        private System.Windows.Forms.TextBox login_password_txtbox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox login_ID_txtbox;
        private System.Windows.Forms.Label Pass_label;
        private System.Windows.Forms.Label Id_Label;
        private System.Windows.Forms.Button login_eye;
        private System.Windows.Forms.Button back;
    }
}

