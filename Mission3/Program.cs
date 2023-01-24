using System;

namespace Mission3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome users to game
            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            //Create board game array to store game plays
            char[,] boardArray = new char[3, 3];
  
            bool continueGame = true;

            while (continueGame == true)
            {
                //print board

                //player 1 takes turn
                Console.WriteLine("Player 1: Choose your spot. A-C represent columns, and 1-3 represent rows. (A1 is top left, A2 is middle left, and B3 is the third row in the middle)");
                Console.WriteLine("Choose a column (A-C):");
                string columnInput = Console.ReadLine();
                Console.WriteLine("Choose a row (1-3):");
                int rowInput = Convert.ToInt32(Console.ReadLine());

                //update array
                if (columnInput == "A")
                {
                    if (rowInput == 1)
                    {
                        if  (boardArray[0,0] == ' ')
                        {

                        }
                        boardArray[0, 0] = 'X';
                    }
                    else if (rowInput == 2)
                    {
                        boardArray[0, 1] = 'X';
                    }
                    else
                    {
                        boardArray[0, 2] = 'X';
                    }
                }
                else if (columnInput == "B")
                {
                    if (rowInput == 1)
                    {
                        boardArray[1, 0] = 'X';
                    }
                    else if (rowInput == 2)
                    {
                        boardArray[1, 1] = 'X';
                    }
                    else
                    {
                        boardArray[1, 2] = 'X';
                    }
                }
                else
                {
                    if (rowInput == 1)
                    {
                        boardArray[2, 0] = 'X';
                    }
                    else if (rowInput == 2)
                    {
                        boardArray[2, 1] = 'X';
                    }
                    else
                    {
                        boardArray[2, 2] = 'X';
                    }
                }

                //update board & call supporting class

                //Check to see if player1 won

                //player 2

                //update array
                if (columnInput == "A")
                {
                    if (rowInput == 1)
                    {
                        boardArray[0, 0] = 'O';
                    }
                    else if (rowInput == 2)
                    {
                        boardArray[0, 1] = 'O';
                    }
                    else
                    {
                        boardArray[0, 2] = 'O';
                    }
                }
                else if (columnInput == "O")
                {
                    if (rowInput == 1)
                    {
                        boardArray[1, 0] = 'O';
                    }
                    else if (rowInput == 2)
                    {
                        boardArray[1, 1] = 'O';
                    }
                    else
                    {
                        boardArray[1, 2] = 'O';
                    }
                }
                else
                {
                    if (rowInput == 1)
                    {
                        boardArray[2, 0] = 'O';
                    }
                    else if (rowInput == 2)
                    {
                        boardArray[2, 1] = 'O';
                    }
                    else
                    {
                        boardArray[2, 2] = 'O';
                    }
                }
                //update board & call supporting class
            }

            //Call method to announce winner


        }
    }
}
