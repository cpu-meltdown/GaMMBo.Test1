using System;

public class Search
{

    int[] arrayID;
    int[] arrayValue;

    int movieSize;
    int gameSize;
    int musicSize;
    int bookSize;


    // this code checks to see if any changes have been made to the users preferences with bool change
    // if they have then we go onto the user and get all attribute values
    // then collect moves that have not been seen by this user
    // then compare those movies to the user attributes and get a value
    // then sort the movies based on the values given
	public static void topTenSearchMovie(bool change){
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

        else
        {

            uHorror = Account.getHorror(user);
            uComedy = Account.getComedy(user);

            // this loop enters the many many to check visibility of each movie
            for(int i = 0; i < movieSize; i++){

                // if the user has voted on this movie we do not want to add it to the results
                if (Proxy.voteValueMovie(i, user) == true) { }

                else
                {
                    mHorror = Proxy.getMovieHorror(i);
                    mComedy = Proxy.getMovieComedy(i);


                    value = (mHorror * uHorror) + (mComedy * uComedy);

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
