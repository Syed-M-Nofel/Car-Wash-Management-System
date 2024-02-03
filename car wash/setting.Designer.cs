namespace car_wash
{
    partial class setting
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvvehicletype = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel2 = new Panel();
            btnaddVT = new Button();
            txtsearchVT = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            dgvcostofgoodsold = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Editcog = new DataGridViewImageColumn();
            Deletecog = new DataGridViewImageColumn();
            panel3 = new Panel();
            btncostofgood = new Button();
            txtsearchcog = new TextBox();
            label2 = new Label();
            tabPage3 = new TabPage();
            btncancel = new Button();
            btnsave = new Button();
            txtaddress = new TextBox();
            label4 = new Label();
            txtcompanyname = new TextBox();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvvehicletype).BeginInit();
            panel2.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcostofgoodsold).BeginInit();
            panel3.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(193, 0, 55);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 27);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(951, 419);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvvehicletype);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(943, 391);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Vehicle Type";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // dgvvehicletype
            // 
            dgvvehicletype.AllowUserToAddRows = false;
            dgvvehicletype.AllowUserToDeleteRows = false;
            dgvvehicletype.AllowUserToResizeColumns = false;
            dgvvehicletype.BackgroundColor = Color.White;
            dgvvehicletype.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 205, 219);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvvehicletype.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvvehicletype.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvvehicletype.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Edit, Delete });
            dgvvehicletype.Dock = DockStyle.Fill;
            dgvvehicletype.EnableHeadersVisualStyles = false;
            dgvvehicletype.Location = new Point(3, 3);
            dgvvehicletype.Name = "dgvvehicletype";
            dgvvehicletype.RowHeadersVisible = false;
            dgvvehicletype.RowTemplate.Height = 25;
            dgvvehicletype.Size = new Size(937, 333);
            dgvvehicletype.TabIndex = 7;
            dgvvehicletype.CellContentClick += dgvvehicletype_CellContentClick;
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
            Column4.HeaderText = "Level";
            Column4.Name = "Column4";
            Column4.Width = 72;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 205, 219);
            panel2.Controls.Add(btnaddVT);
            panel2.Controls.Add(txtsearchVT);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 336);
            panel2.Name = "panel2";
            panel2.Size = new Size(937, 52);
            panel2.TabIndex = 6;
            // 
            // btnaddVT
            // 
            btnaddVT.FlatAppearance.BorderSize = 0;
            btnaddVT.FlatStyle = FlatStyle.Flat;
            btnaddVT.Image = Properties.Resources.car__1_;
            btnaddVT.Location = new Point(754, 0);
            btnaddVT.Name = "btnaddVT";
            btnaddVT.Size = new Size(49, 45);
            btnaddVT.TabIndex = 2;
            btnaddVT.TextAlign = ContentAlignment.TopCenter;
            btnaddVT.TextImageRelation = TextImageRelation.ImageAboveText;
            btnaddVT.UseVisualStyleBackColor = true;
            btnaddVT.Click += btnaddVT_Click;
            // 
            // txtsearchVT
            // 
            txtsearchVT.Location = new Point(78, 16);
            txtsearchVT.Name = "txtsearchVT";
            txtsearchVT.Size = new Size(175, 23);
            txtsearchVT.TabIndex = 1;
            txtsearchVT.TextChanged += txtsearchVT_TextChanged;
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
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvcostofgoodsold);
            tabPage2.Controls.Add(panel3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(943, 391);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cost of Good Sold";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvcostofgoodsold
            // 
            dgvcostofgoodsold.AllowUserToAddRows = false;
            dgvcostofgoodsold.AllowUserToDeleteRows = false;
            dgvcostofgoodsold.AllowUserToResizeColumns = false;
            dgvcostofgoodsold.BackgroundColor = Color.White;
            dgvcostofgoodsold.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 205, 219);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvcostofgoodsold.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvcostofgoodsold.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcostofgoodsold.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, Column5, Editcog, Deletecog });
            dgvcostofgoodsold.Dock = DockStyle.Fill;
            dgvcostofgoodsold.EnableHeadersVisualStyles = false;
            dgvcostofgoodsold.Location = new Point(3, 3);
            dgvcostofgoodsold.Name = "dgvcostofgoodsold";
            dgvcostofgoodsold.RowHeadersVisible = false;
            dgvcostofgoodsold.RowTemplate.Height = 25;
            dgvcostofgoodsold.Size = new Size(937, 321);
            dgvcostofgoodsold.TabIndex = 8;
            dgvcostofgoodsold.CellContentClick += dgvcostofgoodsold_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.HeaderText = "No";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 53;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "Id";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 47;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Name";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn4.HeaderText = "Cost";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 65;
            // 
            // Column5
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Column5.DefaultCellStyle = dataGridViewCellStyle3;
            Column5.HeaderText = "Date";
            Column5.Name = "Column5";
            // 
            // Editcog
            // 
            Editcog.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Editcog.HeaderText = "";
            Editcog.Image = Properties.Resources.edit;
            Editcog.Name = "Editcog";
            Editcog.Width = 5;
            // 
            // Deletecog
            // 
            Deletecog.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Deletecog.HeaderText = "";
            Deletecog.Image = Properties.Resources.delete;
            Deletecog.Name = "Deletecog";
            Deletecog.Width = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(15, 205, 219);
            panel3.Controls.Add(btncostofgood);
            panel3.Controls.Add(txtsearchcog);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 324);
            panel3.Name = "panel3";
            panel3.Size = new Size(937, 64);
            panel3.TabIndex = 7;
            // 
            // btncostofgood
            // 
            btncostofgood.FlatAppearance.BorderSize = 0;
            btncostofgood.FlatStyle = FlatStyle.Flat;
            btncostofgood.Image = Properties.Resources.Cost_of_good;
            btncostofgood.Location = new Point(698, 3);
            btncostofgood.Name = "btncostofgood";
            btncostofgood.Size = new Size(49, 45);
            btncostofgood.TabIndex = 2;
            btncostofgood.TextAlign = ContentAlignment.TopCenter;
            btncostofgood.TextImageRelation = TextImageRelation.ImageAboveText;
            btncostofgood.UseVisualStyleBackColor = true;
            btncostofgood.Click += btncostofgood_Click;
            // 
            // txtsearchcog
            // 
            txtsearchcog.Location = new Point(78, 16);
            txtsearchcog.Name = "txtsearchcog";
            txtsearchcog.Size = new Size(175, 23);
            txtsearchcog.TabIndex = 1;
            txtsearchcog.TextChanged += txtsearchcog_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "Search";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btncancel);
            tabPage3.Controls.Add(btnsave);
            tabPage3.Controls.Add(txtaddress);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(txtcompanyname);
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(943, 391);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Company Name";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            btncancel.BackColor = Color.DarkTurquoise;
            btncancel.FlatAppearance.BorderSize = 0;
            btncancel.FlatStyle = FlatStyle.Flat;
            btncancel.Location = new Point(521, 227);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(129, 34);
            btncancel.TabIndex = 36;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.DodgerBlue;
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Location = new Point(314, 227);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(129, 34);
            btnsave.TabIndex = 35;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(177, 164);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(518, 23);
            txtaddress.TabIndex = 3;
            txtaddress.TextChanged += txtaddress_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 172);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 2;
            label4.Text = "Address :";
            // 
            // txtcompanyname
            // 
            txtcompanyname.Location = new Point(177, 110);
            txtcompanyname.Name = "txtcompanyname";
            txtcompanyname.Size = new Size(518, 23);
            txtcompanyname.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 113);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 0;
            label3.Text = "Company Name : ";
            // 
            // setting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 446);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "setting";
            Text = "setting";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvvehicletype).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvcostofgoodsold).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Panel panel2;
        private TextBox txtsearchVT;
        private Label label1;
        private DataGridView dgvvehicletype;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private Button btnaddVT;
        private Panel panel3;
        private Button btncostofgood;
        private TextBox txtsearchcog;
        private Label label2;
        private DataGridView dgvcostofgoodsold;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewImageColumn Editcog;
        private DataGridViewImageColumn Deletecog;
        private TextBox txtaddress;
        private Label label4;
        private TextBox txtcompanyname;
        private Label label3;
        public Button btncancel;
        public Button btnsave;
    }
}