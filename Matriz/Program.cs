using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            int tamanho = int.Parse(Console.ReadLine());
            int sum = 0;
            int[,] mat = new int[tamanho, tamanho];

            Console.WriteLine("---------------------------------------");
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));

            Console.WriteLine("---------------------------------------");

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Main diagonal");
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(mat[i,j]);
                    }
                    if( mat[i,j] < 0)
                    {
                        sum += 1;
                    }
                }
            }

            Console.WriteLine("negative number: "+ sum);

        }
    }
}
