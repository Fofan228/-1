using System;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

namespace DZ
{
    class Program
    {
         public static void WriteUPandDownWalls(int maxLength, char beginWall, char indentWall, char endWall)
        {
            Console.Write(beginWall);
            for (int i = 0; i < maxLength; i++)
                Console.Write(indentWall);
            Console.WriteLine(endWall);
        }

        public static void WriteMidlleWalls(int maxLength, char beginWall, char indentWall, char endWall, string result)
        {
            Console.Write(beginWall);
            Console.Write(indentWall);
            Console.Write(result);
            
            int imitation = maxLength - result.Length - 1;
            for (int i = 0; i < imitation; i++)
                Console.Write(indentWall);

            Console.WriteLine(endWall);
        }


        static int GetMaxLength(int result)
        {
            string max = result.ToString();
            return max.Length;
        }
        static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");

            int input = int.Parse(Console.ReadLine());
            int result = Factorial(input);
            int maxLength = GetMaxLength(result) + 2;
            string str = Convert.ToString(result);

            WriteUPandDownWalls(maxLength, '╔', '═', '╗');
            WriteUPandDownWalls(maxLength, '║', ' ', '║');
         
                WriteMidlleWalls(maxLength, '║', ' ', '║', str);

            WriteUPandDownWalls(maxLength, '║', ' ', '║');
            WriteUPandDownWalls(maxLength, '╚', '═', '╝');

        }
    }
}
