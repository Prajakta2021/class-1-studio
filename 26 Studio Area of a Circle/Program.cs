using System;

namespace _26_Studio_Area_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
           // double pi = Math.PI;
            Console.WriteLine("Please enter a radius of circle : ");
            double radius = double.Parse(Console.ReadLine());
            //radius should be "double" data type to save int as well as decimal numbers.
            double areaOfCircle = Math.PI * Math.Pow(radius, 2);
            double circumferenceOfCircle = 2 * Math.PI * radius;
            double diameterOfCircle = 2 * radius;
            Console.WriteLine("Area of circle is " + areaOfCircle + " square units.");
            Console.WriteLine("Circumference of circle is " + circumferenceOfCircle + " units.");
            Console.WriteLine("Diameter of circle is " + diameterOfCircle + " units.");
            Console.ReadLine();
        }
    }
}
