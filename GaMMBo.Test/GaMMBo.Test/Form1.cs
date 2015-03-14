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

            SqlCommand selectCommand = new SqlCommand("select Artist, Album, Year from Music Order By Year", conn);

            conn.Open();
            SqlDataReader reader = selectCommand.ExecuteReader();

            string selectedMovies = string.Empty;

            while (reader.Read() == true)
            {
                selectedMovies += "Artist: " + reader[0] + " Album: " + reader[1] + " Year: "+ reader[2] +"\n";
            }
            // test can you guys see this
            MessageBox.Show(selectedMovies);
            conn.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.ShowDialog();
            
        }
    }
}
