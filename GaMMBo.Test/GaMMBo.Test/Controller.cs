using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaMMBo.Test
{

    static class Controller
    {
        // who is logged on
        int userID;

        // entry point of program
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            // buttons call proxy methods directly
            // it seems overly redundant to have methods that call methods


            // searchs will be methods in controller
            public void bestFit()
            {
                // sequence of steps would be 
                    // loop through db
                    // if object has been voted on do not pull
                    // get user attributes
                    // sort based on attributes
                    // return list of attribues
            }

            
        }
    }
}
