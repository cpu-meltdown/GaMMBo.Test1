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
            //LoginForm frmLogin = new LoginForm();
          //  this.Hide();
            Controller.frmMain.Hide();
            Controller.frmLogin.txtPassword2.Visible = false;
            Controller.frmLogin.lblPassword2.Visible = false;
            Controller.frmLogin.btnLogin.Text = "Login";
            Controller.frmLogin.ShowDialog();
            
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            //CategoriesForm frmCategories = new CategoriesForm();
            //this.Hide();
            Controller.frmMain.Hide();
            Controller.frmCategories.lblUser.Text = "Guest";
            Controller.frmCategories.ShowDialog();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            //LoginForm loginForm = new LoginForm();
            //this.Hide();
            Controller.frmMain.Hide();
            Controller.frmLogin.txtPassword2.Visible = true;
            Controller.frmLogin.lblPassword2.Visible = true;
            Controller.frmLogin.btnLogin.Text = "Create Account";
            Controller.frmLogin.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ResultsForm frmresults = new ResultsForm();
            Controller.frmResults.Show();
           
            

        }
    }
}
