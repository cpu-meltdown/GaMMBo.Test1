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

    public partial class SearchForm : Form
    {
        public string entered;
        string genreName;
        public SearchForm()
        {
           // Proxy.initializeGenres(Controller.frmPref.choice, Controller.frmPref.userId);
            Proxy.initializeGenres(Proxy.choice, Proxy.userId);
            InitializeComponent();
        }

        private void searchByNameButton_Click(object sender, EventArgs e)
        {
            if (Controller.frmSearch.searchFormLabel1.Text.Trim() == "")
                MessageBox.Show("Check your input please.");
            else
            {
                searchFormDropBox.Items.Clear();
                Proxy.searchByName(Controller.frmSearch.searchFormTextBox.Text);
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            
            if (Proxy.choice == 1)
            {
                this.BackColor = System.Drawing.Color.LightBlue;
                searchFormDropBox.Items.Add("Rap");
                searchFormDropBox.Items.Add("Rock");
                searchFormDropBox.Items.Add("Hip Hop");
                searchFormDropBox.Items.Add("Country");
                searchFormDropBox.Items.Add("Metal");
                searchFormDropBox.Items.Add("Pop");
                searchFormDropBox.Items.Add("Electronic");

            }
            else if (Proxy.choice == 2)
            {
                this.BackColor = System.Drawing.Color.LightPink;
                searchFormDropBox.Items.Add("Comedy");
                searchFormDropBox.Items.Add("Thriller");
                searchFormDropBox.Items.Add("Fantasy");
                searchFormDropBox.Items.Add("Action");
                searchFormDropBox.Items.Add("Romance");

            }

            else if (Proxy.choice == 3)
            {
                this.BackColor = System.Drawing.Color.LightGreen;
                searchFormDropBox.Items.Add("Romance");
                searchFormDropBox.Items.Add("Fantasy");
                searchFormDropBox.Items.Add("Mystery");
                searchFormDropBox.Items.Add("Thriller");
                searchFormDropBox.Items.Add("Science");
                searchFormDropBox.Items.Add("Fiction");
                searchFormDropBox.Items.Add("Novel");
                searchFormDropBox.Items.Add("Autobiography");
                searchFormDropBox.Items.Add("Young Adult");

            }
            else if (Proxy.choice == 4)
            {
                this.BackColor = System.Drawing.Color.LightYellow;
                searchFormDropBox.Items.Add("Strategy");
                searchFormDropBox.Items.Add("Sports");
                searchFormDropBox.Items.Add("Adventure");
                searchFormDropBox.Items.Add("Fighting");
                searchFormDropBox.Items.Add("Racing");
                searchFormDropBox.Items.Add("RPG");

            }

            searchFormTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchFormTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection catObjects = new AutoCompleteStringCollection();

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.CategoriesConnectionString);
            SqlCommand auto = new SqlCommand("Select Name from " + Controller.catName + " where Name like @name", conn);
            auto.Parameters.Add("@name", SqlDbType.NVarChar);
            auto.Parameters["@name"].Value = entered + "%";
            conn.Open();

            SqlDataReader sqlReader = auto.ExecuteReader();

            while (sqlReader.Read())
            {
                catObjects.Add(sqlReader[0].ToString());
            }

            searchFormTextBox.AutoCompleteCustomSource = catObjects;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            genreName = searchFormDropBox.Text;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {   
            int genreNum = 0;
       
            int[] resultId = new int[5];
            if (genreName == null) { MessageBox.Show("Please select a genre then click go"); }
            else
            {
                genreNum = Proxy.getGenreNumber(genreName) ;

                resultId = Proxy.getGenreObjects(genreNum);
                GenreResultsForm.setGenreArray(resultId);
                GenreResultsForm.setPictureBoxes();
                searchFormDropBox.Text = "";
                searchFormDropBox.Items.Clear();
                Controller.frmSearch.Hide();
                Controller.genreForm.ShowDialog();
            
            }
        }

        private void searchFormBackButton_Click(object sender, EventArgs e)
        {
            Controller.frmSearch.Hide();
            Controller.frmCategories.Show();
            entered = "";
        }

        private void searchFormTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            entered = searchFormTextBox.Text;
        }

        private void searchFormTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
