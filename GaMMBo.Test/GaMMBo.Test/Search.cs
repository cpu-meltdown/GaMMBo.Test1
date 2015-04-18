using System;

public class Search
{

    

    int musicSize;
    int movieSize;
    int bookSize;
    int gamesSize;


    // this code checks to see if any changes have been made to the users preferences with bool change
    // if they have then we go onto the user and get all attribute values
    // then collect moves that have not been seen by this user
    // then compare those movies to the user attributes and get a value
    // then sort the movies based on the values given
    // selection is the value 1-4 to delegate which catagory currently in
	public static int[] topTenSearch(bool change, int selection){
        user = controller.loggedOn();
        int value = 0;
        
        int[] arrayID = new int[10];
        int[] arrayValue = new int[10];
        int[] uMusic = new int[7];
        int[] uMovie = new int[6];
        int[] uBook = new int[9];
        int[] uGame = new int[6];


        // music search loops
        if(selection == 1)
        {

            // get user data
            uMusic = Proxy.getUserValues();


            // this loop enters the many many to check visibility of each movie
            for(int i = 0; i < musicSize; i++){


                // if the user has voted on this movie we do not want to add it to the results
                if (Proxy.voteValue(i, user, selection) == true) { }


                else
                {
                    
                    value = (Proxy.getMusicHo(i) * uHorror) + (Proxy.getUserComedy(i) * uComedy);

                    if (value > arrayValue[9])
                    {
                        arrayID[9] = i;
                        arrayValue[9] = value;

                        for(int j = 9; j > 0; j++){
                            while((arrayValue[j] > (arrayValue[j-1])) && (i > 1)){
                                int tempValue = arrayValue[j];
                                int tempID = arrayID[j];

                                arrayValue[j] = arrayValue[j-1];
                                arrayID[j] = arrayID[j-1];

                                arrayValue[j-1] = tempValue;
                                arrayID[j-1] = tempID;

                            }
                        }
                    }
                }
            }
        }

        // movie search loops
        else if(selection == 2)
        {

            uMovie = Proxy.getUserValues();

            // this loop enters the many many to check visibility of each movie
            for(int i = 0; i < movieSize; i++){

                // if the user has voted on this movie we do not want to add it to the results
                if (Proxy.voteValue(i, user, selection) == true) { }

                else
                {
                    
                    value = (Proxy.getUserHorror(i) * uHorror) + (Proxy.getUserComedy(i) * uComedy);

                    if (value > arrayValue[9])
                    {
                        arrayID[10] = i;
                        arrayValue[10] = value;

                        for(int j = 10; j > 0; j++){
                            while ((arrayValue[j] > (arrayValue[j - 1])) && (i > 1))
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
        }

        // book search loops
        else if(selection == 3)
        {

            uBook = Proxy.getUserValues();

            // this loop enters the many many to check visibility of each movie
            for(int i = 0; i < bookSize; i++){

                // if the user has voted on this movie we do not want to add it to the results
                if (Proxy.voteValue(i, user, selection) == true) { }

                else
                {
                    
                    value = (Proxy.getUserHorror(i) * uHorror) + (Proxy.getUserComedy(i) * uComedy);

                    if (value > arrayValue[9])
                    {
                        arrayID[10] = i;
                        arrayValue[10] = value;

                        for(int j = 10; j > 0; j++){
                            while ((arrayValue[j] > (arrayValue[j - 1])) && (i > 1))
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
        }

        // games search loops
        else
        {

            uGames = Proxy.getUserValues();

            // this loop enters the many many to check visibility of each movie
            for(int i = 0; i < gameSize; i++){

                // if the user has voted on this movie we do not want to add it to the results
                if (Proxy.voteValue(i, user, selection) == true) { }

                else
                {
                    
                    value = (Proxy.getUserHorror(i) * uHorror) + (Proxy.getUserComedy(i) * uComedy);

                    if (value > arrayValue[9])
                    {
                        arrayID[10] = i;
                        arrayValue[10] = value;

                        for(int j = 10; j > 0; j++){
                            while ((arrayValue[j] > (arrayValue[j - 1])) && (i > 1))
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
        }


        return arrayID;

    }


	
	
}
