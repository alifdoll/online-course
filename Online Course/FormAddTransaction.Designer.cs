namespace Online_Course
{
    partial class FormAddTransaction
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
            this.guna2TextBoxNota = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelNoNota = new System.Windows.Forms.Label();
            this.labelAddTransaction = new System.Windows.Forms.Label();
            this.guna2ComboBoxCourse = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelCourse = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2ButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBoxHarga = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.no_nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ButtonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonPrint = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2TextBoxNota
            // 
            this.guna2TextBoxNota.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxNota.BorderRadius = 18;
            this.guna2TextBoxNota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxNota.DefaultText = "";
            this.guna2TextBoxNota.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxNota.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxNota.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxNota.DisabledState.Parent = this.guna2TextBoxNota;
            this.guna2TextBoxNota.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxNota.Enabled = false;
            this.guna2TextBoxNota.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxNota.FocusedState.Parent = this.guna2TextBoxNota;
            this.guna2TextBoxNota.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxNota.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxNota.HoverState.Parent = this.guna2TextBoxNota;
            this.guna2TextBoxNota.Location = new System.Drawing.Point(229, 98);
            this.guna2TextBoxNota.Name = "guna2TextBoxNota";
            this.guna2TextBoxNota.PasswordChar = '\0';
            this.guna2TextBoxNota.PlaceholderText = "";
            this.guna2TextBoxNota.SelectedText = "";
            this.guna2TextBoxNota.ShadowDecoration.Parent = this.guna2TextBoxNota;
            this.guna2TextBoxNota.Size = new System.Drawing.Size(272, 36);
            this.guna2TextBoxNota.TabIndex = 93;
            // 
            // labelNoNota
            // 
            this.labelNoNota.AutoSize = true;
            this.labelNoNota.BackColor = System.Drawing.Color.Transparent;
            this.labelNoNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoNota.Location = new System.Drawing.Point(83, 109);
            this.labelNoNota.Name = "labelNoNota";
            this.labelNoNota.Size = new System.Drawing.Size(93, 25);
            this.labelNoNota.TabIndex = 91;
            this.labelNoNota.Text = "No Nota  ";
            // 
            // labelAddTransaction
            // 
            this.labelAddTransaction.AutoSize = true;
            this.labelAddTransaction.BackColor = System.Drawing.Color.Transparent;
            this.labelAddTransaction.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddTransaction.Location = new System.Drawing.Point(126, 24);
            this.labelAddTransaction.Name = "labelAddTransaction";
            this.labelAddTransaction.Size = new System.Drawing.Size(325, 40);
            this.labelAddTransaction.TabIndex = 90;
            this.labelAddTransaction.Text = "ADD TRANSACTION";
            // 
            // guna2ComboBoxCourse
            // 
            this.guna2ComboBoxCourse.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBoxCourse.BorderRadius = 18;
            this.guna2ComboBoxCourse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBoxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBoxCourse.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBoxCourse.FocusedState.Parent = this.guna2ComboBoxCourse;
            this.guna2ComboBoxCourse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBoxCourse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBoxCourse.HoverState.Parent = this.guna2ComboBoxCourse;
            this.guna2ComboBoxCourse.ItemHeight = 30;
            this.guna2ComboBoxCourse.Items.AddRange(new object[] {
            "Id",
            "Nama"});
            this.guna2ComboBoxCourse.ItemsAppearance.Parent = this.guna2ComboBoxCourse;
            this.guna2ComboBoxCourse.Location = new System.Drawing.Point(229, 198);
            this.guna2ComboBoxCourse.Name = "guna2ComboBoxCourse";
            this.guna2ComboBoxCourse.ShadowDecoration.Parent = this.guna2ComboBoxCourse;
            this.guna2ComboBoxCourse.Size = new System.Drawing.Size(272, 36);
            this.guna2ComboBoxCourse.TabIndex = 96;
            this.guna2ComboBoxCourse.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBoxCourse_SelectedIndexChanged);
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.BackColor = System.Drawing.Color.Transparent;
            this.labelCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCourse.Location = new System.Drawing.Point(83, 209);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(76, 25);
            this.labelCourse.TabIndex = 95;
            this.labelCourse.Text = "Course";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(83, 159);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(58, 25);
            this.labelDate.TabIndex = 98;
            this.labelDate.Text = "Date ";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.BorderRadius = 18;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Enabled = false;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(229, 148);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(272, 36);
            this.guna2DateTimePicker1.TabIndex = 99;
            this.guna2DateTimePicker1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2DateTimePicker1.Value = new System.DateTime(2020, 11, 21, 23, 34, 28, 303);
            // 
            // guna2ButtonSave
            // 
            this.guna2ButtonSave.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonSave.BorderRadius = 18;
            this.guna2ButtonSave.CheckedState.Parent = this.guna2ButtonSave;
            this.guna2ButtonSave.CustomImages.Parent = this.guna2ButtonSave;
            this.guna2ButtonSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonSave.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonSave.HoverState.Parent = this.guna2ButtonSave;
            this.guna2ButtonSave.Location = new System.Drawing.Point(366, 325);
            this.guna2ButtonSave.Name = "guna2ButtonSave";
            this.guna2ButtonSave.ShadowDecoration.Parent = this.guna2ButtonSave;
            this.guna2ButtonSave.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonSave.TabIndex = 100;
            this.guna2ButtonSave.Text = "SAVE";
            this.guna2ButtonSave.Click += new System.EventHandler(this.guna2ButtonAdd_Click);
            // 
            // guna2TextBoxHarga
            // 
            this.guna2TextBoxHarga.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBoxHarga.BorderRadius = 18;
            this.guna2TextBoxHarga.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxHarga.DefaultText = "";
            this.guna2TextBoxHarga.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxHarga.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxHarga.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxHarga.DisabledState.Parent = this.guna2TextBoxHarga;
            this.guna2TextBoxHarga.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxHarga.Enabled = false;
            this.guna2TextBoxHarga.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxHarga.FocusedState.Parent = this.guna2TextBoxHarga;
            this.guna2TextBoxHarga.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxHarga.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxHarga.HoverState.Parent = this.guna2TextBoxHarga;
            this.guna2TextBoxHarga.Location = new System.Drawing.Point(229, 252);
            this.guna2TextBoxHarga.Name = "guna2TextBoxHarga";
            this.guna2TextBoxHarga.PasswordChar = '\0';
            this.guna2TextBoxHarga.PlaceholderText = "";
            this.guna2TextBoxHarga.SelectedText = "";
            this.guna2TextBoxHarga.ShadowDecoration.Parent = this.guna2TextBoxHarga;
            this.guna2TextBoxHarga.Size = new System.Drawing.Size(272, 36);
            this.guna2TextBoxHarga.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 103;
            this.label1.Text = "Harga";
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_nota,
            this.tanggal,
            this.id_course,
            this.nama,
            this.harga});
            this.dataGridViewSearch.Location = new System.Drawing.Point(27, 405);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RowHeadersWidth = 51;
            this.dataGridViewSearch.RowTemplate.Height = 24;
            this.dataGridViewSearch.Size = new System.Drawing.Size(534, 289);
            this.dataGridViewSearch.TabIndex = 104;
            // 
            // no_nota
            // 
            this.no_nota.HeaderText = "No Nota";
            this.no_nota.MinimumWidth = 6;
            this.no_nota.Name = "no_nota";
            this.no_nota.Width = 125;
            // 
            // tanggal
            // 
            this.tanggal.HeaderText = "Tanggal";
            this.tanggal.MinimumWidth = 6;
            this.tanggal.Name = "tanggal";
            this.tanggal.Width = 125;
            // 
            // id_course
            // 
            this.id_course.HeaderText = "Id Course";
            this.id_course.MinimumWidth = 6;
            this.id_course.Name = "id_course";
            this.id_course.Width = 125;
            // 
            // nama
            // 
            this.nama.HeaderText = "Nama Course";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.Width = 125;
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga";
            this.harga.MinimumWidth = 6;
            this.harga.Name = "harga";
            this.harga.Width = 125;
            // 
            // guna2ButtonAdd
            // 
            this.guna2ButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonAdd.BorderRadius = 18;
            this.guna2ButtonAdd.CheckedState.Parent = this.guna2ButtonAdd;
            this.guna2ButtonAdd.CustomImages.Parent = this.guna2ButtonAdd;
            this.guna2ButtonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonAdd.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonAdd.HoverState.Parent = this.guna2ButtonAdd;
            this.guna2ButtonAdd.Location = new System.Drawing.Point(158, 325);
            this.guna2ButtonAdd.Name = "guna2ButtonAdd";
            this.guna2ButtonAdd.ShadowDecoration.Parent = this.guna2ButtonAdd;
            this.guna2ButtonAdd.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonAdd.TabIndex = 105;
            this.guna2ButtonAdd.Text = "ADD";
            this.guna2ButtonAdd.Click += new System.EventHandler(this.guna2ButtonAdd_Click_1);
            // 
            // guna2ButtonPrint
            // 
            this.guna2ButtonPrint.BackColor = System.Drawing.Color.Transparent;
            this.guna2ButtonPrint.BorderRadius = 18;
            this.guna2ButtonPrint.CheckedState.Parent = this.guna2ButtonPrint;
            this.guna2ButtonPrint.CustomImages.Parent = this.guna2ButtonPrint;
            this.guna2ButtonPrint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ButtonPrint.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonPrint.HoverState.Parent = this.guna2ButtonPrint;
            this.guna2ButtonPrint.Location = new System.Drawing.Point(229, 712);
            this.guna2ButtonPrint.Name = "guna2ButtonPrint";
            this.guna2ButtonPrint.ShadowDecoration.Parent = this.guna2ButtonPrint;
            this.guna2ButtonPrint.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonPrint.TabIndex = 106;
            this.guna2ButtonPrint.Text = "PRINT";
            this.guna2ButtonPrint.Click += new System.EventHandler(this.guna2ButtonPrint_Click);
            // 
            // FormAddTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Online_Course.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 760);
            this.Controls.Add(this.guna2ButtonPrint);
            this.Controls.Add(this.guna2ButtonAdd);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TextBoxHarga);
            this.Controls.Add(this.guna2ButtonSave);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.guna2ComboBoxCourse);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.guna2TextBoxNota);
            this.Controls.Add(this.labelNoNota);
            this.Controls.Add(this.labelAddTransaction);
            this.Name = "FormAddTransaction";
            this.Text = "FormAddTransaction";
            this.Load += new System.EventHandler(this.FormAddTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxNota;
        private System.Windows.Forms.Label labelNoNota;
        private System.Windows.Forms.Label labelAddTransaction;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxCourse;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.Label labelDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonSave;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxHarga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_course;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonAdd;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonPrint;
    }
}