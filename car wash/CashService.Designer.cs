namespace car_wash
{
    partial class CashService
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtSearch = new TextBox();
            button1 = new Button();
            btnsubmit = new Button();
            dgvservice = new DataGridView();
            select = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewCheckBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvservice).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnsubmit);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 33);
            panel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(128, 0);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(740, 33);
            txtSearch.TabIndex = 10;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.AppWorkspace;
            button1.Image = Properties.Resources.search_interface_symbol;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(128, 33);
            button1.TabIndex = 9;
            button1.Text = "Search Here";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnsubmit
            // 
            btnsubmit.Dock = DockStyle.Right;
            btnsubmit.FlatAppearance.BorderSize = 0;
            btnsubmit.FlatStyle = FlatStyle.Flat;
            btnsubmit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnsubmit.Image = Properties.Resources.login;
            btnsubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnsubmit.Location = new Point(868, 0);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(99, 33);
            btnsubmit.TabIndex = 6;
            btnsubmit.Text = "Submit";
            btnsubmit.TextAlign = ContentAlignment.MiddleRight;
            btnsubmit.UseVisualStyleBackColor = true;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // dgvservice
            // 
            dgvservice.AllowUserToAddRows = false;
            dgvservice.AllowUserToDeleteRows = false;
            dgvservice.AllowUserToResizeColumns = false;
            dgvservice.BackgroundColor = Color.White;
            dgvservice.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 205, 219);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvservice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvservice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvservice.Columns.AddRange(new DataGridViewColumn[] { select, Column2, Column3, Column4, Column5 });
            dgvservice.Dock = DockStyle.Fill;
            dgvservice.EnableHeadersVisualStyles = false;
            dgvservice.Location = new Point(0, 0);
            dgvservice.Name = "dgvservice";
            dgvservice.RowHeadersVisible = false;
            dgvservice.RowTemplate.Height = 25;
            dgvservice.Size = new Size(967, 128);
            dgvservice.TabIndex = 4;
            dgvservice.CellContentClick += dgvservice_CellContentClick;
            // 
            // select
            // 
            select.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            select.HeaderText = "No";
            select.Name = "select";
            select.Width = 53;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Id";
            Column2.Name = "Column2";
            Column2.Visible = false;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Name";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Price";
            Column4.Name = "Column4";
            Column4.Width = 69;
            // 
            // Column5
            // 
            Column5.HeaderText = "Select";
            Column5.Name = "Column5";
            // 
            // CashService
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(967, 161);
            Controls.Add(dgvservice);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashService";
            Text = "CashService";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvservice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvservice;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private Button btnsubmit;
        private TextBox txtSearch;
        private Button button1;
        private DataGridViewTextBoxColumn select;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewCheckBoxColumn Column5;
    }
}