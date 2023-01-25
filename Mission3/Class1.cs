using System;
namespace Mission3
{
	public class SupportingTools
	{
		public void PrintBoard(char[] arrayBoard)
		{
            Console.WriteLine("       |     |      ");
            Console.WriteLine("    {0}  |  {1}  |  {2}", arrayBoard[0], arrayBoard[1], arrayBoard[2]);
            Console.WriteLine("  _____|_____|_____ ");
            Console.WriteLine("       |     |      ");
            Console.WriteLine("    {0}  |  {1}  |  {2}", arrayBoard[3], arrayBoard[4], arrayBoard[5]);
            Console.WriteLine("  _____|_____|_____ ");
            Console.WriteLine("       |     |      ");
            Console.WriteLine("    {0}  |  {1}  |  {2}", arrayBoard[6], arrayBoard[7], arrayBoard[8]);
            Console.WriteLine("       |     |      ");
        }

        public int CheckWin(char[] arrayBoard)
        {
            
            // first row
            if (arrayBoard[0] == arrayBoard[1] && arrayBoard[1] == arrayBoard[2])
            {
                return 1;
            }
            // second row
            else if (arrayBoard[3] == arrayBoard[4] && arrayBoard[4] == arrayBoard[5])
            {
                return 1;
            }
            // third row
            else if (arrayBoard[6] == arrayBoard[7] && arrayBoard[7] == arrayBoard[8])
            {
                return 1;
            }

            // first column
            else if (arrayBoard[0] == arrayBoard[3] && arrayBoard[3] == arrayBoard[6])
            {
                return 1;
            }
            // second column
            else if (arrayBoard[1] == arrayBoard[4] && arrayBoard[4] == arrayBoard[7])
            {
                return 1;
            }
            // third column
            else if (arrayBoard[2] == arrayBoard[5] && arrayBoard[5] == arrayBoard[8])
            {
                return 1;
            }

            // diagonal
            else if (arrayBoard[0] == arrayBoard[4] && arrayBoard[4] == arrayBoard[8])
            {
                return 1;
            }
            else if (arrayBoard[2] == arrayBoard[4] && arrayBoard[4] == arrayBoard[6])
            {
                return 1;
            }

            // Draw
            else if (arrayBoard[0] != '1' && arrayBoard[1] != '2' && arrayBoard[2] != '3' && arrayBoard[3] != '4' && arrayBoard[4] != '5' && arrayBoard[5] != '6' && arrayBoard[6] != '7' && arrayBoard[7] != '8' && arrayBoard[8] != '9')
            {
                return -1;
            }
            
            else
            {
                return 0;
            }
        }

    }
}
