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
    public class Genre
    {
        string genreName;

        public Genre(string name)
        {
            genreName = name;
        }

        public string getGenreName()
        {
            return genreName;
        }


    }

   public static class Proxy
    {
       
        public static int choice;// variable keeps track of what category is being accessed
        public static int objectId;//the id of the object being voted on
        public static int userId = Controller.getUserId();//if the voting being done is by a user their id is stored in this variable its set to 4 only so i could test 
        // when the user logs in the number will be sent here like the choice 
        public static int numOfvotes;
        static Random randomNumber = new Random();
        static String type = null;
        static Image image = null;
        static SqlCommand sqlCommand = null;
        static SqlDataReader sqlReader = null;
        static SqlConnection conn = new SqlConnection(Properties.Settings.Default.CategoriesConnectionString);
        static Genre[] moviesGenres = new Genre[6];
        static Genre[] musicGenres = new Genre[7];
        static Genre[] gamesGenres = new Genre[6];
        static Genre[] booksGenres = new Genre[9];
       public static void initializeGenres (int c,int u)
        {
            numOfvotes = 0;
           choice = c;
           userId = Controller.getUserId() ;
            
           //Setting up Music Genres
           musicGenres[0] = new Genre("Rap");
           musicGenres[1] = new Genre("Rock");
           musicGenres[2] = new Genre("HipHop");// There is no space because when there was it would only read up til Hip
           musicGenres[3] = new Genre("Country");
           musicGenres[4] = new Genre("Metal");
           musicGenres[5] = new Genre("Pop");
           musicGenres[6] = new Genre("Electronic");

           //Setting up Movies Genres
           moviesGenres[0] = new Genre("Comedy");
           moviesGenres[1] = new Genre("Thriller");
           moviesGenres[2] = new Genre("Fantasy");
           moviesGenres[3] = new Genre("Action");
           moviesGenres[4] = new Genre("Romance");
           moviesGenres[5] = new Genre("Drama");

           //Settin up Books Genres
           booksGenres[0] = new Genre("Romance");
           booksGenres[1] = new Genre("Fantasy");
           booksGenres[2] = new Genre("Mystery");
           booksGenres[3] = new Genre("Thriller");
           booksGenres[4] = new Genre("Science");
           booksGenres[5] = new Genre("Fiction");
           booksGenres[6] = new Genre("Novel");
           booksGenres[7] = new Genre("Autobiography");
           booksGenres[8] = new Genre("YoungAdult");

           //Setting up Games Genres
           gamesGenres[0] = new Genre("Strategy");
           gamesGenres[1] = new Genre("Sports");
           gamesGenres[2] = new Genre("Adventure");
           gamesGenres[3] = new Genre("Fighting");
           gamesGenres[4] = new Genre("Racing");
           gamesGenres[5] = new Genre("RPG");
       
       
       }

       public static void getGuestObject()
       {
           if (numOfvotes > 10) {
               
               MessageBox.Show("The user  saw 10 objects this is where we display the results");
           }
           else
           {
               numOfvotes = numOfvotes + 1;
               // goes into database and prints random object 

               if (choice == 1)//generates music 
               {
                   type = "Music";
                   objectId = randomNumber.Next(141) + 1;

                   Controller.frmPref.categoryImage.Image = Image.FromFile(@"C:\GaMMBo.Test1\Music_Images\" + objectId + ".jpg");
               }
               else if (choice == 2)//generates movies 
               {
                   type = "Movies";

                   objectId = randomNumber.Next(136) + 1;
                   Controller.frmPref.categoryImage.Image = Image.FromFile(@"C:\GaMMBo.Test1\Movies_Images\" + objectId + ".jpg");
               }
               else if (choice == 3)//generates books 
               {
                   type = "Books";

                   objectId = randomNumber.Next(120) + 1;
                   Controller.frmPref.categoryImage.Image = Image.FromFile(@"C:\GaMMBo.Test1\Books_Images\" + objectId + ".jpg");
               }
               else if (choice == 4)// generates games 
               {
                   type = "Games";
                   objectId = randomNumber.Next(84) + 1;
                   Controller.frmPref.categoryImage.Image = Image.FromFile(@"C:\GaMMBo.Test1\Games_Images\" + objectId + ".jpg");

               }
               sqlCommand = new SqlCommand("Select Name, Description from " + type + " where ID = @ID", conn);
               sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
               sqlCommand.Parameters["@ID"].Value = objectId;

               conn.Open();
               SqlDataReader sqlReader = sqlCommand.ExecuteReader();

               while (sqlReader.Read())
               {
                   Controller.frmPref.categoryObjectName.Text = sqlReader[0].ToString();
                   Controller.frmPref.categoryObjectDescription.Text = sqlReader[1].ToString();
               }

               conn.Close();



           }
       }
       public static void modifyMusicGenres(String sign)
       {
           int musicGenre = 0;

           sqlCommand = new SqlCommand("Select genre from Music where Id = @ID", conn);
           sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
           sqlCommand.Parameters["@ID"].Value = objectId;

           conn.Open();
           SqlDataReader sqlReader = sqlCommand.ExecuteReader();

           while (sqlReader.Read())
           {
               musicGenre = int.Parse(sqlReader[0].ToString());

           }

           conn.Close();
           int genreNumber1, genreNumber2;
           string genreName1, genreName2;

           if (musicGenre >= 10)
           {
               genreNumber1 = musicGenre / 10;
               genreNumber2 = musicGenre % 10;
               genreName1 = musicGenres[genreNumber1 - 1].getGenreName();
               genreName2 = musicGenres[genreNumber2 - 1].getGenreName();
               sqlCommand = new SqlCommand("Update UserMusic set " + genreName1 + " = " + genreName1 + sign + " 1 , " + genreName2 + " = " + genreName2 + sign + "1  Where UserId = @userId", conn);

           }
           else
           {
               genreName1 = musicGenres[musicGenre - 1].getGenreName();
               sqlCommand = new SqlCommand("Update UserMusic set " + genreName1 + " = " + genreName1 + sign + " 1  where UserId = @userId", conn);
           }
           sqlCommand.Parameters.Add("@userId", SqlDbType.Int);
           sqlCommand.Parameters["@userId"].Value = userId;

           conn.Open();

           sqlCommand.ExecuteNonQuery();

           conn.Close();

       }

       public static void modifyMovieGenres(String sign)
       {
           int movieGenre = 0;

           sqlCommand = new SqlCommand("Select genre from Movies where Id = @ID", conn);
           sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
           sqlCommand.Parameters["@ID"].Value = objectId;

           conn.Open();
           SqlDataReader sqlReader = sqlCommand.ExecuteReader();

           while (sqlReader.Read())
           {
               movieGenre = int.Parse(sqlReader[0].ToString());

           }

           conn.Close();
           int genreNumber1, genreNumber2;
           string genreName1, genreName2;

           if (movieGenre >= 10)
           {
               genreNumber1 = movieGenre / 10;
               genreNumber2 = movieGenre % 10;
               genreName1 = moviesGenres[genreNumber1 - 1].getGenreName();
               genreName2 = moviesGenres[genreNumber2 - 1].getGenreName();
               sqlCommand = new SqlCommand("Update UserMovies set " + genreName1 + " = " + genreName1 + sign + " 1 , " + genreName2 + " = " + genreName2 + sign + "1  Where UserId = @userId", conn);

           }
           else
           {
               genreName1 = moviesGenres[movieGenre - 1].getGenreName();
               sqlCommand = new SqlCommand("Update UserMovies set " + genreName1 + " = " + genreName1 + sign + " 1  where UserId = @userId", conn);
           }
           sqlCommand.Parameters.Add("@userId", SqlDbType.Int);
           sqlCommand.Parameters["@userId"].Value = userId;

           conn.Open();

           sqlCommand.ExecuteNonQuery();

           conn.Close();
       }

       public static void modifyBooksGenres(String sign)
       {
           int bookGenre = 0;

           sqlCommand = new SqlCommand("Select genre from Books where Id = @ID", conn);
           sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
           sqlCommand.Parameters["@ID"].Value = objectId;

           conn.Open();
           SqlDataReader sqlReader = sqlCommand.ExecuteReader();

           while (sqlReader.Read())
           {
               bookGenre = int.Parse(sqlReader[0].ToString());

           }

           conn.Close();
           int genreNumber1, genreNumber2;
           string genreName1, genreName2;

           if (bookGenre >= 10)
           {
               genreNumber1 = bookGenre / 10;
               genreNumber2 = bookGenre % 10;
               genreName1 = booksGenres[genreNumber1 - 1].getGenreName();
               genreName2 = booksGenres[genreNumber2 - 1].getGenreName();
               sqlCommand = new SqlCommand("Update UserBooks set " + genreName1 + " = " + genreName1 + sign + " 1 , " + genreName2 + " = " + genreName2 + sign + "1  Where UserId = @userId", conn);

           }
           else
           {
               genreName1 = booksGenres[bookGenre - 1].getGenreName();
               sqlCommand = new SqlCommand("Update UserBooks set " + genreName1 + " = " + genreName1 + sign + " 1  where UserId = @userId", conn);
           }
           sqlCommand.Parameters.Add("@userId", SqlDbType.Int);
           sqlCommand.Parameters["@userId"].Value = userId;

           conn.Open();

           sqlCommand.ExecuteNonQuery();

           conn.Close();
       }

       public static void modifyGamesGenres(String sign)
       {
           int gameGenre = 0;

           sqlCommand = new SqlCommand("Select genre from Games where Id = @ID", conn);
           sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
           sqlCommand.Parameters["@ID"].Value = objectId;

           conn.Open();
           SqlDataReader sqlReader = sqlCommand.ExecuteReader();

           while (sqlReader.Read())
           {
               gameGenre = int.Parse(sqlReader[0].ToString());

           }

           conn.Close();
           int genreNumber1, genreNumber2;
           string genreName1, genreName2;

           if (gameGenre >= 10)
           {
               genreNumber1 = gameGenre / 10;
               genreNumber2 = gameGenre % 10;
               genreName1 = gamesGenres[genreNumber1 - 1].getGenreName();
               genreName2 = gamesGenres[genreNumber2 - 1].getGenreName();
               sqlCommand = new SqlCommand("Update UserGames set " + genreName1 + " = " + genreName1 + sign + " 1 , " + genreName2 + " = " + genreName2 + sign + "1  Where UserId = @userId", conn);

           }
           else
           {
               genreName1 = gamesGenres[gameGenre - 1].getGenreName();
               sqlCommand = new SqlCommand("Update UserGames set " + genreName1 + " = " + genreName1 + sign + " 1  where UserId = @userId", conn);
           }
           sqlCommand.Parameters.Add("@userId", SqlDbType.Int);
           sqlCommand.Parameters["@userId"].Value = userId;

           conn.Open();

           sqlCommand.ExecuteNonQuery();
          

           conn.Close();
       }


       public static void insertID()//when the user starts a column will be made for them in the user table of the category they are voting on 
      //checks if the id is there first 
       {
           
           Boolean makeNewColumn = true;
           if (choice == 1)
           {
               type = "Music";

           }
           else if (choice == 2)
           {
               type = "Movies";
           }

           else if (choice == 3)
           {
               type = "Books";

           }
           else if (choice == 4)
           {
               type = "Games";

           }

           SqlCommand sqlCommand = new SqlCommand("Select * FROM User" + type + "  Where UserId = @userId", conn);
           sqlCommand.Parameters.Add("@userId", SqlDbType.Int);
           sqlCommand.Parameters["@userId"].Value = userId;

           conn.Open();
           SqlDataReader sqlReader = sqlCommand.ExecuteReader();
           if (sqlReader.HasRows) { makeNewColumn = false; }

           conn.Close();
           if (makeNewColumn)
           {

               sqlCommand = new SqlCommand("INSERT INTO User" + type + " (UserId) SELECT UserId  From Users Where UserId= @userId", conn);
               sqlCommand.Parameters.Add("@userId", SqlDbType.Int);
               sqlCommand.Parameters["@userId"].Value = userId;

               conn.Open();

               sqlCommand.ExecuteNonQuery();

               conn.Close();

           }
       }

       public static void getUserObject()// takes into account objects that have already been voted on
       {
           if (numOfvotes > 10) { MessageBox.Show("The user saw 10 objects this is where we display the results"); }
           else
           {
               numOfvotes = numOfvotes + 1;
               String name = null;

               String linker = null;


               if (choice == 1)//generates music 
               {
                   type = "Music";
                   linker = "UserMusicLinker";
                   objectId = randomNumber.Next(140) + 1;
                   image = Image.FromFile(@"C:\GaMMBo.Test1\Music_Images\" + objectId + ".jpg");


               }
               else if (choice == 2)//generates Movies
               {
                   type = "Movies";
                   linker = "UserMovieLinker";

                   objectId = randomNumber.Next(135)+ 1;

                   image = Image.FromFile(@"C:\GaMMBo.Test1\Movies_Images\" + objectId + ".jpg");


               }
               else if (choice == 3)//books
               {
                   type = "Books";
                   linker = "UserBookLinker";
                   objectId = randomNumber.Next(120) + 1;
                   image = Image.FromFile(@"C:\GaMMBo.Test1\Books_Images\" + objectId + ".jpg");

               }
               else if (choice == 4)//games
               {
                   type = "Games";
                   linker = "UserGameLinker";
                   objectId = randomNumber.Next(83)+ 1;

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
                   Controller.frmPref.categoryImage.Image = image;
                   sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
                   sqlCommand.Parameters["@ID"].Value = objectId;


                   conn.Open();
                   sqlReader = sqlCommand.ExecuteReader();

                   while (sqlReader.Read())
                   {
                       Controller.frmPref.categoryObjectName.Text = sqlReader[0].ToString();
                       Controller.frmPref.categoryObjectDescription.Text = sqlReader[1].ToString();
                     
                   }
                   conn.Close();
               }


               else
               {
                   getUserObject();
               }


           }
       }

       public static void likeOrdislikeObject(int v, String sign)
       {
           // this method inserts a voted object into the linker tables the parameter v can either be 0 for dislike or 1 for like
           // the sign can either be a + or - for incrementing and decrementing 
           int vote = v;


           if (choice == 1)
           {
               modifyMusicGenres(sign);  // nabil
               type = "Music";
           }
           else if (choice == 2)
           {
               modifyMovieGenres(sign); // nabil
               type = "Movie";
           }
           else if (choice == 3)
           {
               modifyBooksGenres(sign);  // nabil
               type = "Book";
           }
           else if (choice == 4)
           {
               modifyGamesGenres(sign);  // nabil
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

       public static int[] getUserValues()
       {
           int number = 0;

           string type = null;

           int[] local = new int[9];

           if (choice == 1)
           {
               type = "Music";
               number = 7;
           }
           else if (choice == 2)
           {
               type = "Movies";
               number = 6;
           }
           else if (choice == 3)
           {
               type = "Books";
               number = 9;
           }
           else
           {
               type = "Games";
               number = 6;
           }


           sqlCommand = new SqlCommand("Select * from User" + type + " where userID = @userID", conn);
           sqlCommand.Parameters.Add("@userId", SqlDbType.Int);
           sqlCommand.Parameters["@userId"].Value = userId;

           conn.Open();
           SqlDataReader sqlReader = sqlCommand.ExecuteReader();

           while (sqlReader.Read())
           {

               // 1-10 to avoid user id #
               for (int i = 1; i < 10; i++)
               {
                   if (i <= number)
                   {
                       local[i-1] = int.Parse(sqlReader[i].ToString());
                   }
                   else 
                   {
                       local[i-1] = 0;
                   }
               }
           }

           conn.Close();
           return local;

       }

       public static int[] getObjectValue(int num)
       {

           int objectGenre = 0;
           //int objectID = num;
           string type = null;

           int[] local = new int[9];

           if (choice == 1)
           {
               type = "Music";
           }
           else if (choice == 2)
           {
               type = "Movies";
           }
           else if (choice == 3)
           {
               type = "Books";
           }
           else
           {
               type = "Games";
           }


           sqlCommand = new SqlCommand("Select genre from " + type + " where Id = @ID", conn);
           sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
           sqlCommand.Parameters["@ID"].Value = num;

           conn.Open();
           SqlDataReader sqlReader = sqlCommand.ExecuteReader();

           while (sqlReader.Read())
           {
               objectGenre = int.Parse(sqlReader[0].ToString());

           }

           conn.Close();

           int genreNumber1, genreNumber2;

           if (objectGenre >= 10)
           {
               genreNumber1 = objectGenre / 10;
               genreNumber2 = objectGenre % 10;

               for (int i = 0; i < 9; i++)
               {
                   if (i == (genreNumber1 - 1) || i == (genreNumber2 - 1))
                   {
                       local[i] = 1;
                   }
                   else
                   {
                       local[i] = 0;
                   }
               }

           }
           else
           {
               genreNumber1 = objectGenre;

               for (int i = 0; i < 9; i++)
               {
                   if (i == (genreNumber1 - 1))
                   {
                       local[i] = 1;
                   }
                   else
                   {
                       local[i] = 0;
                   }
               }
               
           }
           
           conn.Open();

           sqlCommand.ExecuteNonQuery();

           conn.Close();

           return local;
       }

       // peeks into Linker table to see if object has been voted on or not
       // returns true for voted and false for not voted
       public static bool getVisibility()
       {
            
            String voteValue = null;
            String linker = null;


            if (choice == 1)//generates music 
            {
                type = "Music";
                linker = "UserMusicLinker";
                
            }
            else if (choice == 2)//generates Movies
            {
                type = "Movies";
                linker = "UserMovieLinker";

            }
            else if (choice == 3)//books
            {
                type = "Books";
                linker = "UserBookLinker";
                
            }
            else
            {
                type = "Games";
                linker = "UserGameLinker";
                
            }//this sql command checks if that particular object and user is in the specific linker table 

            sqlCommand = new SqlCommand("Select Voted From " + linker +
                                       " Where " + type + "Id = @ID AND UserId = @UID", conn);

            sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
            sqlCommand.Parameters["@ID"].Value = objectId;
            sqlCommand.Parameters.Add("@UID", SqlDbType.Int);
            sqlCommand.Parameters["@UID"].Value = userId;

            conn.Open();
            SqlDataReader sqlReader = sqlCommand.ExecuteReader();

            while (sqlReader.Read())
            {
                voteValue = sqlReader[0].ToString();
            }

            conn.Close();

            if (voteValue == "null")
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
    }
}
