using System;

namespace Laba03
{
    class Program
    {
        static double Fcube(double x)
            {
            double y = x*x*x;
            return y;
            }

        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Введите значение, на которое хотите увеличить x :");
            int step = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите начальную координату x :");
            int X1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечную координату x :");
            int X2 = int.Parse(Console.ReadLine());

            for (int i = X1; i <= X2; i = i + step)
            {
                double y = Fcube(i);
                Console.WriteLine("|--------|--------|");
                Console.WriteLine("Вывод | X | Y |");
                Console.WriteLine("-------------------");
                Console.WriteLine($"Вывод | {i} | {y} |");
            }
        }
    }
}
