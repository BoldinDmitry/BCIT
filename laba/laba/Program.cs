using System;
namespace laba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Болдин Дмитрий ИУ5-35Б";
            Console.WriteLine("Введите коэффиценты");

            double a = ReadDouble("А: ");
            double b = ReadDouble("B: ");
            double c = ReadDouble("C: ");
            if (a == 0 && b != 0)
            {
                double root = (-1 * c) / b;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Корень: " + root);
            }
            else if (a != 0)
            {
                double d = Math.Pow(b, 2) - 4 * a * c;
                Console.WriteLine("Дискриминант равен " + d);

                if (d > 0)
                {
                    double root_1 = (-1 * b + Math.Sqrt(d)) / (2 * a);
                    double root_2 = (-1 * b - Math.Sqrt(d)) / (2 * a);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Первый корень: " + root_1);
                    Console.WriteLine("Второй корень: " + root_2);
                }
                else if (d == 0)
                {
                    double root = (b + Math.Sqrt(d)) / (2 * a);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни одинаковые: " + root);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней нет");
                }
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Оба коэффициента при х равны нулю");
            }
            Console.ReadLine();
        }

        static double ReadDouble(string consoleMessage)
        {
            string resultString;
            double resultDouble;
            bool flag;
            do
            {
                Console.Write(consoleMessage);

                resultString = Console.ReadLine();
                if (!(flag = double.TryParse(resultString, out resultDouble)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неправильные данные");
                    Console.ResetColor();
                }
            }
            while (!flag);

            return resultDouble;
        }
    }
}
