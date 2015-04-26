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

       

       

      

        private void button1_Click(object sender, EventArgs e)
        {
            //ResultsForm frmresults = new ResultsForm();
            Controller.frmResults.Show();
           
            

        }

       

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //LoginForm frmLogin = new LoginForm();
            //  this.Hide();
            Controller.frmMain.Hide();
            Controller.frmLogin.txtPassword2.Visible = false;
            Controller.frmLogin.lblPassword2.Visible = false;
            Controller.frmLogin.btnLogin.Text = "Login";
            Controller.frmLogin.ShowDialog();
        }

        private void newUser_Click(object sender, EventArgs e)
        {

            //LoginForm loginForm = new LoginForm();
            //this.Hide();
            Controller.frmMain.Hide();
            Controller.frmLogin.txtPassword2.Visible = true;
            Controller.frmLogin.lblPassword2.Visible = true;
            Controller.frmLogin.btnLogin.Text = "Create Account";
            Controller.frmLogin.Text = "New User";
            Controller.frmLogin.ShowDialog();

        }

        private void guest_Click(object sender, EventArgs e)
        {
            //CategoriesForm frmCategories = new CategoriesForm();
            //this.Hide();
            Controller.guest = true;
            Controller.frmCategories.lblUser.Text = "Guest";
            Controller.createTemproraryAccount();
            Controller.frmMain.Hide();
            Controller.frmCategories.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Controller.frmMain.Hide();
            Controller.usform.Show();

        }
    }
}
