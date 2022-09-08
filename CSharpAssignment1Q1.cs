//1. Write a Simple console Application Calculator 
using System;
class Program
{
    static void Main(string[] args)
    {
        //Operations information
        Console.WriteLine("Operations that can be Performed");
        Console.WriteLine("Press 1 for Addition");
        Console.WriteLine("Press 2 for Subtraction");
        Console.WriteLine("Press 3 for Multiplication");
        Console.WriteLine("Press 4 for Division");
        int operation = Convert.ToInt32(Console.ReadLine());

        //Input Numbers
        Console.WriteLine("Enter 1st Input");
        int input1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2nd Input");
        int input2 = Convert.ToInt32(Console.ReadLine());

        //loop
        int output = 0;
        switch (operation)
        {
            case 1:
                output = Addition(input1, input2);
                break;
            case 2:
                output = Subtraction(input1, input2);
                break;
            case 3:
                output = Multiplication(input1, input2);
                break;
            case 4:
                output = Division(input1, input2);
                break;
            default:
                Console.WriteLine("No Crossponding Operation!!");
                break;
        }
        Console.WriteLine("The output of the performed operation is {0}", output);
    }
    //Addition function
    public static int Addition(int input1, int input2)
    {
        int output = input1 + input2;
        return output;
    }
    //Subtraction function
    public static int Subtraction(int input1, int input2)
    {
        int output = input1 - input2;
        return output;
    }
    //Multipication function
    public static int Multiplication(int input1, int input2)
    {
        int output = input1 * input2;
        return output;
    }
    //Division function
    public static int Division(int input1, int input2)
    {
        int output = input1 / input2;
        return output;
    }
}



