namespace car_wash
{
    partial class ManageCostGoodSold
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
            lblCid = new Label();
            btncancel = new Button();
            btnupdate = new Button();
            btnsave = new Button();
            label9 = new Label();
            btnclose = new Button();
            txtcostname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            txtcost = new TextBox();
            dtcost = new DateTimePicker();
            SuspendLayout();
            // 
            // lblCid
            // 
            lblCid.AutoSize = true;
            lblCid.Location = new Point(26, 241);
            lblCid.Name = "lblCid";
            lblCid.Size = new Size(25, 15);
            lblCid.TabIndex = 44;
            lblCid.Text = "Cid";
            // 
            // btncancel
            // 
            btncancel.BackColor = Color.DarkTurquoise;
            btncancel.FlatAppearance.BorderSize = 0;
            btncancel.FlatStyle = FlatStyle.Flat;
            btncancel.Location = new Point(530, 234);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(137, 34);
            btncancel.TabIndex = 5;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.Goldenrod;
            btnupdate.FlatAppearance.BorderSize = 0;
            btnupdate.FlatStyle = FlatStyle.Flat;
            btnupdate.Location = new Point(348, 234);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(137, 34);
            btnupdate.TabIndex = 4;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.DodgerBlue;
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Location = new Point(164, 234);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(137, 34);
            btnsave.TabIndex = 3;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 152);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 40;
            label9.Text = "Cost :";
            // 
            // btnclose
            // 
            btnclose.FlatAppearance.BorderSize = 0;
            btnclose.FlatStyle = FlatStyle.Flat;
            btnclose.Image = Properties.Resources.cancel;
            btnclose.Location = new Point(664, 54);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(20, 20);
            btnclose.TabIndex = 6;
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // txtcostname
            // 
            txtcostname.Location = new Point(164, 106);
            txtcostname.Name = "txtcostname";
            txtcostname.Size = new Size(520, 23);
            txtcostname.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 106);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 37;
            label2.Text = "Cost Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(193, 0, 55);
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(218, 19);
            label1.TabIndex = 36;
            label1.Text = "Manage Cost Of Good Sold";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(193, 0, 55);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 27);
            panel1.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 203);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 46;
            label3.Text = "Date :";
            // 
            // txtcost
            // 
            txtcost.Location = new Point(164, 152);
            txtcost.Name = "txtcost";
            txtcost.Size = new Size(520, 23);
            txtcost.TabIndex = 1;
            // 
            // dtcost
            // 
            dtcost.Location = new Point(164, 193);
            dtcost.Name = "dtcost";
            dtcost.Size = new Size(520, 23);
            dtcost.TabIndex = 2;
            // 
            // ManageCostGoodSold
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 280);
            Controls.Add(dtcost);
            Controls.Add(txtcost);
            Controls.Add(label3);
            Controls.Add(lblCid);
            Controls.Add(btncancel);
            Controls.Add(btnupdate);
            Controls.Add(btnsave);
            Controls.Add(label9);
            Controls.Add(btnclose);
            Controls.Add(txtcostname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCostGoodSold";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCostGoodSold";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public ComboBox cbclass;
        public Label lblCid;
        public Button btncancel;
        public Button btnupdate;
        public Button btnsave;
        private Label label9;
        private Button btnclose;
        public TextBox txtcostname;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label3;
        public TextBox txtcost;
        public DateTimePicker dtcost;
    }
}