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
    public partial class MusicForm : Form
    {
        public MusicForm()
        {
            InitializeComponent();
        }

        private void musicBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.musicBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.categoriesDataSet1);

        }

        private void musicForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'categoriesDataSet1.Music' table. You can move, or remove it, as needed.
            this.musicTableAdapter.Fill(this.categoriesDataSet1.Music);
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.CategoriesConnectionString);
            SqlCommand sqlCommand = new SqlCommand("Select artist, album, year from Music where ID = @ID",conn);
            Random randomNumber = new Random();
            int musicId = randomNumber.Next(140) + 1;
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
            sqlCommand.Parameters["@ID"].Value = musicId;

            conn.Open();
            SqlDataReader sqlReader = sqlCommand.ExecuteReader();

            while (sqlReader.Read()){
                musicArtistDisplay.Text = sqlReader[0].ToString();
                musicAlbumDisplay.Text = sqlReader[1].ToString();
                musicYearDisplay.Text = sqlReader[2].ToString();

                musicPicture.Image = Image.FromFile(@"C:\Users\Bassima\Source\Repos\GaMMBo.Test1\Music_Images" + musicId + ".jpg");
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.ShowDialog();
        }
    }
}
