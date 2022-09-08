//5. Write a single method that calculates the area and circumference of the circle.
//The area and circumference should be displayed through the client code
using System;
using System.Runtime.ConstrainedExecution;

class Program
{
    public static void Main()
    {
        //Input of raduis
        Console.WriteLine("Enter the value of the raduis of Circle");
        double radius = Convert.ToDouble(Console.ReadLine());

        //Method called
        AreaandCircumference(radius);
    }
    //Method to find the area and circumference
    public static int AreaandCircumference(double radius)
    {
        double area = Math.PI * radius * radius;
        double circumference = 2 * radius * Math.PI;
        Console.WriteLine("The Area and Circumference of the Circle are : {0} and {1}", area, circumference);
        return 0;
    }
}

