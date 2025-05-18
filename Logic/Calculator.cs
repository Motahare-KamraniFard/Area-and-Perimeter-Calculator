using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Area_and_Perimeter_Calculator.Helper;
using Area_and_Perimeter_Calculator.Model;

namespace Area_and_Perimeter_Calculator.Logic
{
    public class Calculator
    {
        public static void PerimeterSquare((double? dimension1, double? dimension2, double? dimension3) value)
        {
            double? side = value.dimension1;
            double perimeter = 4 * side.Value;
            Console.WriteLine($"The perimeter of the square is: {perimeter}");
        }

        public static void PerimeterCircle((double? dimension1, double? dimension2, double? dimension3) value)
        {
            double? radius = value.dimension1;
            double perimeter = 2 * Math.PI * radius.Value;
            Console.WriteLine($"The perimeter of the circle is: {perimeter}");
        }

        public static void PerimeterTriangle((double? dimension1, double? dimension2, double? dimension3) value)
        {
            double? side1 = value.dimension1;
            double? side2 = value.dimension2;
            double? side3 = value.dimension3;

            double perimeter = side1.Value + side2.Value + side3.Value;
            Console.WriteLine($"The perimeter of the triangle is: {perimeter}");
        }

        public static void PerimeterRectangle((double? dimension1, double? dimension2, double? dimension3) value)
        {
            double? length = value.dimension1;
            double? width = value.dimension2;

            double perimeter = 2 * (length.Value + width.Value);
            Console.WriteLine($"The perimeter of the rectangle is: {perimeter}");

        }

        public static void AreaTriangle((double? dimension1, double? dimension2, double? dimension3) value)
        {
            double? baseLength = value.dimension1;
            double? height = value.dimension2;
            double area = 0.5 * baseLength.Value * height.Value;
            Console.WriteLine($"The area of the triangle is: {area}");
        }

        public static void AreaCircle((double? dimension1, double? dimension2, double? dimension3) value)
        {
            double? radius = value.dimension1;
            double area = Math.PI * Math.Pow(radius.Value, 2);
            Console.WriteLine($"The area of the circle is: {area}");
        }

        public static void AreaRectangle((double? dimension1, double? dimension2, double? dimension3) value)
        {
            double? length = value.dimension1;
            double? width = value.dimension2;
            double area = length.Value * width.Value;
            Console.WriteLine($"The area of the rectangle is: {area}");
        }

        public static void AreaSquare((double? dimension1, double? dimension2, double? dimension3) value)
        {
            double? side = value.dimension1;
            double area = Math.Pow(side.Value, 2);
            Console.WriteLine($"The area of the square is: {area}");
        }
    }
}
