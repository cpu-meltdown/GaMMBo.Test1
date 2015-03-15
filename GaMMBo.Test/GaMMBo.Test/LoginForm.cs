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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm frmmain = new MainForm();
            this.Hide();
            frmmain.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CategoriesForm Cats = new CategoriesForm();
            this.Hide();
            Cats.ShowDialog();

        }
    }
}
