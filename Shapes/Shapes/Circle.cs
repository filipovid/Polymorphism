using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shapes
    {
        private double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateParameter()
        {
            return 2 * Math.PI * Radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override string Draw()
        {
            return base.Draw() + "Circle";
        }
    }
}
