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
    public partial class Service : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        String title = "Car Wash Management System";
        public Service()
        {
            InitializeComponent();
            loadService();
        }

        public void loadService()
        {
            try
            {
                int i = 0;
                dgvservice.Rows.Clear();
                cm = new SqlCommand("SELECT * FROM tbService WHERE name LIKE '%" + txtsearchS.Text + "%'", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvservice.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());

                }
                dbcon.close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ServiceModule module = new ServiceModule(this);
            module.btnupdate.Enabled = false;
            module.ShowDialog();
        }

        private void txtsearchS_TextChanged(object sender, EventArgs e)
        {
            loadService();
        }

        private void dgvservice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String colName = dgvservice.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ServiceModule module= new ServiceModule(this);
                module.lblSid.Text = dgvservice.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txtname.Text = dgvservice.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txtprice.Text = dgvservice.Rows[e.RowIndex].Cells[3].Value.ToString();

                module.btnsave.Enabled = false;
                module.ShowDialog();

            }

            else if (colName == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete this record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("DELETE From tbService WHERE id LIKE '" + dgvservice.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", dbcon.connect());
                        dbcon.open();
                        cm.ExecuteNonQuery();
                        dbcon.close();
                        MessageBox.Show("Service data has been successfully removed!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title);
                }
            }
            loadService();
        }
    }
}
