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
    //needs for limit to be set


    public partial class PrefMenu : Form
    {



        public int skipNum = 0;// variable that keeps track how many times the user skips
        public int choice;// variable keeps track of what category is being accessed
        public int objectId;//the id of the object being voted on
        public int userId = Proxy.userId;//if the voting being done is by a user their id is stored in this variable its set to 4 only so i could test 
        // when the user logs in the number will be sent here like the choice 
       

        public Boolean userVoting = false;//will be set prior to this point when the user either logs in or clicks guest
        // the rest are self explanatory i may move or remove at the end before i transfer all to proxy

        public PrefMenu()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // like button


            Proxy.likeOrdislikeObject(1, "+");
            Proxy.getUserObject();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proxy.likeOrdislikeObject(0, "-");
            Proxy.getUserObject();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            // skip button limit is set to 5 skips if the user reaches five a message pops up telling them to either like or dislike
            if (skipNum < 5)
            {
                    Proxy.getUserObject();
                

                skipNum = skipNum + 1;
                // return;
            }
            else
            {
                MessageBox.Show("Skip Limit has been reached please either like or dislike");
                // return;

            }

        }


        private void button5_Click(object sender, EventArgs e)
        {
            skipNum = 0;
        



            // CategoriesForm categoriesForm = new CategoriesForm();



            if (btnLike.Visible == false)
            {
                Controller.frmPref.Hide();
                Controller.frmResults.Show();

            }
            else
            {
                Controller.frmPref.Hide();
                Controller.frmCategories.Show();
            }


        }

        private void label1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void PrefMenu_Load(object sender, EventArgs e)
        {

            if (choice == 1)
            {
                this.BackColor = System.Drawing.Color.LightBlue;

            }
            else if (choice == 2)
            {
                this.BackColor = System.Drawing.Color.LightPink;
            }

            else if (choice == 3)
            {
                this.BackColor = System.Drawing.Color.LightGreen;

            }
            else if (choice == 4)
            {
                this.BackColor = System.Drawing.Color.LightYellow;

            }
            Proxy.initializeGenres(Controller.frmPref.choice, Controller.frmPref.userId);
            Proxy.insertID(); // inserts userid into the usertable of the category they are voting on 
        }













    }
}
