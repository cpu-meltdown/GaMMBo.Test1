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

        private void GenreResultsForm_Load(object sender, EventArgs e)
        {
            string catName = null;

            MessageBox.Show(categoryIds[1].ToString());
            if (Proxy.choice == 1) 
            {
                catName = "Movies_Images";
            }
            else if (Proxy.choice == 2) 
            {
                catName = "Music_Images";
            }
            else if (Proxy.choice == 3) 
            {
                catName = "Books_Images";
            }
            else if(Proxy.choice == 4)
            
             {
                 catName = "Games_Images";
            
            }

            Controller.genreForm.result1.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[0].ToString() + ".jpg");
           
            Controller.genreForm.result2.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[1].ToString() + ".jpg");
            Controller.genreForm.result3.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[2].ToString() + ".jpg");
            Controller.genreForm.result4.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[3].ToString() + ".jpg");
            Controller.genreForm.result5.Image = Image.FromFile(@"C:\GaMMBo.Test1\" + catName + "\\" + categoryIds[4].ToString() + ".jpg");
           
        }

    }
}
