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
    public partial class ManageVehicleType : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        String title = "Car Wash Management System";
        setting setting;

        public ManageVehicleType(setting sett)
        {
            InitializeComponent();
            setting = sett;
            cbclass.SelectedIndex = 0;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text == "")
                {
                    MessageBox.Show("Required Vehicle type name!", "Warning");
                    return;
                }


                if (MessageBox.Show("Are you sure you want to register this vehicle type?", "Vehicle Type Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("Insert into tbVehicleType(name,class) Values(@name,@class)", dbcon.connect());
                    cm.Parameters.AddWithValue("@name", txtname.Text);
                    cm.Parameters.AddWithValue("@class", cbclass.Text);

                    dbcon.open();
                    cm.ExecuteNonQuery();

                    dbcon.close();
                    MessageBox.Show("Vehicle type has been successfully registered!", title);
                    clear();
                    setting.loadVehicleType();


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

                if (txtname.Text == "")
                {
                    MessageBox.Show("Required Vehicle type name!", "Warning");
                    return;
                }

                if (MessageBox.Show("Are you sure you want to edit this vehicle type?", "Vehicle Type Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE tbVehicleType SET name=@name, class=@class WHERE id=@id", dbcon.connect());
                    cm.Parameters.AddWithValue("@id", lblVid.Text);
                    cm.Parameters.AddWithValue("@name", txtname.Text);
                    cm.Parameters.AddWithValue("@class", cbclass.Text);

                    dbcon.open();
                    cm.ExecuteNonQuery();

                    dbcon.close();
                    MessageBox.Show("Vehicle type has been successfully Edited!", title);
                    clear();
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
            cbclass.SelectedIndex = 0;
            btnsave.Enabled = true;
            btnupdate.Enabled = false;
        }
        #endregion method

        private void txtcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
