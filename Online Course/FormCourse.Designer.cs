namespace Online_Course
{
    partial class FormCourse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelAddCourse = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.guna2ComboBoxSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2TextBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Release_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstructorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddCourse
            // 
            this.labelAddCourse.AutoSize = true;
            this.labelAddCourse.BackColor = System.Drawing.Color.Transparent;
            this.labelAddCourse.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddCourse.Location = new System.Drawing.Point(212, 31);
            this.labelAddCourse.Name = "labelAddCourse";
            this.labelAddCourse.Size = new System.Drawing.Size(141, 40);
            this.labelAddCourse.TabIndex = 75;
            this.labelAddCourse.Text = "COURSE";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(18, 106);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(86, 25);
            this.labelSearch.TabIndex = 76;
            this.labelSearch.Text = "Search :";
            // 
            // guna2ComboBoxSearch
            // 
            this.guna2ComboBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxSearch.BorderRadius = 22;
            this.guna2ComboBoxSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxSearch.FocusedState.Parent = this.guna2ComboBoxSearch;
            this.guna2ComboBoxSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBoxSearch.HoverState.Parent = this.guna2ComboBoxSearch;
            this.guna2ComboBoxSearch.ItemHeight = 30;
            this.guna2ComboBoxSearch.Items.AddRange(new object[] {
            "Course Id",
            "Course Name",
            "Language",
            "Price",
            "Topic Name",
            "Instructor Name"});
            this.guna2ComboBoxSearch.ItemsAppearance.Parent = this.guna2ComboBoxSearch;
            this.guna2ComboBoxSearch.Location = new System.Drawing.Point(104, 100);
            this.guna2ComboBoxSearch.Name = "guna2ComboBoxSearch";
            this.guna2ComboBoxSearch.ShadowDecoration.Parent = this.guna2ComboBoxSearch;
            this.guna2ComboBoxSearch.Size = new System.Drawing.Size(175, 36);
            this.guna2ComboBoxSearch.TabIndex = 77;
            // 
            // guna2TextBoxSearch
            // 
            this.guna2TextBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxSearch.BorderRadius = 22;
            this.guna2TextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxSearch.DefaultText = "";
            this.guna2TextBoxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxSearch.DisabledState.Parent = this.guna2TextBoxSearch;
            this.guna2TextBoxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxSearch.FocusedState.Parent = this.guna2TextBoxSearch;
            this.guna2TextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxSearch.HoverState.Parent = this.guna2TextBoxSearch;
            this.guna2TextBoxSearch.Location = new System.Drawing.Point(285, 100);
            this.guna2TextBoxSearch.Name = "guna2TextBoxSearch";
            this.guna2TextBoxSearch.PasswordChar = '\0';
            this.guna2TextBoxSearch.PlaceholderText = "";
            this.guna2TextBoxSearch.SelectedText = "";
            this.guna2TextBoxSearch.ShadowDecoration.Parent = this.guna2TextBoxSearch;
            this.guna2TextBoxSearch.Size = new System.Drawing.Size(272, 36);
            this.guna2TextBoxSearch.TabIndex = 78;
            this.guna2TextBoxSearch.TextChanged += new System.EventHandler(this.guna2TextBoxSearch_TextChanged);
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nama,
            this.Desc,
            this.Language,
            this.Price,
            this.Release_Date,
            this.Topic,
            this.TopicName,
            this.Instructor,
            this.InstructorName});
            this.dataGridViewSearch.Location = new System.Drawing.Point(23, 162);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RowHeadersWidth = 51;
            this.dataGridViewSearch.RowTemplate.Height = 24;
            this.dataGridViewSearch.Size = new System.Drawing.Size(534, 310);
            this.dataGridViewSearch.TabIndex = 79;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 48;
            // 
            // Nama
            // 
            this.Nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nama.HeaderText = "Nama";
            this.Nama.MinimumWidth = 6;
            this.Nama.Name = "Nama";
            this.Nama.Width = 74;
            // 
            // Desc
            // 
            this.Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Desc.HeaderText = "Description";
            this.Desc.MinimumWidth = 6;
            this.Desc.Name = "Desc";
            this.Desc.Width = 108;
            // 
            // Language
            // 
            this.Language.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Language.HeaderText = "Language";
            this.Language.MinimumWidth = 6;
            this.Language.Name = "Language";
            this.Language.Width = 101;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "#,###";
            dataGridViewCellStyle1.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle1;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 69;
            // 
            // Release_Date
            // 
            this.Release_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Release_Date.HeaderText = "Release Date";
            this.Release_Date.MinimumWidth = 6;
            this.Release_Date.Name = "Release_Date";
            this.Release_Date.Width = 123;
            // 
            // Topic
            // 
            this.Topic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Topic.HeaderText = "Id Topic";
            this.Topic.MinimumWidth = 6;
            this.Topic.Name = "Topic";
            this.Topic.Width = 87;
            // 
            // TopicName
            // 
            this.TopicName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TopicName.HeaderText = "Topic Name";
            this.TopicName.MinimumWidth = 6;
            this.TopicName.Name = "TopicName";
            this.TopicName.Width = 113;
            // 
            // Instructor
            // 
            this.Instructor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Instructor.HeaderText = "Id Instructor";
            this.Instructor.MinimumWidth = 6;
            this.Instructor.Name = "Instructor";
            this.Instructor.Width = 111;
            // 
            // InstructorName
            // 
            this.InstructorName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.InstructorName.HeaderText = "InstructorName";
            this.InstructorName.MinimumWidth = 6;
            this.InstructorName.Name = "InstructorName";
            this.InstructorName.Width = 133;
            // 
            // FormCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Online_Course.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 499);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.guna2TextBoxSearch);
            this.Controls.Add(this.guna2ComboBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelAddCourse);
            this.Name = "FormCourse";
            this.Text = "FormCourse";
            this.Load += new System.EventHandler(this.FormCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddCourse;
        private System.Windows.Forms.Label labelSearch;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxSearch;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxSearch;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Release_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopicName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstructorName;
    }
}