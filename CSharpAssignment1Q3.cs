//3.Write a static method to accept param array of integers.
//The method should find the sum of all the integers passed and display the result. Write a client program to call the method.
using System;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the size of the array");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[1000000];
        int i;
        Console.Write("Input the elements in the array :\n");
        for (i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int sum = 0;
        for (i = 0; i < n; i++)
        {
            sum += arr[i];
            Console.WriteLine("Sum after entering a new element is: {0}", sum);
        }
    }
}



