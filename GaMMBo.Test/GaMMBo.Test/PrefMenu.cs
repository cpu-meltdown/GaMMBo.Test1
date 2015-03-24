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

    public partial class PrefMenu : Form
    {
        int choice;
        public PrefMenu(int c)
        {
            InitializeComponent();
            choice = c;
        }

        

       
        //Display random game
        public void displayGame()
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm();
            this.Hide();
            categoriesForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PrefMenu_Load(object sender, EventArgs e)
        {
            Random randomNumber = new Random();
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.CategoriesConnectionString);
           
            if(choice == 1)
            {
                
                SqlCommand sqlCommand = new SqlCommand("Select Album, Description from Music where ID = @ID", conn);
              
                int musicId = randomNumber.Next(141);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
                sqlCommand.Parameters["@ID"].Value = musicId;

                conn.Open();
               SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                while (sqlReader.Read())
                {
                    categoryObjectName.Text = sqlReader[0].ToString();
                    categoryObjectDescription.Text = sqlReader[1].ToString();

                    categoryImage.Image = Image.FromFile(@"C:\Program Files\GaMMBo.Test1\Music_Images\" + musicId + ".jpg");
                }

                conn.Close();
            }
            if (choice == 2)
            {
               
                SqlCommand sqlCommand = new SqlCommand("Select Name, Description from Movies where ID = @ID", conn);
               
                int movieId = randomNumber.Next(136);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
                sqlCommand.Parameters["@ID"].Value = movieId;

                conn.Open();
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                while (sqlReader.Read())
                {
                    categoryObjectName.Text = sqlReader[0].ToString();
                    categoryObjectDescription.Text = sqlReader[1].ToString();

                    categoryImage.Image = Image.FromFile(@"C:\Program Files\GaMMBo.Test1\Movies_Images\" + movieId + ".jpg");
                }

                conn.Close();
            }
            if (choice == 3)
            {
                SqlCommand sqlCommand = new SqlCommand("Select Name,Description from Books where ID = @ID", conn);
             
                int bookId = randomNumber.Next(51);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
                sqlCommand.Parameters["@ID"].Value = bookId;

                conn.Open();
                SqlDataReader sqlReader = sqlCommand.ExecuteReader();

                while (sqlReader.Read())
                {
                    categoryObjectName.Text = sqlReader[0].ToString();
                    categoryObjectDescription.Text = sqlReader[1].ToString();

                    categoryImage.Image = Image.FromFile(@"C:\Program Files\GaMMBo.Test1\Books_Images\" + bookId + ".jpg");
                }

                conn.Close();
            }
            if (choice == 4) { }

            
        }


    }
}
