using System;
namespace laba_1
{
    public class Rectangle : AbstractGeometricFigure, IPrint
    {
        private double height;
        private double width;
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
            this.Type = "Прямоугольник";
        }
        public override double Area()
        {
            return this.width * this.height;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }

}
