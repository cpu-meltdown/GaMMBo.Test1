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
    public partial class ResultsForm : Form
    {
        public static int[] categoryIds;
        public ResultsForm()
        {

            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            categoryIds = Searching.topTenSearch();
            loadResults(categoryIds);
                
        }



        public static void loadResults(int[] categoryIds)
        {

            String catName = "";
            //Controller.catName = "Movies";
            //catName = Controller.catName + "_Images";

            switch (Proxy.choice)
            {
                case 1:
                    catName = "Movies_Images";
                    break;
                case 2:
                    catName = "Music_Images";
                    break;
                case 3:
                    catName = "Books_Images";
                    break;
                case 4:
                    catName = "Games_Images";
                    break;
            }


            Controller.frmResults.top1.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[0].ToString() + ".jpg");
            Controller.frmResults.top2.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[1].ToString() + ".jpg");
            Controller.frmResults.top3.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[2].ToString() + ".jpg");
            Controller.frmResults.top4.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[3].ToString() + ".jpg");
            Controller.frmResults.top5.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[4].ToString() + ".jpg");
            Controller.frmResults.top6.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[5].ToString() + ".jpg");
            Controller.frmResults.top7.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[6].ToString() + ".jpg");
            Controller.frmResults.top8.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[7].ToString() + ".jpg");
            Controller.frmResults.top9.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[8].ToString() + ".jpg");
            Controller.frmResults.top10.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[9].ToString() + ".jpg");


        }

        public static void getResultDetails(int resultId, PictureBox pic)
        {

            SqlConnection conn = new SqlConnection(Properties.Settings.Default.CategoriesConnectionString);
            //SqlCommand sqlCommand = new SqlCommand("Select Album, Description from Music where ID = @ID", conn);
            SqlCommand getResults = new SqlCommand("Select Name, Description from " + Controller.catName + " where ID = @ID", conn);
            getResults.Parameters.Add("@ID", SqlDbType.Int);
            getResults.Parameters["@ID"].Value = resultId;

            try { conn.Open(); }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }

            SqlDataReader sqlReader = getResults.ExecuteReader();

            while (sqlReader.Read())
            {
                Controller.frmPref.categoryObjectName.Text = sqlReader[0].ToString();
                Controller.frmPref.categoryObjectDescription.Text = sqlReader[1].ToString();

                //categoryImage.Image = Image.FromFile(@"C:\GaMMBo.Test1\Music_Images\" + musicId + ".jpg");
            }
            conn.Close();

            Controller.frmPref.btnLike.Visible = false;
            Controller.frmPref.btnDislike.Visible = false;
            Controller.frmPref.btnSkip.Visible = false;
            Controller.frmPref.categoryImage.Image = pic.Image;
            Controller.frmPref.Show();


        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Controller.frmResults.Hide();
            Controller.frmCategories.Show();
        }


        private void top1_Click(object sender, EventArgs e)
        {
            getResultDetails(categoryIds[0], top1);
        }

        private void top2_Click(object sender, EventArgs e)
        {
            getResultDetails(categoryIds[1], top2);
        }

        private void top3_Click(object sender, EventArgs e)
        {
            getResultDetails(categoryIds[2], top3);
        }

        private void top4_Click(object sender, EventArgs e)
        {
            getResultDetails(categoryIds[3], top4);
        }

        private void top5_Click(object sender, EventArgs e)
        {
            getResultDetails(categoryIds[4], top5);
        }

        private void top6_Click(object sender, EventArgs e)
        {
            getResultDetails(categoryIds[5], top6);
        }

        private void top7_Click(object sender, EventArgs e)
        {
            getResultDetails(categoryIds[6], top7);
        }

        private void top8_Click(object sender, EventArgs e)
        {
            getResultDetails(categoryIds[7], top8);
        }

        private void top9_Click(object sender, EventArgs e)
        {
            getResultDetails(categoryIds[8], top9);
        }

        private void top10_Click(object sender, EventArgs e)
        {
            getResultDetails(categoryIds[9], top10);
        }

        
    }
}
