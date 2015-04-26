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
    public partial class GenreResultsForm : Form
    {
        static int[] categoryIds = new int[5];
        public GenreResultsForm()
        {
           InitializeComponent();
        }

        public static void setGenreArray(int [] cid) 
        {
            categoryIds = cid;
        }

        public static void setPictureBoxes()
        {

            string catName = null;

            if (Proxy.choice == 1)
            {
                
                catName = "Music_Images";
            }
            else if (Proxy.choice == 2)
            {
                catName = "Movies_Images";
            }
            else if (Proxy.choice == 3)
            {
                catName = "Books_Images";
            }
            else if (Proxy.choice == 4)
            {
                catName = "Games_Images";

            }

            Controller.genreForm.result1.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[0].ToString() + ".jpg");

            Controller.genreForm.result2.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[1].ToString() + ".jpg");
            Controller.genreForm.result3.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[2].ToString() + ".jpg");
            Controller.genreForm.result4.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[3].ToString() + ".jpg");
            Controller.genreForm.result5.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[4].ToString() + ".jpg");
        }

        private void GenreResultsForm_Load(object sender, EventArgs e)
        {
            
           
        }

        private void GenreResultsForm_Load_1(object sender, EventArgs e)
        {
            if (Proxy.choice == 1)
            {
                this.BackColor = System.Drawing.Color.LightBlue;


            }
            else if (Proxy.choice == 2)
            {
                this.BackColor = System.Drawing.Color.LightPink;


            }

            else if (Proxy.choice == 3)
            {
                this.BackColor = System.Drawing.Color.LightGreen;

            }
            else if (Proxy.choice == 4)
            {
                this.BackColor = System.Drawing.Color.LightYellow;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.genreForm.Hide();
            Controller.frmCategories.Show();

        }

    }
}
