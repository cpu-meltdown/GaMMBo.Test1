using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaMMBo.Test
{
    // this class is the only area with access to these tables.
    // this class handles the creation deletion and updating of users.
    // we must be aware that there is a many many table with users also
    class Account
    {
        // creates a new user, new user table
        // returns that new userID
        public void newUser()
        {

        }

        // gets attributes from user table
        // needs userID of who to access
        public void getAttributes(int x)
        {

        }

        // deletes user
        // needs userID of who to delete
        public void deleteUser(int x)
        {

        }

        // looks for user and if successful returns UserID
        // needs name, password
        public void logIn()
        {
         
        }
    }
}
