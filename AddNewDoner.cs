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
    public partial class AddNewDoner : Form
    {
        function fn = new function();
        public AddNewDoner()
        {
            InitializeComponent();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewDoner_Load(object sender, EventArgs e)
        {
            String query = "select max(did) from newDoner";
            DataSet ds = fn.getData(query);
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            labelNewId.Text = (count+1).ToString();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textName.Text != "" && textFatherName.Text != "" && textMotherName.Text != "" && textDOB.Text != "" && textMobile.Text != "" && textGender.Text != "" && textMail.Text != "" && textBloodGroup.Text != "" && textCity.Text != "" && textAddress.Text != "")
            {
                string dname = textName.Text;
                string fname = textFatherName.Text;
                string mname = textMotherName.Text;
                string dob = textDOB.Text;
                Int64 mobile = Int64.Parse(textMobile.Text);
                string city = textCity.Text;
                string daddress = textAddress.Text;
                string gender = textGender.Text;
                string email = textMail.Text;
                string bloodGroup = textBloodGroup.Text;

                string query = "insert into newDoner(dname,fname,mname,dob,mobile,gender,email,bloodGroup,city,daddress) values ('" + dname + "','" + fname + "','" + mname + "','" + dob + "','" + mobile + "','" + gender + "','" + email + "','" + bloodGroup + "','" + city + "','" + daddress + "')";
                fn.setData(query);
                MessageBox.Show("Data has been saved","Succsess",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fill All Fields","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textFatherName.Clear();
            textMotherName.Clear();
            textDOB.ResetText();
            textMobile.Clear();
            textGender.ResetText();
            textMail.Clear();
            textBloodGroup.ResetText();
            textCity.Clear();
            textAddress.Clear();
        }

        private void textMail_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if(Regex.IsMatch(textMail.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.textMail, "Invalid Email Address");
                return;
            }
        }

        private void textMobile_Leave(object sender, EventArgs e)
        {
            string patern = "^[6-9][0-9]{9}$";
            if(Regex.IsMatch((string)textMobile.Text, patern))
            {
                errorProvider2.Clear();
            }
            else
            {
                errorProvider2.SetError(this.textMobile, "Invalid Mobile No");
                return;
            }
        }

       
    }
}
