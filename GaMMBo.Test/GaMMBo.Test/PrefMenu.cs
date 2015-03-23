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
        
        public PrefMenu()
        {
            InitializeComponent();
        }

        //Display random music album
        public void displayMusic(){

        }

        //Display random movie
        public void displayMovie()
        {

        }
        //Display random book
        public void displayBook()
        {

        }
        //Display random game
        public void displayGame()
        {

        }
        // Method to check which category was chosen
        public void displayRandomObject(char categoryType) {
            this.ShowDialog();
            switch (categoryType){
                case '1':
                    displayMusic();
                    break;
                case '2':
                    displayMovie();
                    break;
                case '3':
                    displayBook();
                    break;
                case '4':
                    displayGame();
                    break;
            }
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
            
        }
    }
}
