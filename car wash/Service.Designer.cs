namespace car_wash
{
    partial class Service
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
            btnadd = new Button();
            txtsearchS = new TextBox();
            label1 = new Label();
            dgvservice = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvservice).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 205, 219);
            panel1.Controls.Add(btnadd);
            panel1.Controls.Add(txtsearchS);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 421);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 64);
            panel1.TabIndex = 2;
            // 
            // btnadd
            // 
            btnadd.FlatAppearance.BorderSize = 0;
            btnadd.FlatStyle = FlatStyle.Flat;
            btnadd.Image = Properties.Resources.car_service;
            btnadd.Location = new Point(894, 0);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(45, 45);
            btnadd.TabIndex = 2;
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // txtsearchS
            // 
            txtsearchS.Location = new Point(78, 16);
            txtsearchS.Name = "txtsearchS";
            txtsearchS.Size = new Size(175, 23);
            txtsearchS.TabIndex = 1;
            txtsearchS.TextChanged += txtsearchS_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Search";
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
            dgvservice.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Edit, Delete });
            dgvservice.Dock = DockStyle.Fill;
            dgvservice.EnableHeadersVisualStyles = false;
            dgvservice.Location = new Point(0, 0);
            dgvservice.Name = "dgvservice";
            dgvservice.RowHeadersVisible = false;
            dgvservice.RowTemplate.Height = 25;
            dgvservice.Size = new Size(967, 421);
            dgvservice.TabIndex = 3;
            dgvservice.CellContentClick += dgvservice_CellContentClick;
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
            Column2.Width = 47;
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
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = Properties.Resources.edit;
            Edit.Name = "Edit";
            Edit.Width = 5;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.delete;
            Delete.Name = "Delete";
            Delete.Width = 5;
            // 
            // Service
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(967, 485);
            Controls.Add(dgvservice);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Service";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvservice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnadd;
        private TextBox txtsearchS;
        private Label label1;
        private DataGridView dgvservice;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}