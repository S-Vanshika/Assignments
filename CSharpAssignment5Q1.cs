using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using static System.Array;

class Program
{
    public static void DisplayString(string[] name)
    {
        for (int i = 0; i < name.Length; i++)
        {
            Console.WriteLine(name[i]);
        }
    }

    public static void DisplayInteger(int[] value)
    {
        for (int i = 0; i < value.Length; i++)
        {
            Console.WriteLine((int)value[i]);
        }
    }

    public static void Main()
    {
        String[] name;
        int[] value;

        Console.WriteLine("Enter the array length value for String Array:");
        int StringLength = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the array length value for Integer Array:");
        int IntegerLength = int.Parse(Console.ReadLine());
        Console.WriteLine();

        name = new String[StringLength];
        value = new int[IntegerLength];

        Console.WriteLine("Enter the values for String Array:");
        for (int i = 0; i < StringLength; i++)
        {
            name[i] = Console.ReadLine();
        }
        Console.WriteLine();

        Console.WriteLine("Enter the values for Integer Array:");
        for (int i = 0; i < IntegerLength; i++)
        {
            value[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine();

        //Copy Operation
        Console.WriteLine("Copying String and Integer Array values!");
        int[] copy_value_array = new int[value.Length];
        string[] copy_name_array = new string[name.Length];

        Array.Copy(name, copy_name_array, name.Length);
        DisplayString(copy_name_array);
        Console.WriteLine();

        Array.Copy(value, copy_value_array, value.Length);
        DisplayInteger(copy_value_array);
        Console.WriteLine();

        //Sort Operation
        Console.WriteLine("Sorting String and Integer Array!");

        Array.Sort(name);
        DisplayString(name);
        Console.WriteLine();

        Array.Sort(value);
        DisplayInteger(value);
        Console.WriteLine();

        //Reverse Operation
        Console.WriteLine("Reversing String and Integer Array!");
        
        Array.Reverse(name);
        DisplayString(name);
        Console.WriteLine();

        Array.Reverse(value);
        DisplayInteger(value);
        Console.WriteLine();

        //Clear Operation
        Console.WriteLine("Clearing String and Integer Array!");

        Array.Clear(name);
        DisplayString(name);
        Console.WriteLine();

        Array.Clear(value);
        DisplayInteger(value);
        Console.WriteLine();
    }
}