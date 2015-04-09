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
    //if you guys need me to explain anything just let me know 
    public partial class PrefMenu : Form
    {
        public int skipNum = 0;// variable that keeps track how many times the user skips
        public int choice;// variable keeps track of what category is being accessed
        public int objectId;//the id of the object being voted on
        public int userId = 4;//if the voting being done is by a user their id is stored in this variable its set to 4 only so i could test 
                               // when the user logs in the number will be sent here like the choice 
        public int numOfvotes = 0;// keeps track how many objects having been voted on hasnt be used yet will be
        public int vote = 0; // variable for the userlinker tables 
        public Boolean userVoting = false;//will be set prior to this point when the user either logs in or clicks guest
        // the rest are self explanatory i may move or remove at the end before i transfer all to proxy
        Random randomNumber = new Random();
        String type = null;
        Image image = null;
        SqlCommand sqlCommand = null;
        SqlDataReader sqlReader = null;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.CategoriesConnectionString);
        public PrefMenu()
        {
            InitializeComponent();
            //choice = c;
        }

        // whats left to be done which i will do is create a new table to hold guests like so results can be given to them at the end 
        // i will also add a variable to keep track of how many objects they have voted on and cut it off at 10
        // also is left is updating the userbooks, usermovies, etc table to increment when they like an object
        private void button1_Click(object sender, EventArgs e)
        {
            // like button
            if (userVoting)
            {
                this.likeOrdislikeObject(1);
                this.getUserObject();
            }
            else
            {
                
                this.getGuestObject();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            // disklike button 
            if (userVoting)
            {
                this.likeOrdislikeObject(0);
                this.getUserObject();
            }
            else
            {
                
                this.getGuestObject();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // skip button limit is set to 5 skips if the user reaches five a message pops up telling them to either like or dislike
            if (skipNum < 5)
            {
                if (userVoting)
                {
                    this.getUserObject();
                }
                else
                {
                    this.getGuestObject();
                }

                skipNum = skipNum + 1;
                // return;
            }
            else
            {
                MessageBox.Show("Skip Limit has been reached please either like or dislike");
                // return;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //search button

        }

        private void button5_Click(object sender, EventArgs e)
        {
            skipNum = 0;
            // CategoriesForm categoriesForm = new CategoriesForm();
            Controller.frmPref.Hide();
            Controller.frmCategories.Show();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void PrefMenu_Load(object sender, EventArgs e)
        {
            if (userVoting)//userVoting is a boolean that will be set when the user either logs in or will enter as a guest
            {
                this.getUserObject();
            }
            else
            {
                this.getGuestObject();
            }


        }
        private void getGuestObject()
        {
            // goes into database and prints random object 

            if (choice == 1)//generates music 
            {
                type = "Music";
                objectId = randomNumber.Next(141)+ 1;

                categoryImage.Image = Image.FromFile(@"C:\GaMMBo.Test1\Music_Images\" + objectId + ".jpg");
            }
            else if (choice == 2)//generates movies 
            {
                type = "Movies";

                objectId = randomNumber.Next(136) + 1;
                categoryImage.Image = Image.FromFile(@"C:\GaMMBo.Test1\Movies_Images\" + objectId + ".jpg");
            }
            else if (choice == 3)//generates books 
            {
                type = "Books";

                objectId = randomNumber.Next(120) + 1;
                categoryImage.Image = Image.FromFile(@"C:\GaMMBo.Test1\Books_Images\" + objectId + ".jpg");
            }
            else if (choice == 4)// generates games 
            {
                type = "Games";
                objectId = randomNumber.Next(84) +1;
                categoryImage.Image = Image.FromFile(@"C:\GaMMBo.Test1\Games_Images\" + objectId + ".jpg");

            }
            sqlCommand = new SqlCommand("Select Name, Description from " + type + " where ID = @ID", conn);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
            sqlCommand.Parameters["@ID"].Value = objectId;

            conn.Open();
            SqlDataReader sqlReader = sqlCommand.ExecuteReader();

            while (sqlReader.Read())
            {
                categoryObjectName.Text = sqlReader[0].ToString();
                categoryObjectDescription.Text = sqlReader[1].ToString();
            }

            conn.Close();


        }

        public void likeOrdislikeObject(int v)
        {   
            // this method inserts a voted object into the linker tables the parameter v can either be 0 for dislike or 1 for like
            
            vote = v;


            if (choice == 1)
            {
                type = "Music";
            }
            else if (choice == 2)
            {
                type = "Movie";
            }
            else if (choice == 3)
            {
                type = "Book";
            }
            else if (choice == 4)
            {
                type = "Game";
            }
            SqlCommand saveLike = new SqlCommand("INSERT INTO User" + type + "Linker VALUES (@userId, @typeId, @vote)", conn);
            saveLike.Parameters.Add("@userId", SqlDbType.Int);
            saveLike.Parameters["@userId"].Value = userId;
            saveLike.Parameters.Add("@typeId", SqlDbType.Int);
            saveLike.Parameters["@typeId"].Value = objectId;
            saveLike.Parameters.Add("@vote", SqlDbType.Int);
            saveLike.Parameters["@vote"].Value = vote;
            conn.Open();

            saveLike.ExecuteNonQuery();

            conn.Close();
        }


        private void getUserObject()// takes into account objects that have already been voted on
        {    
            String name = null;

            String linker = null;


            if (choice == 1)//generates music 
            {
                type = "Music";
                linker = "UserMusicLinker";
                objectId = randomNumber.Next(141);
                image = Image.FromFile(@"C:\GaMMBo.Test1\Music_Images\" + objectId + ".jpg");


            }
            else if (choice == 2)//generates Movies
            {
                type = "Movies";
                linker = "UserMovieLinker";
                objectId = randomNumber.Next(136);
                image = Image.FromFile(@"C:\GaMMBo.Test1\Movies_Images\" + objectId + ".jpg");


            }
            else if (choice == 3)//books
            {
                type = "Books";
                linker = "UserBookLinker";
                objectId = randomNumber.Next(120);
                image = Image.FromFile(@"C:\GaMMBo.Test1\Books_Images\" + objectId + ".jpg");

            }
            else if (choice == 4)//games
            {
                type = "Games";
                linker = "UserGameLinker";
                objectId = randomNumber.Next(84);
                image = Image.FromFile(@"C:\GaMMBo.Test1\Games_Images\" + objectId + ".jpg");
            }//this sql command checks if that particular object and user is in the specific linker table 
            sqlCommand =
                                       new SqlCommand("Select " + type + ".Name  From " + type +
                                        " Inner Join " + linker + " ON " + linker + "." + type + "Id = " + type + ".Id " +
                                       " Where " + linker + "." + type + "Id = @ID AND " + linker + ".UserId = @UID", conn);

            sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
            sqlCommand.Parameters["@ID"].Value = objectId;
            sqlCommand.Parameters.Add("@UID", SqlDbType.Int);
            sqlCommand.Parameters["@UID"].Value = userId;

            conn.Open();
            sqlReader = sqlCommand.ExecuteReader();

            while (sqlReader.Read())
            {
                name = sqlReader[0].ToString();
            }
            conn.Close();
            // if the object has not been voted on the name printed out will be null 
            // using another sql statement the objects name and description will be pulled from one of the four categories database
            // if the name is not null the method calls itself to get another object id to test and display
            if (name == null)
            {
                sqlCommand = new SqlCommand("Select " + type + ".Name , " + type + ".Description From " + type + " Where " + type + ".Id = @ID ", conn);
                categoryImage.Image = image;
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
                sqlCommand.Parameters["@ID"].Value = objectId;


                conn.Open();
                sqlReader = sqlCommand.ExecuteReader();

                while (sqlReader.Read())
                {
                    categoryObjectName.Text = sqlReader[0].ToString();
                    categoryObjectDescription.Text = sqlReader[1].ToString();

                }
                conn.Close();
            }


            else
            {
                this.getUserObject();
            }

        }


    }
}
