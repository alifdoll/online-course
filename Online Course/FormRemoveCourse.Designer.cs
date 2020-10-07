namespace Online_Course
{
    partial class FormRemoveCourse
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
            this.labelDeleteCourse = new System.Windows.Forms.Label();
            this.guna2ButtonClear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonDelete = new Guna.UI2.WinForms.Guna2Button();
            this.dateTimePickerRelease = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ComboBoxInstr = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Topic = new System.Windows.Forms.Label();
            this.guna2ComboBoxTopic = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.guna2TextBoxCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelReleaseDateCourse = new System.Windows.Forms.Label();
            this.guna2TextBoxAddDescriptionCourse = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxAddNameCourse = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelDescriptionCourse = new System.Windows.Forms.Label();
            this.labelNameCourse = new System.Windows.Forms.Label();
            this.guna2TextBoxAddLanguageCourse = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBoxAddIdCourse = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelLanguageCourse = new System.Windows.Forms.Label();
            this.labelIdCourse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDeleteCourse
            // 
            this.labelDeleteCourse.AutoSize = true;
            this.labelDeleteCourse.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeleteCourse.Location = new System.Drawing.Point(156, 35);
            this.labelDeleteCourse.Name = "labelDeleteCourse";
            this.labelDeleteCourse.Size = new System.Drawing.Size(260, 40);
            this.labelDeleteCourse.TabIndex = 74;
            this.labelDeleteCourse.Text = "DELETE COURSE";
            // 
            // guna2ButtonClear
            // 
            this.guna2ButtonClear.BorderRadius = 22;
            this.guna2ButtonClear.CheckedState.Parent = this.guna2ButtonClear;
            this.guna2ButtonClear.CustomImages.Parent = this.guna2ButtonClear;
            this.guna2ButtonClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(211)))), ((int)(((byte)(246)))));
            this.guna2ButtonClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonClear.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonClear.HoverState.Parent = this.guna2ButtonClear;
            this.guna2ButtonClear.Location = new System.Drawing.Point(368, 775);
            this.guna2ButtonClear.Name = "guna2ButtonClear";
            this.guna2ButtonClear.ShadowDecoration.Parent = this.guna2ButtonClear;
            this.guna2ButtonClear.Size = new System.Drawing.Size(84, 41);
            this.guna2ButtonClear.TabIndex = 69;
            this.guna2ButtonClear.Text = "CLEAR";
            this.guna2ButtonClear.Click += new System.EventHandler(this.guna2ButtonClear_Click);
            // 
            // guna2ButtonDelete
            // 
            this.guna2ButtonDelete.BorderRadius = 22;
            this.guna2ButtonDelete.CheckedState.Parent = this.guna2ButtonDelete;
            this.guna2ButtonDelete.CustomImages.Parent = this.guna2ButtonDelete;
            this.guna2ButtonDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(211)))), ((int)(((byte)(246)))));
            this.guna2ButtonDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonDelete.HoverState.Parent = this.guna2ButtonDelete;
            this.guna2ButtonDelete.Location = new System.Drawing.Point(121, 775);
            this.guna2ButtonDelete.Name = "guna2ButtonDelete";
            this.guna2ButtonDelete.ShadowDecoration.Parent = this.guna2ButtonDelete;
            this.guna2ButtonDelete.Size = new System.Drawing.Size(84, 41);
            this.guna2ButtonDelete.TabIndex = 68;
            this.guna2ButtonDelete.Text = "DELETE";
            this.guna2ButtonDelete.Click += new System.EventHandler(this.guna2ButtonDelete_Click);
            // 
            // dateTimePickerRelease
            // 
            this.dateTimePickerRelease.Enabled = false;
            this.dateTimePickerRelease.Location = new System.Drawing.Point(145, 472);
            this.dateTimePickerRelease.Name = "dateTimePickerRelease";
            this.dateTimePickerRelease.Size = new System.Drawing.Size(312, 22);
            this.dateTimePickerRelease.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 88;
            this.label1.Text = "Instructor";
            // 
            // guna2ComboBoxInstr
            // 
            this.guna2ComboBoxInstr.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxInstr.BorderRadius = 22;
            this.guna2ComboBoxInstr.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxInstr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxInstr.Enabled = false;
            this.guna2ComboBoxInstr.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxInstr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxInstr.FocusedState.Parent = this.guna2ComboBoxInstr;
            this.guna2ComboBoxInstr.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBoxInstr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBoxInstr.HoverState.Parent = this.guna2ComboBoxInstr;
            this.guna2ComboBoxInstr.ItemHeight = 30;
            this.guna2ComboBoxInstr.Items.AddRange(new object[] {
            "Course Id",
            "Course Name",
            "Language",
            "Price",
            "Topic Name",
            "Instructor Name"});
            this.guna2ComboBoxInstr.ItemsAppearance.Parent = this.guna2ComboBoxInstr;
            this.guna2ComboBoxInstr.Location = new System.Drawing.Point(125, 546);
            this.guna2ComboBoxInstr.Name = "guna2ComboBoxInstr";
            this.guna2ComboBoxInstr.ShadowDecoration.Parent = this.guna2ComboBoxInstr;
            this.guna2ComboBoxInstr.Size = new System.Drawing.Size(332, 36);
            this.guna2ComboBoxInstr.TabIndex = 89;
            // 
            // Topic
            // 
            this.Topic.AutoSize = true;
            this.Topic.Location = new System.Drawing.Point(137, 596);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(43, 17);
            this.Topic.TabIndex = 90;
            this.Topic.Text = "Topic";
            // 
            // guna2ComboBoxTopic
            // 
            this.guna2ComboBoxTopic.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxTopic.BorderRadius = 22;
            this.guna2ComboBoxTopic.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxTopic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxTopic.Enabled = false;
            this.guna2ComboBoxTopic.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxTopic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxTopic.FocusedState.Parent = this.guna2ComboBoxTopic;
            this.guna2ComboBoxTopic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBoxTopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBoxTopic.HoverState.Parent = this.guna2ComboBoxTopic;
            this.guna2ComboBoxTopic.ItemHeight = 30;
            this.guna2ComboBoxTopic.Items.AddRange(new object[] {
            "Course Id",
            "Course Name",
            "Language",
            "Price",
            "Topic Name",
            "Instructor Name"});
            this.guna2ComboBoxTopic.ItemsAppearance.Parent = this.guna2ComboBoxTopic;
            this.guna2ComboBoxTopic.Location = new System.Drawing.Point(125, 627);
            this.guna2ComboBoxTopic.Name = "guna2ComboBoxTopic";
            this.guna2ComboBoxTopic.ShadowDecoration.Parent = this.guna2ComboBoxTopic;
            this.guna2ComboBoxTopic.Size = new System.Drawing.Size(327, 36);
            this.guna2ComboBoxTopic.TabIndex = 91;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(137, 676);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(40, 17);
            this.labelCost.TabIndex = 92;
            this.labelCost.Text = "Price";
            // 
            // guna2TextBoxCost
            // 
            this.guna2TextBoxCost.BorderRadius = 22;
            this.guna2TextBoxCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxCost.DefaultText = "";
            this.guna2TextBoxCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxCost.DisabledState.Parent = this.guna2TextBoxCost;
            this.guna2TextBoxCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxCost.Enabled = false;
            this.guna2TextBoxCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxCost.FocusedState.Parent = this.guna2TextBoxCost;
            this.guna2TextBoxCost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxCost.HoverState.Parent = this.guna2TextBoxCost;
            this.guna2TextBoxCost.Location = new System.Drawing.Point(127, 716);
            this.guna2TextBoxCost.Name = "guna2TextBoxCost";
            this.guna2TextBoxCost.PasswordChar = '\0';
            this.guna2TextBoxCost.PlaceholderText = "";
            this.guna2TextBoxCost.SelectedText = "";
            this.guna2TextBoxCost.ShadowDecoration.Parent = this.guna2TextBoxCost;
            this.guna2TextBoxCost.Size = new System.Drawing.Size(330, 36);
            this.guna2TextBoxCost.TabIndex = 93;
            // 
            // labelReleaseDateCourse
            // 
            this.labelReleaseDateCourse.AutoSize = true;
            this.labelReleaseDateCourse.Location = new System.Drawing.Point(142, 434);
            this.labelReleaseDateCourse.Name = "labelReleaseDateCourse";
            this.labelReleaseDateCourse.Size = new System.Drawing.Size(94, 17);
            this.labelReleaseDateCourse.TabIndex = 86;
            this.labelReleaseDateCourse.Text = "Release Date";
            // 
            // guna2TextBoxAddDescriptionCourse
            // 
            this.guna2TextBoxAddDescriptionCourse.BorderRadius = 22;
            this.guna2TextBoxAddDescriptionCourse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxAddDescriptionCourse.DefaultText = "";
            this.guna2TextBoxAddDescriptionCourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxAddDescriptionCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxAddDescriptionCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxAddDescriptionCourse.DisabledState.Parent = this.guna2TextBoxAddDescriptionCourse;
            this.guna2TextBoxAddDescriptionCourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxAddDescriptionCourse.Enabled = false;
            this.guna2TextBoxAddDescriptionCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxAddDescriptionCourse.FocusedState.Parent = this.guna2TextBoxAddDescriptionCourse;
            this.guna2TextBoxAddDescriptionCourse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxAddDescriptionCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxAddDescriptionCourse.HoverState.Parent = this.guna2TextBoxAddDescriptionCourse;
            this.guna2TextBoxAddDescriptionCourse.Location = new System.Drawing.Point(127, 273);
            this.guna2TextBoxAddDescriptionCourse.Multiline = true;
            this.guna2TextBoxAddDescriptionCourse.Name = "guna2TextBoxAddDescriptionCourse";
            this.guna2TextBoxAddDescriptionCourse.PasswordChar = '\0';
            this.guna2TextBoxAddDescriptionCourse.PlaceholderText = "";
            this.guna2TextBoxAddDescriptionCourse.SelectedText = "";
            this.guna2TextBoxAddDescriptionCourse.ShadowDecoration.Parent = this.guna2TextBoxAddDescriptionCourse;
            this.guna2TextBoxAddDescriptionCourse.Size = new System.Drawing.Size(330, 76);
            this.guna2TextBoxAddDescriptionCourse.TabIndex = 83;
            // 
            // guna2TextBoxAddNameCourse
            // 
            this.guna2TextBoxAddNameCourse.BorderRadius = 22;
            this.guna2TextBoxAddNameCourse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxAddNameCourse.DefaultText = "";
            this.guna2TextBoxAddNameCourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxAddNameCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxAddNameCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxAddNameCourse.DisabledState.Parent = this.guna2TextBoxAddNameCourse;
            this.guna2TextBoxAddNameCourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxAddNameCourse.Enabled = false;
            this.guna2TextBoxAddNameCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxAddNameCourse.FocusedState.Parent = this.guna2TextBoxAddNameCourse;
            this.guna2TextBoxAddNameCourse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxAddNameCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxAddNameCourse.HoverState.Parent = this.guna2TextBoxAddNameCourse;
            this.guna2TextBoxAddNameCourse.Location = new System.Drawing.Point(127, 188);
            this.guna2TextBoxAddNameCourse.Name = "guna2TextBoxAddNameCourse";
            this.guna2TextBoxAddNameCourse.PasswordChar = '\0';
            this.guna2TextBoxAddNameCourse.PlaceholderText = "";
            this.guna2TextBoxAddNameCourse.SelectedText = "";
            this.guna2TextBoxAddNameCourse.ShadowDecoration.Parent = this.guna2TextBoxAddNameCourse;
            this.guna2TextBoxAddNameCourse.Size = new System.Drawing.Size(327, 36);
            this.guna2TextBoxAddNameCourse.TabIndex = 81;
            // 
            // labelDescriptionCourse
            // 
            this.labelDescriptionCourse.AutoSize = true;
            this.labelDescriptionCourse.Location = new System.Drawing.Point(142, 241);
            this.labelDescriptionCourse.Name = "labelDescriptionCourse";
            this.labelDescriptionCourse.Size = new System.Drawing.Size(79, 17);
            this.labelDescriptionCourse.TabIndex = 82;
            this.labelDescriptionCourse.Text = "Description";
            // 
            // labelNameCourse
            // 
            this.labelNameCourse.AutoSize = true;
            this.labelNameCourse.Location = new System.Drawing.Point(142, 157);
            this.labelNameCourse.Name = "labelNameCourse";
            this.labelNameCourse.Size = new System.Drawing.Size(45, 17);
            this.labelNameCourse.TabIndex = 80;
            this.labelNameCourse.Text = "Name";
            // 
            // guna2TextBoxAddLanguageCourse
            // 
            this.guna2TextBoxAddLanguageCourse.BorderRadius = 22;
            this.guna2TextBoxAddLanguageCourse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxAddLanguageCourse.DefaultText = "";
            this.guna2TextBoxAddLanguageCourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxAddLanguageCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxAddLanguageCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxAddLanguageCourse.DisabledState.Parent = this.guna2TextBoxAddLanguageCourse;
            this.guna2TextBoxAddLanguageCourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxAddLanguageCourse.Enabled = false;
            this.guna2TextBoxAddLanguageCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxAddLanguageCourse.FocusedState.Parent = this.guna2TextBoxAddLanguageCourse;
            this.guna2TextBoxAddLanguageCourse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxAddLanguageCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxAddLanguageCourse.HoverState.Parent = this.guna2TextBoxAddLanguageCourse;
            this.guna2TextBoxAddLanguageCourse.Location = new System.Drawing.Point(127, 381);
            this.guna2TextBoxAddLanguageCourse.Name = "guna2TextBoxAddLanguageCourse";
            this.guna2TextBoxAddLanguageCourse.PasswordChar = '\0';
            this.guna2TextBoxAddLanguageCourse.PlaceholderText = "";
            this.guna2TextBoxAddLanguageCourse.SelectedText = "";
            this.guna2TextBoxAddLanguageCourse.ShadowDecoration.Parent = this.guna2TextBoxAddLanguageCourse;
            this.guna2TextBoxAddLanguageCourse.Size = new System.Drawing.Size(330, 36);
            this.guna2TextBoxAddLanguageCourse.TabIndex = 85;
            // 
            // guna2TextBoxAddIdCourse
            // 
            this.guna2TextBoxAddIdCourse.BorderRadius = 22;
            this.guna2TextBoxAddIdCourse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxAddIdCourse.DefaultText = "";
            this.guna2TextBoxAddIdCourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxAddIdCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxAddIdCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxAddIdCourse.DisabledState.Parent = this.guna2TextBoxAddIdCourse;
            this.guna2TextBoxAddIdCourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxAddIdCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxAddIdCourse.FocusedState.Parent = this.guna2TextBoxAddIdCourse;
            this.guna2TextBoxAddIdCourse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxAddIdCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxAddIdCourse.HoverState.Parent = this.guna2TextBoxAddIdCourse;
            this.guna2TextBoxAddIdCourse.Location = new System.Drawing.Point(127, 106);
            this.guna2TextBoxAddIdCourse.MaxLength = 5;
            this.guna2TextBoxAddIdCourse.Name = "guna2TextBoxAddIdCourse";
            this.guna2TextBoxAddIdCourse.PasswordChar = '\0';
            this.guna2TextBoxAddIdCourse.PlaceholderText = "";
            this.guna2TextBoxAddIdCourse.SelectedText = "";
            this.guna2TextBoxAddIdCourse.ShadowDecoration.Parent = this.guna2TextBoxAddIdCourse;
            this.guna2TextBoxAddIdCourse.Size = new System.Drawing.Size(330, 36);
            this.guna2TextBoxAddIdCourse.TabIndex = 79;
            this.guna2TextBoxAddIdCourse.TextChanged += new System.EventHandler(this.guna2TextBoxAddIdCourse_TextChanged);
            // 
            // labelLanguageCourse
            // 
            this.labelLanguageCourse.AutoSize = true;
            this.labelLanguageCourse.Location = new System.Drawing.Point(142, 352);
            this.labelLanguageCourse.Name = "labelLanguageCourse";
            this.labelLanguageCourse.Size = new System.Drawing.Size(72, 17);
            this.labelLanguageCourse.TabIndex = 84;
            this.labelLanguageCourse.Text = "Language";
            // 
            // labelIdCourse
            // 
            this.labelIdCourse.AutoSize = true;
            this.labelIdCourse.Location = new System.Drawing.Point(142, 76);
            this.labelIdCourse.Name = "labelIdCourse";
            this.labelIdCourse.Size = new System.Drawing.Size(19, 17);
            this.labelIdCourse.TabIndex = 78;
            this.labelIdCourse.Text = "Id";
            // 
            // FormRemoveCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(582, 828);
            this.Controls.Add(this.dateTimePickerRelease);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ComboBoxInstr);
            this.Controls.Add(this.Topic);
            this.Controls.Add(this.guna2ComboBoxTopic);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.guna2TextBoxCost);
            this.Controls.Add(this.labelReleaseDateCourse);
            this.Controls.Add(this.guna2TextBoxAddDescriptionCourse);
            this.Controls.Add(this.guna2TextBoxAddNameCourse);
            this.Controls.Add(this.labelDescriptionCourse);
            this.Controls.Add(this.labelNameCourse);
            this.Controls.Add(this.guna2TextBoxAddLanguageCourse);
            this.Controls.Add(this.guna2TextBoxAddIdCourse);
            this.Controls.Add(this.labelLanguageCourse);
            this.Controls.Add(this.labelIdCourse);
            this.Controls.Add(this.labelDeleteCourse);
            this.Controls.Add(this.guna2ButtonClear);
            this.Controls.Add(this.guna2ButtonDelete);
            this.Name = "FormRemoveCourse";
            this.Text = "FormRemoveCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDeleteCourse;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonClear;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonDelete;
        private System.Windows.Forms.DateTimePicker dateTimePickerRelease;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxInstr;
        private System.Windows.Forms.Label Topic;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxTopic;
        private System.Windows.Forms.Label labelCost;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxCost;
        private System.Windows.Forms.Label labelReleaseDateCourse;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxAddDescriptionCourse;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxAddNameCourse;
        private System.Windows.Forms.Label labelDescriptionCourse;
        private System.Windows.Forms.Label labelNameCourse;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxAddLanguageCourse;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxAddIdCourse;
        private System.Windows.Forms.Label labelLanguageCourse;
        private System.Windows.Forms.Label labelIdCourse;
    }
}