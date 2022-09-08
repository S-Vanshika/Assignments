//4. Write a method to swap two integers. The client code should call the method and print the swapped value.
using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the First Number:");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Second Number:");
        int second = Convert.ToInt32(Console.ReadLine());

        //Swap operation
        //first = 5, second = 10
        Console.WriteLine("Before swap First Number = " + first + " Second Number = " + second);
        first = first + second; //first = 15 (5+10)      
        second = first - second; //second = 5 (15-10)      
        first = first - second; //first = 10 (15-5)   
        Console.Write("After swap First Number = " + first + " Seond Number = " + second);
    }
}



