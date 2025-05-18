using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Area_and_Perimeter_Calculator.Helper;
using Area_and_Perimeter_Calculator.Model;
using Area_and_Perimeter_Calculator.Logic;

namespace Area_and_Perimeter_Calculator
{
    internal class Program
    {
        public static object Try { get; private set; }

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                string shape = getshape();
                if (shape.ToLower() == "exit")
                {
                    running = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                }
                string calculationChoice = getcalculationChoice();

                if (calculationChoice.ToLower() == "exit")
                {
                    running = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                }

                switch (calculationChoice)
                {
                    case "1":
                        Console.WriteLine("You chose to calculate the area.");
                        switch (shape)
                        {
                            case "1":
                                Calculator.AreaRectangle(DimensionService.GetDimensionsForArea(shape));
                                break;
                            case "2":
                                Calculator.AreaCircle(DimensionService.GetDimensionsForArea(shape));
                                break;
                            case "3":
                                Calculator.AreaTriangle(DimensionService.GetDimensionsForArea(shape));
                                break;
                            case "4":
                                Calculator.AreaSquare(DimensionService.GetDimensionsForArea(shape));
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("You chose to calculate the perimeter.");
                        switch (shape)
                        {
                            case "1":
                                Calculator.PerimeterRectangle(DimensionService.GetDimensionsForPerimeter(shape));
                                break;
                            case "2":
                                Calculator.PerimeterCircle(DimensionService.GetDimensionsForPerimeter(shape));
                                break;
                            case "3":
                                Calculator.PerimeterTriangle(DimensionService.GetDimensionsForPerimeter(shape));
                                break;
                            case "4":
                                Calculator.PerimeterSquare(DimensionService.GetDimensionsForPerimeter(shape));
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static string getshape()
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator!");
            Console.WriteLine("Please select a shape to calculate:");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Circle");
            Console.WriteLine("3. Triangle");
            Console.WriteLine("4. Square");
            string shape = Console.ReadLine();
            return (shape);
        }

        public static string getcalculationChoice()
        {
            Console.WriteLine("What do you want to calculate?:");
            Console.WriteLine("1. Area");
            Console.WriteLine("2. Perimeter");
            string calculationChoice = Console.ReadLine();
            return (calculationChoice);
        }

    }

}
