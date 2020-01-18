using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shapes
    {
        private double Height { get; }

        private double Width { get; }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public override double CalculateParameter()
        {
            return (2 * Height) + (2 * Width);
        }

        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
