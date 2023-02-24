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
    public partial class StockIncrease : Form
    {
        function fn = new function();
        public StockIncrease()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockIncrease_Load(object sender, EventArgs e)
        {
            string query = "select blood_group,quantity from stock";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            string query = "update stock set quantity=quantity + "+txtUnits.Text+" where blood_group = '"+txtBloodGroup.Text+"'";
            fn.setData(query);
            StockIncrease_Load(this,null);
            MessageBox.Show("Data has been saved", "Succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
