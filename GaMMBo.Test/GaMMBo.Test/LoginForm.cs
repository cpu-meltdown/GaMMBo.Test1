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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Controller.frmLogin.Hide();
            Controller.frmMain.Show();


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
     
            if (btnLogin.Text == "Login") {
                //existing account
                Controller.login(txtUsername.Text, txtPassword.Text);
            } else {
                // new account
                Controller.addUser(txtUsername.Text, txtPassword.Text, txtPassword2.Text);  
            }   

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (Controller.guest)
            {
                Controller.frmLogin.txtPassword2.Visible = true;
                Controller.frmLogin.lblPassword2.Visible = true;
                Controller.frmLogin.btnLogin.Text = "Create Account";
            }
        }

        private void txtPAssword2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

//<<<<<<< HEAD
//        private void txtUsername_TextChanged(object sender, EventArgs e)
//=======
//        private void txtPassword_TextChanged(object sender, EventArgs e)
//>>>>>>> 55ec1c9872ec4624593c8fd0274546dcfcff902e
//        {

//        }

        ////Ben - allows setting the repeat password textbox to visible form another form
        //public Boolean TextBoxValue
        //{
        //    set { txtPassword2.Visible = value; }
        //}
        ////Ben - allows setting the repeat password label to visible form another form
        //public Boolean LabelValue
        //{
        //    set { lblPassword2.Visible = value; }
        //}
    }
}
