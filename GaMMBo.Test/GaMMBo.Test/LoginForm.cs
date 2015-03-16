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
            //Ben
            if (btnLogin.Text == "Login") {
                CategoriesForm Cats = new CategoriesForm();
                this.Hide();
                Cats.ShowDialog();
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
                if (txtPassword2.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter repeat password");
                    txtPassword2.Focus();
                    return;
                }
                //check for duplicate username -- need database first
                //make sure passwords match
                if (txtPassword.Text != txtPassword2.Text) {
                    MessageBox.Show("Both passwords must match");
                    return;
                }
                //create acount
            }

            

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtPAssword2_TextChanged(object sender, EventArgs e)
        {

        }

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
