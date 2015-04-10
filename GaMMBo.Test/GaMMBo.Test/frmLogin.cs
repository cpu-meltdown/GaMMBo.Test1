using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaMMBo.Test
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain frmmain = new frmMain();
            this.Hide();
            frmmain.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmCategories Cats = new frmCategories();
            this.Hide();
            Cats.ShowDialog();

        }
    }
}
