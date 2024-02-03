namespace car_wash
{
    partial class CashCustomer
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgvcustomer = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            select = new DataGridViewImageColumn();
            panel1 = new Panel();
            txtSearch = new TextBox();
            btncash = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvcustomer).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvcustomer
            // 
            dgvcustomer.AllowUserToAddRows = false;
            dgvcustomer.AllowUserToDeleteRows = false;
            dgvcustomer.AllowUserToResizeColumns = false;
            dgvcustomer.BackgroundColor = Color.White;
            dgvcustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(15, 205, 219);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvcustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvcustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcustomer.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column9, Column3, Column4, Column5, Column10, Column7, Column8, select });
            dgvcustomer.Dock = DockStyle.Fill;
            dgvcustomer.EnableHeadersVisualStyles = false;
            dgvcustomer.Location = new Point(0, 0);
            dgvcustomer.Name = "dgvcustomer";
            dgvcustomer.RowHeadersVisible = false;
            dgvcustomer.RowTemplate.Height = 25;
            dgvcustomer.Size = new Size(967, 161);
            dgvcustomer.TabIndex = 4;
            dgvcustomer.CellContentClick += dgvcustomer_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.Name = "Column1";
            Column1.Width = 53;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Id";
            Column2.Name = "Column2";
            Column2.Visible = false;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.HeaderText = "Vid";
            Column9.Name = "Column9";
            Column9.Visible = false;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column3.DefaultCellStyle = dataGridViewCellStyle5;
            Column3.HeaderText = "Name";
            Column3.Name = "Column3";
            Column3.Width = 76;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Phone";
            Column4.Name = "Column4";
            Column4.Width = 79;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Car No";
            Column5.Name = "Column5";
            Column5.Width = 59;
            // 
            // Column10
            // 
            Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column10.HeaderText = "Car Model";
            Column10.Name = "Column10";
            Column10.Width = 102;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column7.HeaderText = "Address";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column8.DefaultCellStyle = dataGridViewCellStyle6;
            Column8.HeaderText = "Points";
            Column8.Name = "Column8";
            Column8.Width = 74;
            // 
            // select
            // 
            select.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            select.HeaderText = "";
            select.Image = Properties.Resources.check_mark;
            select.Name = "select";
            select.Width = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(btncash);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 31);
            panel1.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(128, 0);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(839, 31);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btncash
            // 
            btncash.Dock = DockStyle.Left;
            btncash.FlatAppearance.BorderSize = 0;
            btncash.FlatStyle = FlatStyle.Flat;
            btncash.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btncash.ForeColor = SystemColors.AppWorkspace;
            btncash.Image = Properties.Resources.search_interface_symbol;
            btncash.ImageAlign = ContentAlignment.MiddleLeft;
            btncash.Location = new Point(0, 0);
            btncash.Name = "btncash";
            btncash.Size = new Size(128, 31);
            btncash.TabIndex = 7;
            btncash.Text = "Search Here";
            btncash.TextAlign = ContentAlignment.MiddleRight;
            btncash.UseVisualStyleBackColor = true;
            btncash.Click += btncash_Click;
            // 
            // CashCustomer
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(967, 161);
            Controls.Add(panel1);
            Controls.Add(dgvcustomer);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashCustomer";
            ((System.ComponentModel.ISupportInitialize)dgvcustomer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvcustomer;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewImageColumn select;
        private Panel panel1;
        private TextBox txtSearch;
        private Button btncash;
    }
}