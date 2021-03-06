﻿namespace Online_Course
{
    partial class FormEditCourse
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
            this.labelEditCourse = new System.Windows.Forms.Label();
            this.guna2ButtonClear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonEdit = new Guna.UI2.WinForms.Guna2Button();
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
            this.labelLanguageCourse = new System.Windows.Forms.Label();
            this.labelIdCourse = new System.Windows.Forms.Label();
            this.dateTimePickerRelease = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ComboBoxEditCourse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // labelEditCourse
            // 
            this.labelEditCourse.AutoSize = true;
            this.labelEditCourse.BackColor = System.Drawing.Color.Transparent;
            this.labelEditCourse.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditCourse.Location = new System.Drawing.Point(182, 22);
            this.labelEditCourse.Name = "labelEditCourse";
            this.labelEditCourse.Size = new System.Drawing.Size(220, 40);
            this.labelEditCourse.TabIndex = 0;
            this.labelEditCourse.Text = "EDIT COURSE";
            // 
            // guna2ButtonClear
            // 
            this.guna2ButtonClear.BackColor = System.Drawing.Color.Transparent;
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
            this.guna2ButtonClear.TabIndex = 18;
            this.guna2ButtonClear.Text = "CLEAR";
            this.guna2ButtonClear.Click += new System.EventHandler(this.guna2ButtonClear_Click);
            // 
            // guna2ButtonEdit
            // 
            this.guna2ButtonEdit.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonEdit.BorderRadius = 22;
            this.guna2ButtonEdit.CheckedState.Parent = this.guna2ButtonEdit;
            this.guna2ButtonEdit.CustomImages.Parent = this.guna2ButtonEdit;
            this.guna2ButtonEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(211)))), ((int)(((byte)(246)))));
            this.guna2ButtonEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonEdit.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonEdit.HoverState.Parent = this.guna2ButtonEdit;
            this.guna2ButtonEdit.Location = new System.Drawing.Point(125, 775);
            this.guna2ButtonEdit.Name = "guna2ButtonEdit";
            this.guna2ButtonEdit.ShadowDecoration.Parent = this.guna2ButtonEdit;
            this.guna2ButtonEdit.Size = new System.Drawing.Size(84, 41);
            this.guna2ButtonEdit.TabIndex = 17;
            this.guna2ButtonEdit.Text = "EDIT";
            this.guna2ButtonEdit.Click += new System.EventHandler(this.guna2ButtonEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(142, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 11;
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
            this.guna2ComboBoxInstr.TabIndex = 12;
            // 
            // Topic
            // 
            this.Topic.AutoSize = true;
            this.Topic.BackColor = System.Drawing.Color.Transparent;
            this.Topic.Location = new System.Drawing.Point(137, 596);
            this.Topic.Name = "Topic";
            this.Topic.Size = new System.Drawing.Size(43, 17);
            this.Topic.TabIndex = 13;
            this.Topic.Text = "Topic";
            // 
            // guna2ComboBoxTopic
            // 
            this.guna2ComboBoxTopic.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxTopic.BorderRadius = 22;
            this.guna2ComboBoxTopic.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxTopic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.guna2ComboBoxTopic.TabIndex = 14;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.BackColor = System.Drawing.Color.Transparent;
            this.labelCost.Location = new System.Drawing.Point(137, 676);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(40, 17);
            this.labelCost.TabIndex = 15;
            this.labelCost.Text = "Price";
            // 
            // guna2TextBoxCost
            // 
            this.guna2TextBoxCost.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxCost.BorderRadius = 22;
            this.guna2TextBoxCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxCost.DefaultText = "";
            this.guna2TextBoxCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxCost.DisabledState.Parent = this.guna2TextBoxCost;
            this.guna2TextBoxCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
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
            this.guna2TextBoxCost.TabIndex = 16;
            // 
            // labelReleaseDateCourse
            // 
            this.labelReleaseDateCourse.AutoSize = true;
            this.labelReleaseDateCourse.BackColor = System.Drawing.Color.Transparent;
            this.labelReleaseDateCourse.Location = new System.Drawing.Point(142, 434);
            this.labelReleaseDateCourse.Name = "labelReleaseDateCourse";
            this.labelReleaseDateCourse.Size = new System.Drawing.Size(94, 17);
            this.labelReleaseDateCourse.TabIndex = 9;
            this.labelReleaseDateCourse.Text = "Release Date";
            // 
            // guna2TextBoxAddDescriptionCourse
            // 
            this.guna2TextBoxAddDescriptionCourse.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxAddDescriptionCourse.BorderRadius = 22;
            this.guna2TextBoxAddDescriptionCourse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxAddDescriptionCourse.DefaultText = "";
            this.guna2TextBoxAddDescriptionCourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxAddDescriptionCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxAddDescriptionCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxAddDescriptionCourse.DisabledState.Parent = this.guna2TextBoxAddDescriptionCourse;
            this.guna2TextBoxAddDescriptionCourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
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
            this.guna2TextBoxAddDescriptionCourse.TabIndex = 6;
            // 
            // guna2TextBoxAddNameCourse
            // 
            this.guna2TextBoxAddNameCourse.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxAddNameCourse.BorderRadius = 22;
            this.guna2TextBoxAddNameCourse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxAddNameCourse.DefaultText = "";
            this.guna2TextBoxAddNameCourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxAddNameCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxAddNameCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxAddNameCourse.DisabledState.Parent = this.guna2TextBoxAddNameCourse;
            this.guna2TextBoxAddNameCourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
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
            this.guna2TextBoxAddNameCourse.TabIndex = 4;
            // 
            // labelDescriptionCourse
            // 
            this.labelDescriptionCourse.AutoSize = true;
            this.labelDescriptionCourse.BackColor = System.Drawing.Color.Transparent;
            this.labelDescriptionCourse.Location = new System.Drawing.Point(142, 241);
            this.labelDescriptionCourse.Name = "labelDescriptionCourse";
            this.labelDescriptionCourse.Size = new System.Drawing.Size(79, 17);
            this.labelDescriptionCourse.TabIndex = 5;
            this.labelDescriptionCourse.Text = "Description";
            // 
            // labelNameCourse
            // 
            this.labelNameCourse.AutoSize = true;
            this.labelNameCourse.BackColor = System.Drawing.Color.Transparent;
            this.labelNameCourse.Location = new System.Drawing.Point(142, 157);
            this.labelNameCourse.Name = "labelNameCourse";
            this.labelNameCourse.Size = new System.Drawing.Size(45, 17);
            this.labelNameCourse.TabIndex = 3;
            this.labelNameCourse.Text = "Name";
            // 
            // guna2TextBoxAddLanguageCourse
            // 
            this.guna2TextBoxAddLanguageCourse.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxAddLanguageCourse.BorderRadius = 22;
            this.guna2TextBoxAddLanguageCourse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxAddLanguageCourse.DefaultText = "";
            this.guna2TextBoxAddLanguageCourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxAddLanguageCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxAddLanguageCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxAddLanguageCourse.DisabledState.Parent = this.guna2TextBoxAddLanguageCourse;
            this.guna2TextBoxAddLanguageCourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
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
            this.guna2TextBoxAddLanguageCourse.TabIndex = 8;
            // 
            // labelLanguageCourse
            // 
            this.labelLanguageCourse.AutoSize = true;
            this.labelLanguageCourse.BackColor = System.Drawing.Color.Transparent;
            this.labelLanguageCourse.Location = new System.Drawing.Point(142, 352);
            this.labelLanguageCourse.Name = "labelLanguageCourse";
            this.labelLanguageCourse.Size = new System.Drawing.Size(72, 17);
            this.labelLanguageCourse.TabIndex = 7;
            this.labelLanguageCourse.Text = "Language";
            // 
            // labelIdCourse
            // 
            this.labelIdCourse.AutoSize = true;
            this.labelIdCourse.BackColor = System.Drawing.Color.Transparent;
            this.labelIdCourse.Location = new System.Drawing.Point(142, 76);
            this.labelIdCourse.Name = "labelIdCourse";
            this.labelIdCourse.Size = new System.Drawing.Size(19, 17);
            this.labelIdCourse.TabIndex = 1;
            this.labelIdCourse.Text = "Id";
            // 
            // dateTimePickerRelease
            // 
            this.dateTimePickerRelease.BackColor = System.Drawing.Color.Transparent;
            this.dateTimePickerRelease.BorderRadius = 18;
            this.dateTimePickerRelease.CheckedState.Parent = this.dateTimePickerRelease;
            this.dateTimePickerRelease.FillColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePickerRelease.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerRelease.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerRelease.HoverState.Parent = this.dateTimePickerRelease;
            this.dateTimePickerRelease.Location = new System.Drawing.Point(127, 464);
            this.dateTimePickerRelease.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerRelease.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerRelease.Name = "dateTimePickerRelease";
            this.dateTimePickerRelease.ShadowDecoration.Parent = this.dateTimePickerRelease;
            this.dateTimePickerRelease.Size = new System.Drawing.Size(330, 36);
            this.dateTimePickerRelease.TabIndex = 19;
            this.dateTimePickerRelease.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateTimePickerRelease.Value = new System.DateTime(2020, 11, 29, 21, 2, 31, 570);
            // 
            // guna2ComboBoxEditCourse
            // 
            this.guna2ComboBoxEditCourse.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxEditCourse.BorderRadius = 22;
            this.guna2ComboBoxEditCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxEditCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxEditCourse.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxEditCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxEditCourse.FocusedState.Parent = this.guna2ComboBoxEditCourse;
            this.guna2ComboBoxEditCourse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBoxEditCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBoxEditCourse.HoverState.Parent = this.guna2ComboBoxEditCourse;
            this.guna2ComboBoxEditCourse.ItemHeight = 30;
            this.guna2ComboBoxEditCourse.ItemsAppearance.Parent = this.guna2ComboBoxEditCourse;
            this.guna2ComboBoxEditCourse.Location = new System.Drawing.Point(127, 107);
            this.guna2ComboBoxEditCourse.Name = "guna2ComboBoxEditCourse";
            this.guna2ComboBoxEditCourse.ShadowDecoration.Parent = this.guna2ComboBoxEditCourse;
            this.guna2ComboBoxEditCourse.Size = new System.Drawing.Size(330, 36);
            this.guna2ComboBoxEditCourse.TabIndex = 20;
            this.guna2ComboBoxEditCourse.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBoxEditCourse_SelectedIndexChanged);
            // 
            // FormEditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Online_Course.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 828);
            this.Controls.Add(this.guna2ComboBoxEditCourse);
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
            this.Controls.Add(this.labelLanguageCourse);
            this.Controls.Add(this.labelIdCourse);
            this.Controls.Add(this.labelEditCourse);
            this.Controls.Add(this.guna2ButtonClear);
            this.Controls.Add(this.guna2ButtonEdit);
            this.Name = "FormEditCourse";
            this.Text = "FormEditCourse";
            this.Load += new System.EventHandler(this.FormEditCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEditCourse;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonClear;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonEdit;
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
        private System.Windows.Forms.Label labelLanguageCourse;
        private System.Windows.Forms.Label labelIdCourse;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerRelease;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxEditCourse;
    }
}