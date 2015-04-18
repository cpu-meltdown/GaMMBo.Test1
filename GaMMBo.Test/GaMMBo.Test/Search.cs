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
	public static int[] topTenSearch(bool change, int selection){
        user = controller.loggedOn();
        int value = 0;
        
        arrayID = int[11];
        arrayValue = int[11];
        

        if (change == false){ }

        // music search loops
        else if(selection == 1)
        {

            // get user data
            
            int uMusicCo = Account.getUserComedy();
            int uMusicTh = Account.getUserThriller();
            int uMusicFa = Account.getUserFantasy();
            int uMusicAc = Account.getUserAction();
            int uMucisRo = Account.getUserRomance();
            int uMusicDr = Account.getUserDrama();

            // this loop enters the many many to check visibility of each movie
            for(int i = 0; i < musicSize; i++){

                // if the user has voted on this movie we do not want to add it to the results
                if (Proxy.voteValue(i, user, selection) == true) { }

                else
                {
                    
                    value = (Proxy.getMusicHo(i) * uHorror) + (Proxy.getUserComedy(i) * uComedy);

                    if (value > arrayValue[9])
                    {
                        arrayID[10] = i;
                        arrayValue[10] = value;

                        for(int j = 10; j > 0; j++){
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

        // book search loops
        else if(selection == 3)
        {

            int uBookRo = Account.getUserRomance();
            int uBookFa = Account.getUserFantasy();
            int uBookMy = Account.getUserMystery();
            int uBookTh = Account.getUserThriller();
            int uBookSc = Account.getUserScience();
            int uBookFi = Account.getUserFiction();
            int uBookNo = Account.getUserNovel();
            int uBookAu = Account.getUserAutobiography();
            int uBookYo = Account.getUserYoung();

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

        // games search loops
        else
        {

            int uGameSt = Account.getUserStrategy();
            int uGameSp = Account.getUserSports();
            int uGameAd = Account.getUserAdventure();
            int uGameFi = Account.getUserFighting();
            int uGameRa = Account.getUserRacing();
            int uGameRp = Account.getUserRPG();

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


        return arrayID;

    }


	
	
}
