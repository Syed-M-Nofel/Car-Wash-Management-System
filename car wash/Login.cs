using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_wash
{
    public partial class Login : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        String title = "Car Wash Management System";
        public Login()
        {
            InitializeComponent();
            loadCompany();
        }
        public void loadCompany()
        {
            cm = new SqlCommand("SELECT * FROM tbCompany", dbcon.connect());
            dbcon.open();
            dr = cm.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                lblcompany.Text = dr["name"].ToString();
                lbladdress.Text = dr["address"].ToString();
                dr.Close();
                dbcon.close();
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtpassword.Clear();
            txtname.Focus();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = dbcon.connect())
                {
                    connection.Open();

                    string query = "SELECT name FROM tEmployer WHERE name = @username AND password = @password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", txtname.Text);
                        command.Parameters.AddWithValue("@password", txtpassword.Text); 

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                MessageBox.Show("WELCOME " + reader["name"].ToString() + "|", "Access Granted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                MainForm main = new MainForm();
                                main.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
            finally
            {
                dbcon.close();
                if (dr != null && !dr.IsClosed)
                {
                    dr.Close();
                }
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
                txtpassword.UseSystemPasswordChar = true;

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
