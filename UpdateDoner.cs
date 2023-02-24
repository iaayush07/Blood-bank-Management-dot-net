using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MyPro
{
    public partial class UpdateDoner : Form
    {
        function fn = new function();
        public UpdateDoner()
        {
            InitializeComponent();
        }

        private void buttonUClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxUDonerId.Text.ToString());
            string query = "select * from newDoner where did = " + id + "";
            DataSet ds = fn.getData(query);

            if ( ds.Tables[0].Rows.Count != 0 )
            {
                textBoxUname.Text = ds.Tables[0].Rows[0][1].ToString();
                textBoxUfname.Text = ds.Tables[0].Rows[0][2].ToString();
                textBoxUmname.Text = ds.Tables[0].Rows[0][3].ToString();
                textBoxUdob.Text = ds.Tables[0].Rows[0][4].ToString();
                textBoxUmob.Text = ds.Tables[0].Rows[0][5].ToString();
                textBoxUgender.Text = ds.Tables[0].Rows[0][6].ToString();
                textBoxUemail.Text = ds.Tables[0].Rows[0][7].ToString();
                textBoxUbg.Text = ds.Tables[0].Rows[0][8].ToString();
                textBoxUcity.Text = ds.Tables[0].Rows[0][9].ToString();
                textBoxUAddress.Text = ds.Tables[0].Rows[0][10].ToString();
            }
            else
            {
                MessageBox.Show("invalid Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxUDonerId_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUDonerId.Text == "")
            {
                textBoxUname.Clear();
                textBoxUfname.Clear();
                textBoxUmname.Clear();
                textBoxUdob.ResetText();
                textBoxUmob.Clear();
                textBoxUgender.ResetText();
                textBoxUemail.Clear();
                textBoxUbg.ResetText();
                textBoxUcity.Clear();
                textBoxUAddress.Clear();
            }
        }

        private void buttonUreset_Click(object sender, EventArgs e)
        {
            textBoxUDonerId.Clear();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            String query = "update newDoner set dname='"+textBoxUname.Text+"',fname='"+textBoxUfname.Text+ "',mname= '"+textBoxUmname.Text+ "',dob= '"+textBoxUdob.Text+ "',mobile= '"+textBoxUmob.Text+ "',gender= '"+textBoxUgender.Text+ "',email= '"+textBoxUemail.Text+ "',bloodgroup= '"+textBoxUbg.Text+ "',city= '"+textBoxUcity.Text+ "',daddress= '"+textBoxUAddress.Text+ "' where did= "+textBoxUDonerId.Text+"";
            fn.setData(query);
            UpdateDoner_Load(this, null);
            MessageBox.Show("Data has been Updated","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void UpdateDoner_Load(object sender, EventArgs e)
        {
            textBoxUDonerId.Clear();
        }

        private void textBoxUemail_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(textBoxUemail.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.textBoxUemail, "Invalid Email Address");
                return;
            }
        }

        private void textBoxUmob_Leave(object sender, EventArgs e)
        {
            string patern = "^[6-9][0-9]{9}$";
            if (Regex.IsMatch((string)textBoxUmob.Text, patern))
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(this.textBoxUmob, "Invalid Mobile No");
                return;
            }
        }

    }
}
