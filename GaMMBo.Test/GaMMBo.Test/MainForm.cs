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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm frmlogin = new LoginForm();
            this.Hide();
            frmlogin.ShowDialog();
            
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            CategoriesForm frmCategories = new CategoriesForm();
            this.Hide();
            frmCategories.ShowDialog();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.passwordLabel.Visible = true;
            loginForm.txtPassword2.Visible = true;
            loginForm.lblPassword2.Visible = true;
            loginForm.btnLogin.Text = "Create Account";
            loginForm.ShowDialog();

        }
    }
}
