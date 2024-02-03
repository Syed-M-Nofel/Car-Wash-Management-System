namespace car_wash
{
    partial class ServiceModule
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
            lblSid = new Label();
            btncancel = new Button();
            btnupdate = new Button();
            btnsave = new Button();
            label9 = new Label();
            btnclose = new Button();
            txtname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            txtprice = new TextBox();
            SuspendLayout();
            // 
            // lblSid
            // 
            lblSid.AutoSize = true;
            lblSid.Location = new Point(38, 189);
            lblSid.Name = "lblSid";
            lblSid.Size = new Size(23, 15);
            lblSid.TabIndex = 44;
            lblSid.Text = "Sid";
            // 
            // btncancel
            // 
            btncancel.BackColor = Color.DarkTurquoise;
            btncancel.FlatAppearance.BorderSize = 0;
            btncancel.FlatStyle = FlatStyle.Flat;
            btncancel.Location = new Point(542, 182);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(137, 34);
            btncancel.TabIndex = 4;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.Goldenrod;
            btnupdate.FlatAppearance.BorderSize = 0;
            btnupdate.FlatStyle = FlatStyle.Flat;
            btnupdate.Location = new Point(360, 182);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(137, 34);
            btnupdate.TabIndex = 3;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.DodgerBlue;
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Location = new Point(176, 182);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(137, 34);
            btnsave.TabIndex = 2;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 131);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 40;
            label9.Text = "Price :";
            // 
            // btnclose
            // 
            btnclose.FlatAppearance.BorderSize = 0;
            btnclose.FlatStyle = FlatStyle.Flat;
            btnclose.Image = Properties.Resources.cancel;
            btnclose.Location = new Point(676, 33);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(20, 20);
            btnclose.TabIndex = 5;
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(176, 85);
            txtname.Name = "txtname";
            txtname.Size = new Size(520, 23);
            txtname.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 85);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 37;
            label2.Text = "Full Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(193, 0, 55);
            label1.Location = new Point(24, 34);
            label1.Name = "label1";
            label1.Size = new Size(136, 19);
            label1.TabIndex = 36;
            label1.Text = "Manage Service";
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
            // txtprice
            // 
            txtprice.Location = new Point(176, 128);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(520, 23);
            txtprice.TabIndex = 1;
            txtprice.KeyPress += txtSalary_KeyPress;
            // 
            // ServiceModule
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(708, 255);
            Controls.Add(txtprice);
            Controls.Add(lblSid);
            Controls.Add(btncancel);
            Controls.Add(btnupdate);
            Controls.Add(btnsave);
            Controls.Add(label9);
            Controls.Add(btnclose);
            Controls.Add(txtname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ServiceModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ServiceModule";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblSid;
        public Button btncancel;
        public Button btnupdate;
        public Button btnsave;
        private Label label9;
        private Button btnclose;
        public TextBox txtname;
        private Label label2;
        private Label label1;
        private Panel panel1;
        public TextBox txtprice;
    }
}