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
    public partial class SearchMenu : Form
    {

        public void displayMusicGenres(){
            this.searchRadioButton1.Text = "Rap";
            this.searchRadioButton2.Text = "Pop";
            this.searchRadioButton3.Text = "Country";
            this.searchRadioButton4.Text = "Metal";
            this.searchRadioButton5.Text = "Hip Hop";
            this.searchRadioButton6.Text = "Rock";
            this.searchRadioButton7.Visible = false;
        }

        public void displayMoviesGenres() {
            this.searchRadioButton1.Text = "Thriller";
            this.searchRadioButton2.Text = "Comedy";
            this.searchRadioButton3.Text = "Fantasy";
            this.searchRadioButton4.Text = "Action";
            this.searchRadioButton5.Text = "Romance";
            this.searchRadioButton6.Text = "Drama";
            this.searchRadioButton7.Visible = false;
        }

        public void displayBooksGenres() {
            searchRadioButton1.Text = "Romance";
            searchRadioButton2.Text = "Fantasy";
            searchRadioButton3.Text = "Thriller";
            searchRadioButton4.Text = "Mystery";
            searchRadioButton5.Text = "Novel";
            searchRadioButton6.Text = "Fiction";
            searchRadioButton7.Text = "Science";
        }
        //Will fix genres depending on what category the user chose
        public void displayCategoryGenres(char categoryType) {
            switch (categoryType) {
                case '1':
                    displayMusicGenres();
                    break;
                case '2':
                    displayMoviesGenres();
                    break;
                case '3':
                    displayBooksGenres();
                    break;
                case '4':
                    break;
            }
            this.ShowDialog();
        }
        public SearchMenu()
        {
            InitializeComponent();
        }

        private void SearchMenu_Load(object sender, EventArgs e)
        {

        }

        private void searchMenuBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.ShowDialog();
        }
    }
}
