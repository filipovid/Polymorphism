using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            

            try
            {
                Console.WriteLine("Input radius for circle: ");
                double radius = double.Parse(Console.ReadLine());
                Circle circle = new Circle(radius);
                Console.WriteLine($"Parameter of circle: {circle.CalculateParameter()}, Area of circle: {circle.CalculateArea()}");

                Console.WriteLine("\nInput height for rectangle:");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine("Input width for rectangle:");
                double width = double.Parse(Console.ReadLine());
                Rectangle rectangle = new Rectangle(height, width);
                Console.WriteLine($"Parameter of rectangle: {rectangle.CalculateParameter()}, Area of rectangle {rectangle.CalculateArea()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
