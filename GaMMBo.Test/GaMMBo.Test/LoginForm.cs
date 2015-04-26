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

        public string entered;


        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Controller.frmLogin.txtUsername.Text = "";
            Controller.frmLogin.txtPassword.Text = "";
            Controller.frmLogin.txtPassword2.Text = "";
            if (Controller.guest)
            {
                Controller.frmLogin.Hide();
                Controller.frmCategories.Show();
            }
            else
            {
                Controller.frmLogin.Hide();
                Controller.frmMain.Show();
            }


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

            txtUsername.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtUsername.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection users = new AutoCompleteStringCollection();

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.CategoriesConnectionString);
            SqlCommand auto = new SqlCommand("SELECT [UserName] FROM Users WHERE UserName like @username", conn);
            auto.Parameters.Add("@username", SqlDbType.NVarChar);
            auto.Parameters["@username"].Value = entered + "%";
            conn.Open();

            SqlDataReader sqlReader = auto.ExecuteReader();

            while (sqlReader.Read())
            {
                users.Add(sqlReader[0].ToString());
            }

            txtUsername.AutoCompleteCustomSource = users;
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

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            //makes sure spaces aren't used in password
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtUsername_KeyUp(object sender, KeyEventArgs e)
        {
            entered = txtUsername.Text;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //makes sure spaces aren't used in password
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }

        private void txtPassword2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //makes sure spaces aren't used in password
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
        
    }
}
