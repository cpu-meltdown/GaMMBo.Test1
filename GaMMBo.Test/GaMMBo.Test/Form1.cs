using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GaMMBo.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ben - bring up main form
            //MainForm main = new MainForm();
            this.Hide();
            //main.ShowDialog();
            Controller.frmMain.ShowDialog();
                              
            // TODO: This line of code loads data into the 'GammboDBDataSet.Music' table. You can move, or remove it, as needed.
           // this.musicTableAdapter.Fill(this.GammboDBDataSet.Music); Bassima - keeps giving me an sql exception error so i commented it out
            
        }

        private void musicBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.musicBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.GammboDBDataSet);

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MainForm frmMain = new MainForm();
            this.Hide();
            frmMain.ShowDialog();
            
        }

        private void musicDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
