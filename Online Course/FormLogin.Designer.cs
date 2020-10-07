namespace Online_Course
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.labelNamaAplikaasi = new System.Windows.Forms.Label();
            this.labelSelamatDatang = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.guna2ButtonInstructor = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonStudent = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonExit = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.labelNamaAplikaasi);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(211)))), ((int)(((byte)(246)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.Window;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(288, 509);
            this.bunifuGradientPanel1.TabIndex = 4;
            // 
            // labelNamaAplikaasi
            // 
            this.labelNamaAplikaasi.AutoSize = true;
            this.labelNamaAplikaasi.BackColor = System.Drawing.Color.Transparent;
            this.labelNamaAplikaasi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaAplikaasi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelNamaAplikaasi.Location = new System.Drawing.Point(22, 216);
            this.labelNamaAplikaasi.Name = "labelNamaAplikaasi";
            this.labelNamaAplikaasi.Size = new System.Drawing.Size(253, 32);
            this.labelNamaAplikaasi.TabIndex = 7;
            this.labelNamaAplikaasi.Text = "ONLINE COURSE";
            // 
            // labelSelamatDatang
            // 
            this.labelSelamatDatang.AutoSize = true;
            this.labelSelamatDatang.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelamatDatang.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSelamatDatang.Location = new System.Drawing.Point(332, 36);
            this.labelSelamatDatang.Name = "labelSelamatDatang";
            this.labelSelamatDatang.Size = new System.Drawing.Size(442, 57);
            this.labelSelamatDatang.TabIndex = 11;
            this.labelSelamatDatang.Text = "SELAMAT DATANG";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelLogin.Location = new System.Drawing.Point(499, 107);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(111, 39);
            this.labelLogin.TabIndex = 10;
            this.labelLogin.Text = "LOGIN";
            // 
            // guna2ButtonInstructor
            // 
            this.guna2ButtonInstructor.BorderRadius = 20;
            this.guna2ButtonInstructor.CheckedState.Parent = this.guna2ButtonInstructor;
            this.guna2ButtonInstructor.CustomImages.Parent = this.guna2ButtonInstructor;
            this.guna2ButtonInstructor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(211)))), ((int)(((byte)(246)))));
            this.guna2ButtonInstructor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonInstructor.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonInstructor.HoverState.Parent = this.guna2ButtonInstructor;
            this.guna2ButtonInstructor.Location = new System.Drawing.Point(490, 271);
            this.guna2ButtonInstructor.Name = "guna2ButtonInstructor";
            this.guna2ButtonInstructor.ShadowDecoration.Parent = this.guna2ButtonInstructor;
            this.guna2ButtonInstructor.Size = new System.Drawing.Size(129, 41);
            this.guna2ButtonInstructor.TabIndex = 9;
            this.guna2ButtonInstructor.Text = "instructor";
            this.guna2ButtonInstructor.Click += new System.EventHandler(this.guna2ButtonInstructor_Click);
            // 
            // guna2ButtonAdmin
            // 
            this.guna2ButtonAdmin.BorderRadius = 20;
            this.guna2ButtonAdmin.CheckedState.Parent = this.guna2ButtonAdmin;
            this.guna2ButtonAdmin.CustomImages.Parent = this.guna2ButtonAdmin;
            this.guna2ButtonAdmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(211)))), ((int)(((byte)(246)))));
            this.guna2ButtonAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonAdmin.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonAdmin.HoverState.Parent = this.guna2ButtonAdmin;
            this.guna2ButtonAdmin.Location = new System.Drawing.Point(490, 339);
            this.guna2ButtonAdmin.Name = "guna2ButtonAdmin";
            this.guna2ButtonAdmin.ShadowDecoration.Parent = this.guna2ButtonAdmin;
            this.guna2ButtonAdmin.Size = new System.Drawing.Size(129, 41);
            this.guna2ButtonAdmin.TabIndex = 8;
            this.guna2ButtonAdmin.Text = "Admin";
            this.guna2ButtonAdmin.Click += new System.EventHandler(this.guna2ButtonAdmin_Click);
            // 
            // guna2ButtonStudent
            // 
            this.guna2ButtonStudent.BorderRadius = 20;
            this.guna2ButtonStudent.CheckedState.Parent = this.guna2ButtonStudent;
            this.guna2ButtonStudent.CustomImages.Parent = this.guna2ButtonStudent;
            this.guna2ButtonStudent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(211)))), ((int)(((byte)(246)))));
            this.guna2ButtonStudent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonStudent.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonStudent.HoverState.Parent = this.guna2ButtonStudent;
            this.guna2ButtonStudent.Location = new System.Drawing.Point(490, 207);
            this.guna2ButtonStudent.Name = "guna2ButtonStudent";
            this.guna2ButtonStudent.ShadowDecoration.Parent = this.guna2ButtonStudent;
            this.guna2ButtonStudent.Size = new System.Drawing.Size(129, 41);
            this.guna2ButtonStudent.TabIndex = 7;
            this.guna2ButtonStudent.Text = "Student";
            this.guna2ButtonStudent.Click += new System.EventHandler(this.guna2ButtonStudent_Click);
            // 
            // guna2ButtonExit
            // 
            this.guna2ButtonExit.BorderRadius = 20;
            this.guna2ButtonExit.CheckedState.Parent = this.guna2ButtonExit;
            this.guna2ButtonExit.CustomImages.Parent = this.guna2ButtonExit;
            this.guna2ButtonExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(211)))), ((int)(((byte)(246)))));
            this.guna2ButtonExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonExit.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonExit.HoverState.Parent = this.guna2ButtonExit;
            this.guna2ButtonExit.Location = new System.Drawing.Point(713, 456);
            this.guna2ButtonExit.Name = "guna2ButtonExit";
            this.guna2ButtonExit.ShadowDecoration.Parent = this.guna2ButtonExit;
            this.guna2ButtonExit.Size = new System.Drawing.Size(91, 41);
            this.guna2ButtonExit.TabIndex = 12;
            this.guna2ButtonExit.Text = "EXIT";
            this.guna2ButtonExit.Click += new System.EventHandler(this.guna2ButtonExit_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(816, 509);
            this.Controls.Add(this.guna2ButtonExit);
            this.Controls.Add(this.labelSelamatDatang);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.guna2ButtonInstructor);
            this.Controls.Add(this.guna2ButtonAdmin);
            this.Controls.Add(this.guna2ButtonStudent);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label labelNamaAplikaasi;
        private System.Windows.Forms.Label labelSelamatDatang;
        private System.Windows.Forms.Label labelLogin;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonInstructor;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAdmin;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonStudent;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonExit;
    }
}

