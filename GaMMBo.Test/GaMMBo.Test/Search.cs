using System;

public class Search
{

    int[] arrayIDMusic;
    int[] arrayIDMovie;
    int[] arrayIDBook;
    int[] arrayIDGame;

    int[] arrayValue;

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
	public static void topTenSearch(bool change, int selection){
        user = controller.loggedOn();
        int value = 0;
        
        arrayID = int[11];
        arrayValue = int[11];

        // uValue is the user value
        // mValue is the movie value
        int uHorror = 0;
        int mHorror = 0;
        int uComedy = 0;
        

        if (change == false){ }

        else if(selection == 1)
        {

            // get user data
            uHorror = Account.getHorror(user);
            uComedy = Account.getComedy(user);

            // this loop enters the many many to check visibility of each movie
            for(int i = 0; i < musicSize; i++){

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
                            if(arrayValue[j] > (arrayValue[j-1])){
                                int tempValue = arrayValue[j];
                                int tempID = arrayID[j];

                            }
                        }
                    }
                }
            }
        }


        else if(selection == 2)
        {

            uHorror = Account.getHorror(user);
            uComedy = Account.getComedy(user);

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
                            if(arrayValue[j] > (arrayValue[j-1])){
                                int tempValue = arrayValue[j];
                                int tempID = arrayID[j];

                            }
                        }
                    }
                }
            }
        }


        else if(selection == 3)
        {

            uHorror = Account.getHorror(user);
            uComedy = Account.getComedy(user);

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
                            if(arrayValue[j] > (arrayValue[j-1])){
                                int tempValue = arrayValue[j];
                                int tempID = arrayID[j];

                            }
                        }
                    }
                }
            }
        }


        else
        {

            uHorror = Account.getHorror(user);
            uComedy = Account.getComedy(user);

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
                            if(arrayValue[j] > (arrayValue[j-1])){
                                int tempValue = arrayValue[j];
                                int tempID = arrayID[j];

                            }
                        }
                    }
                }
            }
        }

    }
	
	
}
