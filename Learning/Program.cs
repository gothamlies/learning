using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;

            Console.WriteLine("Количество элеметнов");
            n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Массив: ");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 == 0)
                {
                    sum = sum + mas[i];                   
                }
            }

            Console.Write("Чётные: " + sum);

            Console.WriteLine();
        }

    }
}
