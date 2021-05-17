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

            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 1; j < mas.Length - i; j++)
                {
                    if (mas[j] < mas[j - 1])
                    {
                        int s = mas[j];
                        mas[j] = mas[j - 1];
                        mas[j - 1] = s;
                    }
                }
          
            }

            Console.WriteLine();
            Console.Write("Отсортированный массив: ");
            Console.Write(mas[0] + "  ");
        }

    }
}
