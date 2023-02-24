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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                btnLogin.Enabled = true;    
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void btnHideShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnHideShow.Text == "Show")
            {
                btnHideShow.Text = "Hide";
                textBoxPassword.PasswordChar = '\0';
            }
            else
            {
                btnHideShow.Text = "Show";
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text == "Ayush" && textBoxPassword.Text == "ayush")
            {
                Dashboard1 db = new Dashboard1();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter Valid Username OR Password","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
