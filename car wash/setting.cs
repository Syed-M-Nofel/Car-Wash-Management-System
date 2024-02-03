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
    public partial class setting : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        String title = "Car Wash Management System";
        bool hasdetail = false;
        public setting()
        {
            InitializeComponent();
            loadVehicleType();
            loadCostofGood();
            loadCompany();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtsearchVT_TextChanged(object sender, EventArgs e)
        {
            loadVehicleType();
        }
        private void btnaddVT_Click(object sender, EventArgs e)
        {
            ManageVehicleType module = new ManageVehicleType(this);
            module.btnupdate.Enabled = false;
            module.ShowDialog();
        }

        private void dgvvehicletype_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String colName = dgvvehicletype.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ManageVehicleType module = new ManageVehicleType(this);
                module.lblVid.Text = dgvvehicletype.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txtname.Text = dgvvehicletype.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.cbclass.Text = dgvvehicletype.Rows[e.RowIndex].Cells[3].Value.ToString();

                module.btnsave.Enabled = false;
                module.ShowDialog();

            }

            else if (colName == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete this record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("DELETE From tbVehicleType WHERE id LIKE '" + dgvvehicletype.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", dbcon.connect());
                        dbcon.open();
                        cm.ExecuteNonQuery();
                        dbcon.close();
                        MessageBox.Show("Vehicle Type  data has been successfully removed!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title);
                }
            }
            loadVehicleType();
        }

        #region VehicleType
        public void loadVehicleType()
        {
            try
            {
                int i = 0;
                dgvvehicletype.Rows.Clear();
                cm = new SqlCommand("SELECT * FROM tbVehicleType WHERE CONCAT (name, class) LIKE '%" + txtsearchVT.Text + "%'", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvvehicletype.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());

                }
                dbcon.close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        #endregion VehicleType


        #region CostOfGoodSold

        private void dgvcostofgoodsold_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String colName = dgvcostofgoodsold.Columns[e.ColumnIndex].Name;
            if (colName == "Editcog")
            {
                ManageCostGoodSold module = new ManageCostGoodSold(this);
                module.lblCid.Text = dgvcostofgoodsold.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txtcostname.Text = dgvcostofgoodsold.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txtcost.Text = dgvcostofgoodsold.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.dtcost.Text = dgvcostofgoodsold.Rows[e.RowIndex].Cells[4].Value.ToString();
                module.btnsave.Enabled = false;
                module.ShowDialog();

            }

            else if (colName == "Deletecog")
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete this record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("DELETE From tbCostofGoodSold WHERE id LIKE '" + dgvcostofgoodsold.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", dbcon.connect());
                        dbcon.open();
                        cm.ExecuteNonQuery();
                        dbcon.close();
                        MessageBox.Show("Cost of good sold data has been successfully removed!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title);
                }
            }
            loadCostofGood();
        }

        private void btncostofgood_Click(object sender, EventArgs e)
        {
            ManageCostGoodSold module = new ManageCostGoodSold(this);
            module.btnupdate.Enabled = false;
            module.ShowDialog();
        }

        private void txtsearchcog_TextChanged(object sender, EventArgs e)
        {
            loadCostofGood();
        }
        public void loadCostofGood()
        {
            try
            {
                int i = 0;
                dgvcostofgoodsold.Rows.Clear();
                cm = new SqlCommand("SELECT * FROM tbCostofGoodSold WHERE CONCAT (costname, date) LIKE '%" + txtsearchcog.Text + "%'", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvcostofgoodsold.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), DateTime.Parse(dr[3].ToString()).ToShortDateString());

                }
                dbcon.close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        #endregion CostOfGoodSold

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        #region Company Detail
        public void loadCompany()
        {
            try
            {
                dbcon.open();
                cm = new SqlCommand("SELECT * FROM tbCompany", dbcon.connect());
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    hasdetail = true;
                    txtcompanyname.Text = dr["name"].ToString();
                    txtaddress.Text = dr["address"].ToString();
                }
                else
                {
                    txtcompanyname.Clear();
                    txtaddress.Clear();
                }
                dr.Close();
                dbcon.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Save Company Detail?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (hasdetail)
                    {
                        dbcon.executeQuery("UPDATE tbCompany SET name='" + txtcompanyname.Text + "' ,address'" + txtaddress + "'");

                    }
                    else
                    {
                        dbcon.executeQuery("INSERT INTO tbCompany (name,address) Values('" + txtcompanyname.Text + "','" + txtaddress.Text + "')");

                    }
                    MessageBox.Show("Company details has been successfully saved!", "Save Ewcord", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtcompanyname.Clear();
            txtaddress.Clear();
        }
        #endregion Company Detail
    }
}
