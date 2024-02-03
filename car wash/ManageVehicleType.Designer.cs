namespace car_wash
{
    partial class ManageVehicleType
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
            panel1 = new Panel();
            btnclose = new Button();
            txtname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblVid = new Label();
            btncancel = new Button();
            btnupdate = new Button();
            btnsave = new Button();
            label9 = new Label();
            cbclass = new ComboBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(193, 0, 55);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 27);
            panel1.TabIndex = 1;
            // 
            // btnclose
            // 
            btnclose.FlatAppearance.BorderSize = 0;
            btnclose.FlatStyle = FlatStyle.Flat;
            btnclose.Image = Properties.Resources.cancel;
            btnclose.Location = new Point(664, 44);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(20, 20);
            btnclose.TabIndex = 27;
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // txtname
            // 
            txtname.Location = new Point(164, 96);
            txtname.Name = "txtname";
            txtname.Size = new Size(520, 23);
            txtname.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 96);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 25;
            label2.Text = "Full Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(193, 0, 55);
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(180, 19);
            label1.TabIndex = 24;
            label1.Text = "Manage Vehicle Type";
            // 
            // lblVid
            // 
            lblVid.AutoSize = true;
            lblVid.Location = new Point(26, 200);
            lblVid.Name = "lblVid";
            lblVid.Size = new Size(24, 15);
            lblVid.TabIndex = 33;
            lblVid.Text = "Vid";
            // 
            // btncancel
            // 
            btncancel.BackColor = Color.DarkTurquoise;
            btncancel.FlatAppearance.BorderSize = 0;
            btncancel.FlatStyle = FlatStyle.Flat;
            btncancel.Location = new Point(530, 193);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(137, 34);
            btncancel.TabIndex = 32;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.Goldenrod;
            btnupdate.FlatAppearance.BorderSize = 0;
            btnupdate.FlatStyle = FlatStyle.Flat;
            btnupdate.Location = new Point(348, 193);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(137, 34);
            btnupdate.TabIndex = 31;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.DodgerBlue;
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Location = new Point(164, 193);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(137, 34);
            btnsave.TabIndex = 30;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 142);
            label9.Name = "label9";
            label9.Size = new Size(40, 15);
            label9.TabIndex = 28;
            label9.Text = "Class :";
            // 
            // cbclass
            // 
            cbclass.FormattingEnabled = true;
            cbclass.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cbclass.Location = new Point(164, 141);
            cbclass.Name = "cbclass";
            cbclass.Size = new Size(520, 23);
            cbclass.TabIndex = 34;
            cbclass.KeyPress += txtcost_KeyPress;
            // 
            // ManageVehicleType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 280);
            Controls.Add(cbclass);
            Controls.Add(lblVid);
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
            Name = "ManageVehicleType";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageVehicleType";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnclose;
        public TextBox txtname;
        private Label label2;
        private Label label1;
        public Label lblVid;
        public Button btncancel;
        public Button btnupdate;
        public Button btnsave;
        private Label label9;
        public ComboBox cbclass;
    }
}