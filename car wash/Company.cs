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
    public partial class Company : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        String title = "Car Wash Management System";
        public Company()
        {
            InitializeComponent();
            loadCustomer();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            CustomerModule module = new CustomerModule(this);
            module.btnupdate.Enabled = false;
            module.ShowDialog();

        }

        private void dgvcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String colName = dgvcustomer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                CustomerModule module = new CustomerModule(this);
                module.lblcid.Text = dgvcustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txtname.Text = dgvcustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txtphone.Text = dgvcustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txtcarno.Text = dgvcustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
                module.txtcarmodel.Text = dgvcustomer.Rows[e.RowIndex].Cells[5].Value.ToString();
                module.vid = vehicleIdbyName(dgvcustomer.Rows[e.RowIndex].Cells[6].Value.ToString());
                module.txtaddress.Text = dgvcustomer.Rows[e.RowIndex].Cells[7].Value.ToString();
                module.udpoints.Text = dgvcustomer.Rows[e.RowIndex].Cells[8].Value.ToString();
                module.btnsave.Enabled = false;
                module.udpoints.Enabled = true;
                module.ShowDialog();
                loadCustomer();
                 
            }

            else if (colName == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete this record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("DELETE From tbCustomer WHERE id LIKE '" + dgvcustomer.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", dbcon.connect());
                        dbcon.open();
                        cm.ExecuteNonQuery();
                        dbcon.close();
                        MessageBox.Show("Customer data has been successfully removed!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                       



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title);
                }
            }
            loadCustomer();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            loadCustomer();
        }
        #region method

        public void loadCustomer()
        {
            try
            {
                int i = 0;
                dgvcustomer.Rows.Clear();
                cm = new SqlCommand("SELECT C.id,C.name, phone, carno,carmodel, V.name, address, points FROM tbCustomer AS C INNER JOIN tbVehicleType AS V ON C.vid=V.id WHERE CONCAT (C.name, carno, carmodel, address) LIKE '%" + txtsearch.Text + "%'", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvcustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(),dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());

                }
                dbcon.close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        public int vehicleIdbyName(string str)
        {
            int i = 0;
            cm = new SqlCommand("SELECT id FROM tbVehicleType WHERE name LIKE '" + str + "'", dbcon.connect());
            dbcon.open();
            dr = cm.ExecuteReader();
           
            dr.Read();
            if (dr.HasRows)
            {
                i = int.Parse(dr["id"].ToString());
                
            }
            dbcon.close();
            return i;
        }
            #endregion method
        }
}
