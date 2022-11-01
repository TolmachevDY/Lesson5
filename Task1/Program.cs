using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа массива");
            int[] arrey = new int[7];
            int s=0;
            int k=0;
            for (int i = 0; i < 7; i++)
            {
                arrey[i]=Convert.ToInt32(Console.ReadLine());
                s += arrey[i];
                k++;
            }
            Console.WriteLine("Среднее арифметическое равно {0:f3}",((double)s)/k);
            Console.ReadKey();
        }
    }
}
