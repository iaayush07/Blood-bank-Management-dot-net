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
    public partial class Dashboard1 : Form
    {
        public Dashboard1()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewDonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDoner and = new AddNewDoner();
            and.Show();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDoner udd = new UpdateDoner();
            udd.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
           AllDonersDetails add = new AllDonersDetails();
           add.Show();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBloodAddress sba = new SearchBloodAddress();
            sba.Show();
        }

        private void bloodGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchByBlood sbb = new SearchByBlood();
            sbb.Show();
        }

        private void inceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockIncrease si = new StockIncrease(); 
            si.Show();
        }

        private void decreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDecrease sd = new StockDecrease();
            sd.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockDetails sde = new StockDetails();
            sde.Show();
        }

        private void deleteDonerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteDoner dde = new DeleteDoner();
            dde.Show();
        }
    }
}
