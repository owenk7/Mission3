using System;

namespace Mission3
{

	public class SupportingTools
	{
		public void PrintBoard(char arr)
		{
			Console.WriteLine("		|		|		");
			Console.WriteLine("	  {0}	|   {1}	|   {2}", arr[1], arr[2], arr[3]);
			Console.WriteLine("_____|_______|_______");
			Console.WriteLine("		|		|		");
			Console.WriteLine("	  {0}	|   {1}	|   {2}", arr[4], arr[5], arr[6]);
			Console.WriteLine("_____|_______|_______");
			Console.WriteLine("		|		|		");
			Console.WriteLine("	  {0}	|   {1}	|   {2}", arr[7], arr[8], arr[9]);
			Console.WriteLine("		|		|		");
		}
	}
}