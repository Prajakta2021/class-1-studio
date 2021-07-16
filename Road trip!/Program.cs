using System;

namespace Road_trip_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a radius of circle  : ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a miles per gallon of the car : ");
            double mpg = double.Parse(Console.ReadLine());
            double aroundTheCircle = 2 * Math.PI * radius;                       
            Console.WriteLine("you need " + aroundTheCircle/mpg + " gallons of gas to go around the circle of radius " +radius+ " miles.");
            Console.ReadLine();
        }
    }
}
