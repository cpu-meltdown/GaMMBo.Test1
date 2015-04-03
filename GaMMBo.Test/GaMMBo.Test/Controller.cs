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


         public static void login(string user, string password) {


             /////////////////////////////////
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
                     return;
                 }
                 else
                 {
                     //CategoriesForm categoriesForm = new CategoriesForm();
                     //hide form
                     frmLogin.Hide();
                     frmCategories.ShowDialog(); 
                 }
             }
             /////////////////////////////////


             
             MessageBox.Show(user + " " + pass);
         
         }



         // who is logged on
         static int userID;

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
