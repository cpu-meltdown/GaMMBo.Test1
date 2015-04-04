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

     static class Controller
    {
         public static MainForm frmMain = new MainForm();
         public static LoginForm frmLogin = new LoginForm();
         public static CategoriesForm frmCategories = new CategoriesForm();
         public static PrefMenu frmPref = new PrefMenu();





         public static void login(string user, string password) {
             //validate login
             String pass = "";
             SqlConnection conn = new SqlConnection(Properties.Settings.Default.CategoriesConnectionString);
             SqlCommand login = new SqlCommand("SELECT [Password] FROM Users WHERE [UserName] = @username", conn);
             login.Parameters.Add("@username", SqlDbType.NVarChar);
             login.Parameters["@username"].Value = user;
             try { conn.Open(); }
             catch (Exception ex) { MessageBox.Show(":" + ex); }

             SqlDataReader sqlReader = login.ExecuteReader();

             if (sqlReader.HasRows == false)
             {
                 MessageBox.Show("Invalid username");
                 frmLogin.txtUsername.Focus();
                 return;
             }
             else
             {
                 while (sqlReader.Read())
                 {
                     pass = sqlReader[0].ToString();
                 }
                 if (pass != password)
                 {
                     MessageBox.Show("Invalid password");
                     frmLogin.txtPassword.Focus();
                     return;
                 }
                 else
                 {
                     userName = user;
                     frmCategories.lblUser.Text = user;
                     frmLogin.Hide();
                     frmCategories.ShowDialog();
                 }
             }
             conn.Close();
         }






         public static void addUser(string user, string pass1, string pass2){
             //check if all fields entered
             if (user.Trim() == "")
             {
                 MessageBox.Show("Please enter a username");
                 frmLogin.txtUsername.Focus();
                 return;
             }
             if (pass1.Trim() == "")
             {
                 MessageBox.Show("Please enter a password");
                 frmLogin.txtPassword.Focus();
                 return;
             }

             if (pass1.Length < 8)
             {
                 frmLogin.lblError.Visible = true;
                 frmLogin.txtPassword.Focus();
                 return;
             }
             if (pass2.Trim() == "")
             {
                 MessageBox.Show("Please repeat the password");
                 frmLogin.txtPassword2.Focus();
                 return;
             }
             //make sure passwords match
             if (pass1 != pass2)
             {
                 MessageBox.Show("Both passwords must match");
                 return;
             }

             //check for duplicate username
             SqlConnection conn = new SqlConnection(Properties.Settings.Default.CategoriesConnectionString);
             SqlCommand chkUser = new SqlCommand("SELECT [UserName] FROM Users WHERE [UserName] = @username", conn);
             chkUser.Parameters.Add("@username", SqlDbType.NVarChar);
             chkUser.Parameters["@username"].Value = user;
             conn.Open();
             try
             {
                 SqlDataReader sqlReader = chkUser.ExecuteReader();
                 if (sqlReader.HasRows)
                 {
                     MessageBox.Show("That username already exists.  Please choose another.");
                     frmLogin.txtUsername.Focus();
                     return;
                 }
             }
             catch (Exception err)
             {
                 MessageBox.Show(":" + err);
             }
             conn.Close();



             //create acount
             SqlCommand addUser = new SqlCommand("INSERT INTO Users VALUES (@username, @password)", conn);
             addUser.Parameters.Add("@username", SqlDbType.NVarChar);
             addUser.Parameters["@username"].Value = user;
             addUser.Parameters.Add("@password", SqlDbType.NVarChar);
             addUser.Parameters["@password"].Value = pass1;
             conn.Open();
             try
             {
                 addUser.ExecuteNonQuery();

             }
             catch (Exception err)
             {
                 MessageBox.Show(":" + err);
             }
             conn.Close();

             MessageBox.Show("Account created successfully");

             frmLogin.Hide();
             frmMain.Show();
             conn.Close();
         }







         // who is logged on
         static String userName;

         // entry point of program
         [STAThread]
         static void Main()
         {

             Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
             Application.Run(new Form1());

             // buttons call proxy methods directly
             // it seems overly redundant to have methods that call methods
              
 
             // searchs will be methods in controller

         }
         public static void bestFit()
         {
             // sequence of steps would be 
             // loop through db
             // if object has been voted on do not pull
             // get user attributes
             // sort based on attributes
             // return list of attribues
         }

     }
}
