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
         public static bool guest = false;
         public static MainForm frmMain = new MainForm();
         public static LoginForm frmLogin = new LoginForm();
         public static CategoriesForm frmCategories = new CategoriesForm();
         public static PrefMenu frmPref = new PrefMenu();
         public static ResultsForm frmResults = new ResultsForm();

         public static String catName;


         public static int getUserId()
         {
             return Accounts.getUserId();
         }

         public static void createTemproraryAccount(){
             Accounts.createTemproraryAccount();
         }
         public static void deleteTemproraryAccount()
         {
             Accounts.deleteTemproraryAccount();
         }

         public static void login(string userName, string password)
         {
             Accounts.login(userName, password);
         }

         public static void addUser(string userName, string password1, string password2)
         {
             Accounts.addUser(userName, password1, password2);
         }

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

     }
}
