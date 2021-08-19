using System;
using System.Globalization;
using Contract.Entities;
using Contract.Enums;

namespace Contract
{
    class Program
    {
        public static NumberStyles Culture { get; private set; }

        static void Main(string[] args)
        {

            Console.Write("Emter department's name: ");
            string nameDep = Console.ReadLine();
            Console.Write("enter worker name:");
            string name = Console.ReadLine();
            Console.Write("Level: ");
            WorkerLevel wl = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("BAse salary");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dep = new Department(nameDep, new Worker(name, wl, salary));

            Console.Write("How many contracts to this worker? ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data:");
                Console.Write("Date (DD/MM/YYYY)");
                string[] vet = Console.ReadLine().Split("/");
                
                int day1 = int.Parse(vet[0]);
                int month1 = int.Parse(vet[1]);
                int year = int.Parse(vet[2]);

                DateTime data = new DateTime(year,month1,day1);

                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");    
                int time = int.Parse(Console.ReadLine());

                dep.Worker.addContract(new HourContract(data, value, time));

            }

            Console.Write("Enter month and year to calculate income (MM/YYYY):");
            string[] vetor = Console.ReadLine().Split("/");

            int day = int.Parse(vetor[0]);
            int month = int.Parse(vetor[1]);

            double ren = dep.Worker.income(month, day);
            Console.WriteLine(dep);
            Console.Write("Income for "+ day+"/"+month+": "+ ren.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
