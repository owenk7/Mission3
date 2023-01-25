using System;

namespace Mission3
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Initiate 
            SupportingTools st = new SupportingTools();

            //Welcome users to game
            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            //Create board game array to store game plays
            char[] boardArray = { '1', '2', '3', '4', '5', '6', '7', '8', '9'};
            int winner = 0;

            st.PrintBoard(boardArray);
            //Continue while loop while coninueGame is true
            bool continueGame = true;

            //initate counter
            int count = 0;
            char mark = 'X';
            char player = '1';
            while (continueGame == true)
            {

                //player takes turn
                if (count % 2 == 0)
                {
                    player = '1';
                }
                else
                {
                    player = '2';
                }
                    
                Console.Write("Player " + player + " make your move (1-9) ");
                string input = Console.ReadLine();


                // see which player is playing
                if (count%2 == 0)
                {
                    mark = 'X';
                }
                else
                {
                    mark = 'O';
                }
                //update array
                if (input == "1")
                {
                    boardArray[0] = mark;
                }
                else if (input == "2")
                {
                    boardArray[1] = mark;
                }
                else if (input == "3")
                {
                    boardArray[2] = mark;
                }
                else if (input == "4")
                {
                    boardArray[3] = mark;
                }
                else if (input == "5")
                {
                    boardArray[4] = mark;
                }
                else if (input == "6")
                {
                    boardArray[5] = mark;
                }
                else if (input == "7")
                {
                    boardArray[6] = mark;
                }
                else if (input == "8")
                {
                    boardArray[7] = mark;
                }
                else
                {
                    boardArray[8] = mark;
                }
                //update board & call supporting class
                st.PrintBoard(boardArray);

                //Check to see if there is a winner
                //call CheckWin method to check winner
                winner = st.CheckWin(boardArray);
                if (winner == 1)
                {
                    Console.WriteLine("~~~~Player " + player + " won the game!~~~~");
                    continueGame = false;
                }
                else if (winner == -1)
                {
                    Console.WriteLine("~~~~You tied!~~~~");
                    continueGame = false;
                }

                //update counter
                count++;
            }

            


        }
    }
}
