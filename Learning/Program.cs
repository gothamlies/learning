using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Введите число элементов массива");
            n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Числа массива:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }

        }
    }
}
