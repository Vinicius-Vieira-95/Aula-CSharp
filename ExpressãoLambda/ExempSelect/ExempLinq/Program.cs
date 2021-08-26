using System;
using System.Linq;


namespace ExempLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the date source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Define the query expression
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            // Execute the query

            foreach (int x in result)
            {
                Console.WriteLine(x);
            }

        }
    }
}
