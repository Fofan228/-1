using System;

namespace chess
{
    enum Figure
    {
        Knight, Queen, King, Rook, Bishop, Pawn
    }
    //Конь, король, ферзь, ладья, слон и пешка
    class Program
    {
        static Figure CheckFigure()
        {
            do
            {
                Console.WriteLine("Введите фигуру (начиная от 0 - Конь, 1 - Слон, 2 - Пешка, 3 - Ладья, 4 - Король, 5 - Королева): ");
                string input = Console.ReadLine().ToLower();
                if (input == "0" || input == "knight" || input == "конь")
                    return Figure.Knight;
                else
                if (input == "1" || input == "bishop" || input == "слон")
                    return Figure.Bishop;
                else
                if (input == "2" || input == "pawn" || input == "пешка")
                    return Figure.Pawn;
                else
                if (input == "3" || input == "rook" || input == "ладья")
                    return Figure.Rook;
                else
                if (input == "4" || input == "king" || input == "король")
                    return Figure.King;
                else
                if (input == "5" || input == "queen" || input == "королева")
                    return Figure.Queen;
                else
                    Console.WriteLine("Некорректная фигура!");
            } while (true);
        }
        static bool CheckBoard(string start)
        {
            if (start.Length == 2)
                return start[0] >= 'A' && start[0] <= 'H' && start[1] >= '1' && start[1] <= '8';
            else
                return false;
        }
        static string CheckCoordStart()
        {
            do
            {
                Console.WriteLine("Введите начальное положение фигуры: ");
                string input = Console.ReadLine().ToUpper();
                if (CheckBoard(input))
                    return input;
                else
                    Console.WriteLine("Некорректная координата!");
            } while (true);
        }
        static string CheckCoordEnd()
        {
            do
            {
                Console.WriteLine("Введите конечное положение фигуры: ");
                string input = Console.ReadLine().ToUpper();
                if (CheckBoard(input))
                    return input;
                else
                    Console.WriteLine("Некорректная координата!");
            } while (true);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Figure figure = CheckFigure();

                string start = CheckCoordStart();

                string end = CheckCoordEnd();

                bool correct = false;
                switch (figure)
                {
                    case Figure.Knight:
                        correct = CheckMoveKnightIsCorrect(start, end);
                        break;
                    case Figure.Bishop:
                        correct = CheckMoveBishopIsCorrect(start, end);
                        break;
                    case Figure.Pawn:
                        correct = CheckMovePawnIsCorrect(start, end);
                        break;
                    case Figure.Rook:
                        correct = CheckMoveRookIsCorrect(start, end);
                        break;
                    case Figure.King:
                        correct = CheckMoveKingIsCorrect(start, end);
                        break;
                    case Figure.Queen:
                        correct = CheckMoveQueenIsCorrect(start, end);
                        break;
                }
                if (correct)
                    Console.WriteLine("Ваша фигура ходит правильно.");
                else
                    Console.WriteLine("Данная фигура не может так сходить.");

                Console.ReadKey();
            }
        }
        static bool CheckMoveKnightIsCorrect(string start, string end)
        {
            int startdelt = Math.Abs(end[0] - start[0]);
            int enddelt = Math.Abs(end[1] - start[1]);

            return (startdelt == 1 && enddelt == 2) || (startdelt == 2 && enddelt == 1);
        }
        static bool CheckMoveBishopIsCorrect(string start, string end)
        {
            int startDelt = Math.Abs(end[0] - start[0]);
            int endDelt = Math.Abs(end[1] - start[1]);

            return (startDelt == endDelt) && (startDelt != 0) && (endDelt != 0);
        }
        static bool CheckMovePawnIsCorrect(string start, string end)
        {
            int startDelt = end[0] - start[0];
            int endDelt = end[1] - start[1];

            return startDelt == 0 && endDelt == 1;
        }
        static bool CheckMoveRookIsCorrect(string start, string end)
        {
            int startDelt = Math.Abs(end[0] - start[0]);
            int endDelt = Math.Abs(end[1] - start[1]);

            return (startDelt > 0 && endDelt == 0) || (endDelt > 0 && startDelt == 0);
        }
        static bool CheckMoveKingIsCorrect(string start, string end)
        {
            int startDelt = Math.Abs(end[0] - start[0]);
            int endDelt = Math.Abs(end[1] - start[1]);

            return (startDelt == 1 && endDelt == 1) || (startDelt == 0 && endDelt == 1);
        }
        static bool CheckMoveQueenIsCorrect(string start, string end)
        {
            int startDelt = Math.Abs(end[0] - start[0]);
            int endDelt = Math.Abs(end[1] - start[1]);

            return (startDelt == endDelt && (startDelt != 0) && (endDelt != 0)) || (startDelt > 0 && endDelt == 0) || (endDelt > 0 && startDelt == 0);
        }
    }
}
