using System;
namespace laba_1
{
    public class Circle : AbstractGeometricFigure, IPrint
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
            this.Type = "Круг";
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
