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
            this.dataGridViewSearch.Location = new System.Drawing.Point(24, 123);
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
            this.guna2ButtonPrint.Location = new System.Drawing.Point(210, 477);
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
            this.Controls.Add(this.labelAddTransaction);
            this.Name = "FormTransaction";
            this.Text = "FormTransaction";
            this.Load += new System.EventHandler(this.FormTransaction_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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