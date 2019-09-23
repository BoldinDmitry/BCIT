using System;
namespace laba_1
{
    public class Square : Rectangle, IPrint
    {
        private double side;
        public Square(double side) : base(side, side)
        {
            this.Type = "Квадрат";
        }
    }

}
