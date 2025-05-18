using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Area_and_Perimeter_Calculator.Helper;
using Area_and_Perimeter_Calculator.Model;

namespace Area_and_Perimeter_Calculator.Logic
{

    public static class DimensionService
    {
        public static (double?, double?, double?) GetDimensionsForArea(string shape)
        {
            double? dimension1 = null;
            double? dimension2 = null;
            double? dimension3 = null;

            switch (shape)
            {
                case "1": // Rectangle
                    var input1 = InputHelper.GetValidation("Enter the length of the rectangle:");
                    if (input1.IsExit) Environment.Exit(0);
                    dimension1 = input1.Value;

                    var input2 = InputHelper.GetValidation("Enter the width of the rectangle:");
                    if (input2.IsExit) Environment.Exit(0);
                    dimension2 = input2.Value;
                    break;

                case "2": // Circle
                    var input3 = InputHelper.GetValidation("Enter the radius of the circle:");
                    if (input3.IsExit) Environment.Exit(0);
                    dimension1 = input3.Value;
                    break;

                case "3": // Triangle
                    var input4 = InputHelper.GetValidation("Enter the base of the triangle:");
                    if (input4.IsExit) Environment.Exit(0);
                    dimension1 = input4.Value;

                    var input5 = InputHelper.GetValidation("Enter the height of the triangle:");
                    if (input5.IsExit) Environment.Exit(0);
                    dimension2 = input5.Value;
                    break;

                case "4": // Square
                    var input6 = InputHelper.GetValidation("Enter the side length of the square:");
                    if (input6.IsExit) Environment.Exit(0);
                    dimension1 = input6.Value;
                    break;

                default:
                    Console.WriteLine("Invalid shape choice. Please try again.");
                    break;
            }

            return (dimension1, dimension2, dimension3);
        }

        public static (double?, double?, double?) GetDimensionsForPerimeter(string shape)
        {
            double? dimension1 = null;
            double? dimension2 = null;
            double? dimension3 = null;

            switch (shape)
            {
                case "1": // Rectangle
                    var input1 = InputHelper.GetValidation("Enter the length of the rectangle:");
                    if (input1.IsExit) Environment.Exit(0);
                    dimension1 = input1.Value;

                    var input2 = InputHelper.GetValidation("Enter the width of the rectangle:");
                    if (input2.IsExit) Environment.Exit(0);
                    dimension2 = input2.Value;
                    break;

                case "2": // Circle
                    var input3 = InputHelper.GetValidation("Enter the radius of the circle:");
                    if (input3.IsExit) Environment.Exit(0);
                    dimension1 = input3.Value;
                    break;

                case "3": // Triangle
                    var input4 = InputHelper.GetValidation("Enter the side 1 of the triangle:");
                    if (input4.IsExit) Environment.Exit(0);
                    dimension1 = input4.Value;

                    var input5 = InputHelper.GetValidation("Enter the side 2 of the triangle:");
                    if (input5.IsExit) Environment.Exit(0);
                    dimension2 = input5.Value;

                    var input6 = InputHelper.GetValidation("Enter the side 3 of the triangle:");
                    if (input6.IsExit) Environment.Exit(0);
                    dimension3 = input6.Value;
                    break;

                case "4": // Square
                    var input7 = InputHelper.GetValidation("Enter the side length of the square:");
                    if (input7.IsExit) Environment.Exit(0);
                    dimension1 = input7.Value;
                    break;

                default:
                    Console.WriteLine("Invalid shape choice. Please try again.");
                    break;
            }

            return (dimension1, dimension2, dimension3);
        }
    }

}
