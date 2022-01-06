using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<string> list = new List<string>();

            // adciona de forma ordenada
            list.Add("Vinicius"); 
            list.Add("Ana");
            list.Add("Joao");

            // adciona na posição desejada
            list.Insert(2, "Vitu"); 

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }

            // tamanho da lista
            Console.WriteLine(list.Count);

            // função find
            string name1 = list.Find(x => x[0] == 'A');
            Console.WriteLine(name1);

            string name3 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(name3);

            // função findAll com condições
            List<string> list2 = list.FindAll(x => x.Length > 3);

            foreach (string s in list2)
            {
                Console.WriteLine(s);
            }

            //função remove
            list.Remove("Vitu"); // remove elemento vitu

            list.RemoveAll(x => x[0] == 'V'); // remove todos os elementos começados com V

            list.RemoveRange(1,2); // remove elementos dentro de um range aplicado


            */


            List<Emplyoe> employes = new List<Emplyoe>();

            Console.Write("How many employes will register? ");
            int quant = int.Parse(Console.ReadLine());

            for(int i = 0; i < quant; i++)
            {
                Console.WriteLine("Employer num #"+ i+1);
                Console.Write("Id: ");
                long id = long.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employes.Add(new Emplyoe(id, name, salary));
            }

            Console.Write("Enter the employer id that will have salary increase: ");
            long id2 = long.Parse(Console.ReadLine());

            for (int i = 0; i < employes.Count; i++)
            {
                if(employes[i].Id == id2)
                {
                    Console.WriteLine("Enter with value of increase");
                    employes[i].UpdateSalry(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                }

            }

            Console.WriteLine("Update list of employes:");
            foreach (Emplyoe item in employes)
            {
                Console.WriteLine(item);
            }
        } 
    }
}
