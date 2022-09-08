//2. Accept average marks of five students. Display the highest marks obtained.
using System;
class Program
{
    public static void Main(string[] args)
    {
        //Input of Marks of 5 different students
        Console.WriteLine("Enter average marks of Student 1:");
        int M1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter average marks of Student 2:");
        int M2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter average marks of Student 3:");
        int M3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter average marks of Student 4:");
        int M4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter average marks of Student 5:");
        int M5 = Convert.ToInt32(Console.ReadLine());

        //Conditions
        int max;
        if (M1 > M2 && M1 > M3 && M1 > M4 && M1 > M5)
        {
            max = M1;
            Console.WriteLine("The Highest Marks obtained are {0}", max);
        }

        else if (M2 > M1 && M2 > M3 && M2 > M4 && M2 > M5)
        {
            max = M2;
            Console.WriteLine("The Highest Marks obtained are {0}", max);
        }

        else if (M3 > M1 && M3 > M2 && M3 > M4 && M3 > M5)
        {
            max = M3;
            Console.WriteLine("The Highest Marks obtained are {0}", max);
        }
        else if (M4 > M1 && M4 > M2 && M4 > M3 && M4 > M5)
        {
            max = M4;
            Console.WriteLine("The Highest Marks obtained are {0}", max);
        }
        else
        {
            max = M5;
            Console.WriteLine("The Highest Marks obtained are {0}", max);
        }
    }
}



