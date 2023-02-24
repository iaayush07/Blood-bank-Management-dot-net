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
    public partial class StockDecrease : Form
    {
        function fn = new function();
        public StockDecrease()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockDecrease_Load(object sender, EventArgs e)
        {
            string query = "select blood_group,quantity from stock";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            string query = "update stock set quantity=quantity - " + txtUnitss.Text + " where blood_group = '" + txtBGroup.Text + "'";
            fn.setData(query);
            StockDecrease_Load(this, null);
            MessageBox.Show("Data has been saved", "Succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
