using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaMMBo.Test
{
    // this class is the only area in code with access to these tables. 
    // we do not need to worry about passing pictures, we have the id
    // of the object and we can call that seperately in controller.
    class Proxy
    {
        // get 1 specific game. returns values in table
        public void getGame(int x)
        {

        }

        // get 1 specific movie. returns values in table
        public void getMovie(int x)
        {

        }

        // get 1 specific music. returns values in table
        public void getMusic(int x)
        {

        }

        // get 1 specific book. returns values in table
        public void getBook(int x)
        {

        }

        // search many many table for specific user and specific object
        // for visibility of that object
        public void getUserGame(int x, int y)
        {

        }

        // search many many table for specific user and specific object
        // for visibility of that object
        public void getUserMusic(int x, int y)
        {

        }

        // search many many table for specific user and specific object
        // for visibility of that object
        public void getUserMovie(int x, int y)
        {

        }

        // search many many table for specific user and specific object
        // for visibility of that object
        public void getUserBook(int x, int y)
        {

        }
       
    }
}
