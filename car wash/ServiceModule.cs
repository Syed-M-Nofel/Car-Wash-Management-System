using Microsoft.Win32;
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
    public partial class ServiceModule : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        String title = "Car Wash Management System";
        Service service;


        public ServiceModule(Service ser)
        {
            InitializeComponent();
            service = ser;
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text == "" || txtprice.Text == "")
                {
                    MessageBox.Show("Required data field!", "Warning");
                    return;
                }


                if (MessageBox.Show("Are you sure you want to register this service?", "Service Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("Insert into tbService(name,price) Values(@name,@price)", dbcon.connect());
                    cm.Parameters.AddWithValue("@name", txtname.Text);
                    cm.Parameters.AddWithValue("@price", txtprice.Text);

                    dbcon.open();
                    cm.ExecuteNonQuery();

                    dbcon.close();
                    MessageBox.Show("Service has been successfully registered!", title);
                    clear();

                    service.loadService();
                    this.Dispose();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text == "" || txtprice.Text == "")
                {
                    MessageBox.Show("Required data field!", "Warning");
                    return;
                }


                if (MessageBox.Show("Are you sure you want to edit this service?", "Service Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbService SET name=@name, price=@price WHERE id=@id", dbcon.connect());
                    cm.Parameters.AddWithValue("@id", lblSid.Text);
                    cm.Parameters.AddWithValue("@name", txtname.Text);
                    cm.Parameters.AddWithValue("@price", txtprice.Text);

                    dbcon.open();
                    cm.ExecuteNonQuery();

                    dbcon.close();
                    MessageBox.Show("Service data has been successfully Edited!", title);
                    this.Dispose();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            clear();

        }
        #region method
        public void clear()
        {
            txtname.Clear();
            txtprice.Clear();
            btnsave.Enabled = true;
            btnupdate.Enabled = false;
        }
        #endregion method
    }
}
