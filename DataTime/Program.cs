using System;

namespace DataTime
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime d1 = new DateTime(2020, 04, 12);
            DateTime d2 = new DateTime(2021, 07, 12, 16, 33, 32);
            DateTime d3 = new DateTime(2021, 07, 12, 16, 30, 54, 550);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            DateTime d7 = DateTime.Parse("2021-08-12"); //formatdo em banco de dados
            DateTime d8 = DateTime.Parse("15/08/2021"); //formato brasileiro

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine(d8);
        }
    }
}
