using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;

namespace MyPro
{
    public partial class AllDonersDetails : Form
    {

        function fn = new function();
        public AllDonersDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllDonersDetails_Load(object sender, EventArgs e)
        {
            string query = "select * from newDoner";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }
    }
}
