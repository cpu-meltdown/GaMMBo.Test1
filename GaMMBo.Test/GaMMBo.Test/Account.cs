using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaMMBo.Test
{
    static class Account
    {
        private static int userId = 0;
        private static string userName;


        public static void addUser(string user, string pass1, string pass2)
        {
            //check if all fields entered
            if (user.Trim() == "")
            {
                MessageBox.Show("Please enter a username");
                Controller.frmLogin.txtUsername.Focus();
                return;
            }
            if (pass1.Trim() == "")
            {
                MessageBox.Show("Please enter a password");
                Controller.frmLogin.txtPassword.Focus();
                return;
            }

            if (pass1.Length < 8)
            {
                
                MessageBox.Show("Password must be more than 8 characters");
                Controller.frmLogin.txtPassword.Focus();
                return;
            }
            if (pass2.Trim() == "")
            {
                MessageBox.Show("Please repeat the password");
                Controller.frmLogin.txtPassword2.Focus();
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
            chkUser.Parameters.Add("@username", SqlDbType.VarChar);
            chkUser.Parameters["@username"].Value = user;
            conn.Open();
            try
            {
                SqlDataReader sqlReader = chkUser.ExecuteReader();
                if (sqlReader.HasRows)
                {
                    MessageBox.Show("That username already exists.  Please choose another.");
                    Controller.frmLogin.txtUsername.Focus();
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err);
            }

            conn.Close();

            conn.Open();
            if (Controller.guest)
            {
                SqlCommand update = new SqlCommand("Update Users set Username = @username, Password = @password "
                    + "Where UserId = @userId", conn);
                update.Parameters.Add("@username", SqlDbType.VarChar);
                update.Parameters["@username"].Value = user;
                update.Parameters.Add("@password", SqlDbType.VarChar);
                update.Parameters["@password"].Value = pass1;
                update.Parameters.Add("@userId", SqlDbType.VarChar);
                update.Parameters["@userId"].Value = userId;
                try
                {
                    update.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err);
                }
                Controller.guest = false;
                //Controller.frmCategories.lblUser.Text = Controller.frmLogin.txtUsername.Text;
                Controller.frmCategories.lblUser.Text = user;
            }
            else
            {
                //create acount
                SqlCommand addUser = new SqlCommand("INSERT INTO Users VALUES (@username, @password)", conn);
                addUser.Parameters.Add("@username", SqlDbType.VarChar);
                addUser.Parameters["@username"].Value = user;
                addUser.Parameters.Add("@password", SqlDbType.VarChar);
                addUser.Parameters["@password"].Value = pass1;
                try
                {
                    addUser.ExecuteNonQuery();

                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err);
                }

            }
            MessageBox.Show("Account created successfully");
            Controller.frmLogin.txtUsername.Text = "";
            Controller.frmLogin.txtPassword.Text = "";
            Controller.frmLogin.txtPassword2.Text = "";

            Controller.frmLogin.Hide();
            Controller.frmCategories.Show();
            conn.Close();
        }


        public static void login(string user, string password)
        {
            //validate login
            String pass = "";
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.CategoriesConnectionString);
            SqlCommand login = new SqlCommand("SELECT [UserName], [Password] FROM Users WHERE [UserName] = @username", conn);
            login.Parameters.Add("@username", SqlDbType.NVarChar);
            login.Parameters["@username"].Value = user;
            try { conn.Open(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }

            SqlDataReader sqlReader = login.ExecuteReader();

            if (sqlReader.HasRows == false)
            {
                MessageBox.Show("Invalid username");
                Controller.frmLogin.txtUsername.Focus();
                return;
            }
            else
            {
                while (sqlReader.Read())
                {
                    Controller.frmLogin.txtUsername.Text = sqlReader[0].ToString();
                    pass = sqlReader[1].ToString();
                }
                if (pass != password)
                {
                    MessageBox.Show("Invalid password");
                    Controller.frmLogin.txtPassword.Focus();
                    return;
                }
                else
                {
                    userName = Controller.frmLogin.txtUsername.Text;
                    Controller.frmCategories.lblUser.Text = Controller.frmLogin.txtUsername.Text;
                    Controller.frmLogin.txtUsername.Text = "";
                    Controller.frmLogin.txtPassword.Text = "";
                    Controller.frmLogin.Hide();
                    Controller.frmCategories.ShowDialog();
                }
            }
            conn.Close();
        }

        //This method gets the UserId from the Users table and store it in the variable userId

        private static int getUserIdFromTable()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.CategoriesConnectionString);
            SqlCommand getUserId = new SqlCommand("Select UserId From Users Where UserName = @userName", conn);
            getUserId.Parameters.Add("@userName", SqlDbType.NVarChar);
            getUserId.Parameters["@userName"].Value = Controller.frmCategories.lblUser.Text.ToString();
            conn.Open();
            SqlDataReader sqlReader = getUserId.ExecuteReader();
            try
            {
                while (sqlReader.Read())
                {
                    userId = int.Parse(sqlReader[0].ToString());
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err);
            }
            conn.Close();
            return userId;
        }

        public static int getUserId()
        {
            if (userId != 0)
            {
                return userId;
            }
            return userId = getUserIdFromTable();
        }

        public static void createTemproraryAccount()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.CategoriesConnectionString);
            SqlCommand addUser = new SqlCommand("INSERT INTO Users VALUES (@username, @password)", conn);
            addUser.Parameters.Add("@username", SqlDbType.VarChar);
            addUser.Parameters["@username"].Value = "guest";
            addUser.Parameters.Add("@password", SqlDbType.VarChar);
            addUser.Parameters["@password"].Value = "guest";
            conn.Open();
            try
            {
                addUser.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err);
            }
            conn.Close();
            userId = getUserId();
        }

        public static void deleteTemproraryAccount()
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.CategoriesConnectionString);

            string[] tables = { "UserMovies", "UserMusic", "UserBooks", "UserGames", "UserMovieLinker"
                              ,"UserMusicLinker", "UserBookLinker", "UserGameLinker", "Users"};


            conn.Open();
            for (int i = 0; i < tables.Length; i++)
            {
                SqlCommand deleteUser = new SqlCommand("Delete from " + tables[i] +
                        " Where UserId = @Id ", conn);
                deleteUser.Parameters.Add("@Id", SqlDbType.Int);
                deleteUser.Parameters["@Id"].Value = userId;
                try
                {
                    deleteUser.ExecuteNonQuery();

                }
                catch (Exception err)
                {
                    MessageBox.Show("Error: " + err);
                }
                deleteUser.Dispose();

            }
            Controller.guest = false;
            conn.Close();

        }
    }
}
