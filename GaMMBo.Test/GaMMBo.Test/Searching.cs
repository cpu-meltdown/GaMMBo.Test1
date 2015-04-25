using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaMMBo.Test
{
    public class Searching
    {
        public static int musicSize = 140;
        public static int movieSize = 135;
        public static int bookSize = 120;
        public static int gameSize = 83;


        // if they have then we go onto the user and get all attribute values
        // then collect moves that have not been seen by this user
        // then compare those movies to the user attributes and get a value
        // then sort the movies based on the values given
        // selection is the value 1-4 to delegate which catagory currently in
        public static int[] topTenSearch()
        {

            int[] arrayID = new int[10];
            int[] arrayValue = new int[10];
            int[] userPreferences = new int[10];
            int[] objectAttributes = new int[10];
            int size = 0;


            // music search loops
            if (Proxy.choice == 1)
            {
                size = musicSize;
            }
            else if (Proxy.choice == 2)
            {
                size = movieSize;
            }
            else if (Proxy.choice == 3)
            {
                size = bookSize;
            }
            else
            {
                size = gameSize;
            }

            // get user data
            userPreferences = Proxy.getUserValues();


            // this loop enters the many many to check visibility of each movie
            for (int i = 1; i < size + 1; i++)
            {


                //if the user has voted on this movie we do not want to add it to the results
                if (Proxy.getVisibility() != true)
                {

                    objectAttributes = Proxy.getObjectValue(i);
                    int value = 0;

                    // 9 is used here because 9 is the maximum length of these arrays
                    for (int z = 0; z < 9; z++)
                    {
                        value += objectAttributes[z] * userPreferences[z];
                    }


                    // selection sort the following new item into the final array
                    if (value > arrayValue[9])
                    {
                        arrayID[9] = i;
                        arrayValue[9] = value;

                        for (int j = 9; j > 0; j--)
                        {
                            if (arrayValue[j] > arrayValue[j - 1])
                            {
                                int tempValue = arrayValue[j];
                                int tempID = arrayID[j];

                                arrayValue[j] = arrayValue[j - 1];
                                arrayID[j] = arrayID[j - 1];

                                arrayValue[j - 1] = tempValue;
                                arrayID[j - 1] = tempID;

                            }
                        }
                    }
                }
            }

            return arrayID;
        }










    }
}
