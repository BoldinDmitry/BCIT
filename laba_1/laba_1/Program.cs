using System;

namespace laba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Болдин Дмитрий ИУ5-35Б";

            Rectangle rectangle = new Rectangle(40, 50);
            rectangle.Print();

            Square square = new Square(100);
            square.Print();

            Circle circle = new Circle(450);
            circle.Print();
            Console.ReadLine();
        }
    }
}
