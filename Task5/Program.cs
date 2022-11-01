using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arrey = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arrey[i, j] = (((i + j) % 2 == 0)) ? 1:0;
                    Console.Write("{0}", arrey[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
