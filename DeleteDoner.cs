using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPro
{
    public partial class DeleteDoner : Form
    {
        function fn = new function();
        public DeleteDoner()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtDonorId.Text != "")
            {
                string query = "select * from newDoner where did = "+txtDonorId.Text+"";
                DataSet ds = fn.getData(query);

                if(ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtFname.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMname.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtDob.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtMob.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtGender.Text = ds.Tables[0].Rows[0][6].ToString();
                    txtMail.Text = ds.Tables[0].Rows[0][7].ToString();
                    txtBg.Text = ds.Tables[0].Rows[0][8].ToString();
                    txtCity.Text = ds.Tables[0].Rows[0][9].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[0][10].ToString();
                }
                else
                {
                    MessageBox.Show("invalid Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDonorId.Clear();
                }
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?","Delete",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string query = "delete from newDoner where did= "+txtDonorId.Text+"";
                fn.setData(query);
                MessageBox.Show("Data has been Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void txtDonorId_TextChanged(object sender, EventArgs e)
        {
            if(txtDonorId.Text == "")
            {
                txtName.Clear();
                txtFname.Clear();
                txtMname.Clear();
                txtDob.Clear();
                txtMob.Clear();
                txtGender.Clear();
                txtMail.Clear();
                txtBg.Clear();
                txtCity.Clear();
                txtAddress.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDonorId.Clear();
        }

        
    }
}
