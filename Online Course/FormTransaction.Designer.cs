namespace Online_Course
{
    partial class FormTransaction
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
            this.guna2TextBoxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ComboBoxSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelAddTransaction = new System.Windows.Forms.Label();
            this.dataGridViewSearch = new System.Windows.Forms.DataGridView();
            this.no_nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ButtonPrint = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).BeginInit();
            this.SuspendLayout();
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
            this.guna2TextBoxSearch.Location = new System.Drawing.Point(289, 94);
            this.guna2TextBoxSearch.Name = "guna2TextBoxSearch";
            this.guna2TextBoxSearch.PasswordChar = '\0';
            this.guna2TextBoxSearch.PlaceholderText = "";
            this.guna2TextBoxSearch.SelectedText = "";
            this.guna2TextBoxSearch.ShadowDecoration.Parent = this.guna2TextBoxSearch;
            this.guna2TextBoxSearch.Size = new System.Drawing.Size(272, 36);
            this.guna2TextBoxSearch.TabIndex = 88;
            this.guna2TextBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guna2TextBoxSearch_KeyDown);
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
            "No Nota",
            "Tanggal",
            "Id Course",
            "Nama Course",
            "Harga"});
            this.guna2ComboBoxSearch.ItemsAppearance.Parent = this.guna2ComboBoxSearch;
            this.guna2ComboBoxSearch.Location = new System.Drawing.Point(108, 94);
            this.guna2ComboBoxSearch.Name = "guna2ComboBoxSearch";
            this.guna2ComboBoxSearch.ShadowDecoration.Parent = this.guna2ComboBoxSearch;
            this.guna2ComboBoxSearch.Size = new System.Drawing.Size(175, 36);
            this.guna2ComboBoxSearch.TabIndex = 87;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.BackColor = System.Drawing.Color.Transparent;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(22, 100);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(86, 25);
            this.labelSearch.TabIndex = 86;
            this.labelSearch.Text = "Search :";
            // 
            // labelAddTransaction
            // 
            this.labelAddTransaction.AutoSize = true;
            this.labelAddTransaction.BackColor = System.Drawing.Color.Transparent;
            this.labelAddTransaction.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddTransaction.Location = new System.Drawing.Point(168, 28);
            this.labelAddTransaction.Name = "labelAddTransaction";
            this.labelAddTransaction.Size = new System.Drawing.Size(245, 40);
            this.labelAddTransaction.TabIndex = 85;
            this.labelAddTransaction.Text = "TRANSACTION";
            // 
            // dataGridViewSearch
            // 
            this.dataGridViewSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_nota,
            this.tanggal,
            this.course_id,
            this.course_nama,
            this.harga});
            this.dataGridViewSearch.Location = new System.Drawing.Point(27, 156);
            this.dataGridViewSearch.Name = "dataGridViewSearch";
            this.dataGridViewSearch.RowHeadersWidth = 51;
            this.dataGridViewSearch.RowTemplate.Height = 24;
            this.dataGridViewSearch.Size = new System.Drawing.Size(534, 310);
            this.dataGridViewSearch.TabIndex = 89;
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
            // course_id
            // 
            this.course_id.HeaderText = "Course Id";
            this.course_id.MinimumWidth = 6;
            this.course_id.Name = "course_id";
            this.course_id.Width = 125;
            // 
            // course_nama
            // 
            this.course_nama.HeaderText = "Nama";
            this.course_nama.MinimumWidth = 6;
            this.course_nama.Name = "course_nama";
            this.course_nama.Width = 125;
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga";
            this.harga.MinimumWidth = 6;
            this.harga.Name = "harga";
            this.harga.Width = 125;
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
            this.guna2ButtonPrint.Location = new System.Drawing.Point(210, 496);
            this.guna2ButtonPrint.Name = "guna2ButtonPrint";
            this.guna2ButtonPrint.ShadowDecoration.Parent = this.guna2ButtonPrint;
            this.guna2ButtonPrint.Size = new System.Drawing.Size(180, 45);
            this.guna2ButtonPrint.TabIndex = 102;
            this.guna2ButtonPrint.Text = "PRINT";
            this.guna2ButtonPrint.Click += new System.EventHandler(this.guna2ButtonPrint_Click);
            // 
            // FormTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Online_Course.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.guna2ButtonPrint);
            this.Controls.Add(this.dataGridViewSearch);
            this.Controls.Add(this.guna2TextBoxSearch);
            this.Controls.Add(this.guna2ComboBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelAddTransaction);
            this.Name = "FormTransaction";
            this.Text = "FormTransaction";
            this.Load += new System.EventHandler(this.FormTransaction_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxSearch;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelAddTransaction;
        private System.Windows.Forms.DataGridView dataGridViewSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonPrint;
    }
}