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
    public partial class MoviesForm : Form
    {
        public MoviesForm()
        {
            InitializeComponent();
        }

        private void moviesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moviesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.categoriesDataSet1);

        }

        private void MoviesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'categoriesDataSet1.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.categoriesDataSet1.Movies);
            SqlConnection conn= new SqlConnection(Properties.Settings.Default.CategoriesConnectionString);
            
            SqlCommand sqlCommand = new SqlCommand("select name, year from Movies where ID = @ID",conn);
            Random randomNumber = new Random();
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
            int movieId = randomNumber.Next(132) + 45;
            sqlCommand.Parameters["@ID"].Value = movieId;

            conn.Open();
            SqlDataReader sqlRerader = sqlCommand.ExecuteReader();
            
            while (sqlRerader.Read()){
                movieNameDisplayBox.Text = sqlRerader[0].ToString();
                movieYearDisplayBox.Text = sqlRerader[1].ToString();

                moviePircutre.Image = Image.FromFile(@"C:\Program Files\GaMMBo.Test1\Movies_Images\" + movieId + ".jpg");
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.ShowDialog();
        }

        private void moviesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
