namespace car_wash
{
    partial class Company
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            btnadd = new Button();
            txtsearch = new TextBox();
            label1 = new Label();
            dgvcustomer = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcustomer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 205, 219);
            panel1.Controls.Add(btnadd);
            panel1.Controls.Add(txtsearch);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 355);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 64);
            panel1.TabIndex = 2;
            // 
            // btnadd
            // 
            btnadd.FlatAppearance.BorderSize = 0;
            btnadd.FlatStyle = FlatStyle.Flat;
            btnadd.Image = Properties.Resources.add_user__1_;
            btnadd.Location = new Point(894, 7);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(45, 45);
            btnadd.TabIndex = 2;
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(78, 16);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(175, 23);
            txtsearch.TabIndex = 1;
            txtsearch.TextChanged += txtsearch_TextChanged;
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
            // dgvcustomer
            // 
            dgvcustomer.AllowUserToAddRows = false;
            dgvcustomer.AllowUserToDeleteRows = false;
            dgvcustomer.AllowUserToResizeColumns = false;
            dgvcustomer.BackgroundColor = Color.White;
            dgvcustomer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(15, 205, 219);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvcustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvcustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcustomer.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column10, Column6, Column7, Column8, Edit, Delete });
            dgvcustomer.Dock = DockStyle.Fill;
            dgvcustomer.EnableHeadersVisualStyles = false;
            dgvcustomer.Location = new Point(0, 0);
            dgvcustomer.Name = "dgvcustomer";
            dgvcustomer.RowHeadersVisible = false;
            dgvcustomer.RowTemplate.Height = 25;
            dgvcustomer.Size = new Size(951, 355);
            dgvcustomer.TabIndex = 3;
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
            Column2.Width = 47;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Car Type";
            Column6.Name = "Column6";
            Column6.Width = 88;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column8.DefaultCellStyle = dataGridViewCellStyle4;
            Column8.HeaderText = "Points";
            Column8.Name = "Column8";
            Column8.Width = 74;
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
            // Company
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(951, 419);
            Controls.Add(dgvcustomer);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Company";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Company";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnadd;
        private TextBox txtsearch;
        private Label label1;
        private DataGridView dgvcustomer;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}