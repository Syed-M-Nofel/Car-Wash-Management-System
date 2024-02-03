namespace car_wash
{
    partial class Login
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
            lbladdress = new Label();
            pictureBox2 = new PictureBox();
            lblcompany = new Label();
            btncancel = new Button();
            btnlogin = new Button();
            checkBox1 = new CheckBox();
            txtpassword = new TextBox();
            txtname = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lbladdress);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblcompany);
            panel1.Controls.Add(btncancel);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(txtname);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(112, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 440);
            panel1.TabIndex = 0;
            // 
            // lbladdress
            // 
            lbladdress.BackColor = Color.White;
            lbladdress.ForeColor = Color.FromArgb(15, 205, 219);
            lbladdress.Location = new Point(440, 408);
            lbladdress.Name = "lbladdress";
            lbladdress.Size = new Size(347, 23);
            lbladdress.TabIndex = 11;
            lbladdress.Text = "Address";
            lbladdress.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.clean1;
            pictureBox2.Location = new Point(796, 357);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // lblcompany
            // 
            lblcompany.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblcompany.ForeColor = Color.FromArgb(15, 205, 219);
            lblcompany.Location = new Point(440, 357);
            lblcompany.Name = "lblcompany";
            lblcompany.Size = new Size(353, 47);
            lblcompany.TabIndex = 9;
            lblcompany.Text = "Air";
            lblcompany.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btncancel
            // 
            btncancel.FlatAppearance.BorderSize = 0;
            btncancel.FlatStyle = FlatStyle.Flat;
            btncancel.Location = new Point(718, 269);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(75, 36);
            btncancel.TabIndex = 4;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = true;
            btncancel.Click += btncancel_Click;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(15, 205, 219);
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Location = new Point(609, 269);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(75, 36);
            btnlogin.TabIndex = 3;
            btnlogin.Text = "Log in";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = SystemColors.ActiveCaption;
            checkBox1.Location = new Point(609, 229);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(609, 200);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(234, 23);
            txtpassword.TabIndex = 1;
            txtpassword.UseSystemPasswordChar = true;
            // 
            // txtname
            // 
            txtname.Location = new Point(609, 162);
            txtname.Name = "txtname";
            txtname.Size = new Size(234, 23);
            txtname.TabIndex = 0;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(512, 203);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 163);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Username :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(527, 39);
            label1.Name = "label1";
            label1.Size = new Size(253, 79);
            label1.TabIndex = 1;
            label1.Text = "LOG IN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.luxurious_car_parked_highway_with_illuminated_headlight_sunset;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(434, 440);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1056, 621);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtpassword;
        private TextBox txtname;
        private Label label3;
        private Label label2;
        private Button btnlogin;
        private CheckBox checkBox1;
        private Button btncancel;
        private PictureBox pictureBox2;
        private Label lblcompany;
        private Label lbladdress;
    }
}