using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace car_wash
{
    public partial class EmployerModule : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        String title = "Car Wash Management System";
        bool check = false;
        //Employer emp = new Employer();
        Employer employer;
        public EmployerModule(Employer emp)
        {
            InitializeComponent();
            employer = emp;
            cbrole.SelectedIndex = 3;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure you want to edit this record?", "Employer Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("UPDATE tEmployer SET name=@name,phone=@phone,address=@address,dob=@dob,gender=@gender,role=@role,salary=@salary,password=@password WHERE id=@id", dbcon.connect());
                        cm.Parameters.AddWithValue("@id", lbleid.Text);
                        cm.Parameters.AddWithValue("@name", txtname.Text);
                        cm.Parameters.AddWithValue("@phone", txtphone.Text);
                        cm.Parameters.AddWithValue("@address", txtaddress.Text);
                        cm.Parameters.AddWithValue("@dob", dtdob.Value);
                        cm.Parameters.AddWithValue("@gender", rdmale.Checked ? "Male" : "Female");
                        cm.Parameters.AddWithValue("@role", cbrole.Text);
                        cm.Parameters.AddWithValue("@salary", txtsalary.Text);
                        cm.Parameters.AddWithValue("@password", txtpassword.Text);

                        dbcon.open();
                        cm.ExecuteNonQuery();

                        dbcon.close();
                        MessageBox.Show("Record has been successfully updated!", title);
                        Clear();

                        this.Dispose();
                        employer.loadEmployer();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void lbleid_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbrole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbrole.Text == "Supervisor" || cbrole.Text == "Worker")
            {
                this.Height = 500 - 26;
                txtpassword.Clear();
                lblpass.Visible = false;
                txtpassword.Visible = false;
            }
            else
            {
                lblpass.Visible = true;
                txtpassword.Visible = true;
                this.Height = 453;
            }
        }

        private void txtsalary_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void rdmale_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdfemale_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Clear();
            btnupdate.Enabled = false;
            btnsave.Enabled = true;
        }
        // to create a function for clear all


        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void btnsave_Click(object sender, EventArgs e)
        {


            try
            {

                checkField();
                if (check)
                {
                    if (MessageBox.Show("Are you sure you want to register this employer?", "Employer Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("Insert into tEmployer(name,phone,address,dob,gender,role,salary,password) Values(@name,@phone,@address,@dob,@gender,@role,@salary,@password)", dbcon.connect());
                        cm.Parameters.AddWithValue("@name", txtname.Text);
                        cm.Parameters.AddWithValue("@phone", txtphone.Text);
                        cm.Parameters.AddWithValue("@address", txtaddress.Text);
                        cm.Parameters.AddWithValue("@dob", dtdob.Value);
                        cm.Parameters.AddWithValue("@gender", rdmale.Checked ? "Male" : "Female");
                        cm.Parameters.AddWithValue("@role", cbrole.Text);
                        cm.Parameters.AddWithValue("@salary", txtsalary.Text);
                        cm.Parameters.AddWithValue("@password", txtpassword.Text);

                        dbcon.open();
                        cm.ExecuteNonQuery();

                        dbcon.close();
                        MessageBox.Show("Employer has been successfully registered!", title);
                        check = false;
                        Clear();
                        
                        employer.loadEmployer();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }



        #region method
        public void Clear()
        {
            txtaddress.Clear();
            txtname.Clear();
            txtpassword.Clear();
            txtphone.Clear();
            txtsalary.Clear();
            dtdob.Value = DateTime.Now;
            cbrole.SelectedIndex = 3;

        }
        public void checkField()
        {
            if (txtaddress.Text == "" || txtname.Text == "" || txtphone.Text == "" || txtsalary.Text == "")
            {
                MessageBox.Show("Required data field!", "Warning");
                return;
            }
            if (checkAge(dtdob.Value) < 18)
            {
                MessageBox.Show("Employer is under age!", "Warning");
                return;
            }
            check = true;
        }

        public static int checkAge(DateTime dateofBirth)
        {
            int age = DateTime.Now.Year - dateofBirth.Year;
            if (DateTime.Now.DayOfYear < dateofBirth.DayOfYear)
                age = age - 1;
            return age;
        }

        #endregion method

        private void txtsalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void EmployerModule_Load(object sender, EventArgs e)
        {

        }
    }
}
