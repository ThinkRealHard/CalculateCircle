using System;

namespace CalculateCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the circle calculator.");
            Console.WriteLine("Enter a radius: ");
            string userInput = Console.ReadLine();
            double radius = double.Parse(userInput);
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + Circle.CalcArea(radius));
            Console.WriteLine("The diameter of your circle is: " + Circle.Diameter(radius));
            Console.WriteLine("How many mile to the gallon does your car get? ");
            double mpg = double.Parse(Console.ReadLine());
            while(mpg < 0)
            {
                Console.WriteLine("Please enter a non-negative number.");
                mpg = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("It will take you " + (Circle.Diameter(radius) / mpg) + " gallons of gas to drive around that circle.");
        }
    }

    public class Circle
    {
        public static double CalcArea(double arg)
        {
            return (Math.Pow(arg, 2.0) * Math.PI);
        }

        public static double Diameter(double arg)
        {
            return arg * 2;
        }
    }
}
