using System;
using System.Xml.Serialization;

interface ICloneable
{
    public int[] clone(int[] stack, int size);
}
public class MyStack : ICloneable
{
    public int[] stack;
    public int top;
    int size;

    public MyStack(int size)
    {
        this.top = -1;
        this.size = size;
        this.stack = new int[size];
    }

    public void push(int num)
    {
        if(top + 1 >= size)
        {
            Console.WriteLine("Overflow");
        }
        top = top + 1;
        stack[top] = num;
        Console.WriteLine("Push Operation Performed");
    }

    public int pop()
    {
        if(top == -1)
        {
            Console.WriteLine("Underflow");
        }
        int value = stack[top];
        top = top - 1;
        Console.WriteLine("Pop Operation Performed");
        return value;
    }

    public int[] clone(int[] stack, int size)
    {
        MyStack stack2 = new MyStack(size);
        stack2.stack = stack;
        Console.WriteLine("Cloning Operation Performed");
        return stack2.stack;
    }
}
public class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the stack:");
        int stackSize = int.Parse(Console.ReadLine());
        MyStack stack1 = new MyStack(stackSize);
        int choice;
        do 
        {
            do
            {
                Console.WriteLine("Press 1 for Push\nPress 2 for Pop\nPress 3 for Clone\nPress 4 To Exit");
                choice = int.Parse(Console.ReadLine());
                if (choice != 1 && choice != 2 && choice != 3 && choice != 4)
                {
                    Console.WriteLine("Enter Valid Value");
                }
                if (choice == 4)
                {
                    break;
                }
            } while (choice != 1 && choice != 2 && choice != 3);
            if(choice == 4)
            {
                break;
            }
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter a number:");
                    int num = int.Parse(Console.ReadLine());
                    stack1.push(num);
                    break;
                case 2:
                    int value = stack1.pop();
                    if (value == -99999)
                    {
                        break;
                    }
                    Console.WriteLine("The value is Popped");
                    break;
                case 3:
                    int[] clone = stack1.clone(stack1.stack, stackSize);
                    int temp = stack1.top;
                    Console.WriteLine("Cloned Stack");
                    while (temp > -1)
                    {
                        Console.WriteLine(clone[temp]);
                        temp = temp - 1;
                    }
                    break;
                case 4:
                    break;
            }
        }while(choice == 1 || choice == 2 || choice == 3);
        
    }
}