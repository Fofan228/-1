using Microsoft.VisualBasic;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Lab01_Efimov_Ivan
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            DateTime now = DateTime.Now;
            Console.WriteLine("Здравствуйте!");

            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите номер дня вашего рождения: ");
            string day = Console.ReadLine();
            int d = Convert.ToInt32(day);
            while (d > 31 | d < 1)
                { 
                Console.WriteLine("Данные введены некорректно, повторите попытку.");
                day = Console.ReadLine();
                d = Convert.ToInt32(day); 
                }
            Console.WriteLine("Введите номер месяца вашего рождения: ");
               string month = Console.ReadLine();
                int m = Convert.ToInt32(month);
            while (m > 12 | m < 1)
                {
                Console.WriteLine("Данные введены некорректно, повторите попытку.");
                month = Console.ReadLine();
                m = Convert.ToInt32(month);
                }
            Console.WriteLine("Введите год вашего рождения: ");
               string year = Console.ReadLine();
                int y = Convert.ToInt32(year);
            while (y > 2020 | y < 1897)
            {
                Console.WriteLine("Данные введены некорректно, Вам не может быть больше 123 лет(122 года прожила француженка Жанна Кальман, это максимально достигнутый возраст человеком на наши дни).Пожалуйста, повторите попытку.");
                year = Console.ReadLine();
                y = Convert.ToInt32(year);
            }
                if (m == now.Month)
                if (d > now.Day) { a = now.Year - y - 1; }
                else { a = now.Year - y; }
            else { a = now.Year - y; }
            if (m > now.Month) { a = now.Year - y - 1; }


            Console.WriteLine($"Привет, {name}. Ваш возраст равен: {a}. Приятно познакомиться.");



        }
    }
}
