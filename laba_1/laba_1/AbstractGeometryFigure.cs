using System;
namespace laba_1
{
    abstract public class AbstractGeometricFigure
    {
        public string Type
        {
            get
            {
                return this.figure_type;
            }
            protected set
            {
                this.figure_type = value;
            }
        }
        private string figure_type;
        public abstract double Area();
        public override string ToString()
        {
            return "Фигура - " + this.Type + " S =  " + this.Area().ToString();
        }
    }
}
