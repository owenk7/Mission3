using System;

namespace Mission3
{
    class Program
    {
        public static void Main(string[] args)
        {
            static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            SupportingTools st = new SupportingTools();

            st.PrintBoard(arr);

        }
    }
}
