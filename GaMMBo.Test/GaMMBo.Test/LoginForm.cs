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

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (btnLogin.Text == "Login") {
                //validate login
                String pass = "";
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.CategoriesConnectionString);
                SqlCommand login = new SqlCommand("SELECT [Password] FROM Accounts WHERE [Username] = @username", conn);
                login.Parameters.Add("@username", SqlDbType.NVarChar);
                login.Parameters["@username"].Value = txtUsername.Text;
                conn.Open();
                SqlDataReader sqlReader = login.ExecuteReader();
                if (sqlReader.HasRows == false)
                {
                    MessageBox.Show("Invalid username");
                    return;
                }
                else
                {
                    while (sqlReader.Read())
                    {
                        pass = sqlReader[0].ToString();
                    }
                    if (pass != txtPassword.Text) {
                        MessageBox.Show("Invalid password");
                        return;
                    }
                    else {
                        CategoriesForm categoriesForm = new CategoriesForm();
                        this.Hide();
                        categoriesForm.ShowDialog();
                    }
                }








            } else {
                //check if all fields entered
                if (txtUsername.Text.Trim() == "") {
                    MessageBox.Show("Please enter a username");
                    txtUsername.Focus();
                    return;
                }
                if (txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter a password");
                    txtPassword.Focus();
                    return;
                }

                if (txtPassword.Text.Length < 8)
                {
                    lblError.Visible = true;
                    txtPassword.Focus();
                    return;
                }
                if (txtPassword2.Text.Trim() == "")
                {
                    MessageBox.Show("Please repeat the password");
                    txtPassword2.Focus();
                    return;
                }
                //make sure passwords match
                if (txtPassword.Text != txtPassword2.Text)
                {
                    MessageBox.Show("Both passwords must match");
                    return;
                }

                //check for duplicate username
                SqlConnection conn = new SqlConnection(Properties.Settings.Default.CategoriesConnectionString);
                SqlCommand chkUser = new SqlCommand("SELECT [Username] FROM Accounts WHERE [Username] = @username", conn);
                chkUser.Parameters.Add("@username", SqlDbType.NVarChar);
                chkUser.Parameters["@username"].Value = txtUsername.Text;
                conn.Open();
                try
                {
                    SqlDataReader sqlReader = chkUser.ExecuteReader();
                    if (sqlReader.HasRows)
                    {
                        MessageBox.Show("That username already exists.  Please choose another.");
                        txtUsername.Focus();
                        return;
                    }
                }
                catch(Exception err) {
                    MessageBox.Show(":" + err);
                }
                conn.Close();



                //create acount
                SqlCommand addUser = new SqlCommand("INSERT INTO ACCOUNTS VALUES (@username, @password)", conn);
                addUser.Parameters.Add("@username", SqlDbType.NVarChar);
                addUser.Parameters["@username"].Value = txtUsername.Text;
                addUser.Parameters.Add("@password", SqlDbType.NVarChar);
                addUser.Parameters["@password"].Value = txtPassword.Text;
                conn.Open();
                try
                {
                    addUser.ExecuteNonQuery();

                }
                catch(Exception err) { 
                    MessageBox.Show(":" + err);
                }
                conn.Close();

                MessageBox.Show("Account created successfully");
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();

            }

            

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtPAssword2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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
