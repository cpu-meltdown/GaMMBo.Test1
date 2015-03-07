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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.CategoriesConnectionString);

            SqlCommand selectCommand = new SqlCommand("select Name, Year from Movies", conn);

            conn.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            string selectedMovies = string.Empty;

            while (reader.Read() == true)
            {
                selectedMovies += "Movie: " + reader[0] + " Year: " + reader[1] + "\n";
            }

            MessageBox.Show(selectedMovies);
            conn.Close();
        }
    }
}
