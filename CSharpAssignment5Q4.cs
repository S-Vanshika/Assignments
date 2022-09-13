using System;

//Exception
internal class StackException : Exception
{
    public StackException(string message) : base(message)
    {

    }
}

class MyStack<T>
{
    public int c { get; set; }
    public T[] a { get; set; }
    public int top { get; set; }


    public MyStack()
    {
        this.top = -1;
        this.c = 4;
        this.a = new T[c];
    }

    public void push(T s)
    {
        if (top == c - 1)
        {
            T[] b = new T[c];
            for (int i = 0; i < c; i++)
            {
                b[i] = this.a[i];
            }
            this.c = (2 * this.c);
            this.a = new T[this.c];
            for (int i = 0; i < b.Length; i++)
            {
                a[i] = b[i];
            }
        }
        top++;
        a[top] = s;
        Console.WriteLine( s + " Inserted Successfully");
    }
    public void pop()
    {
        try
        {
            if (top <= -1)
            {
                throw new StackException("IStack is Empty!");
                return;
            }
        }
        catch (StackException se)
        {
            Console.WriteLine(se);
            return;
        }
        top--;
        Console.WriteLine("Deleted Successfully");
    }

    public void show()
    {
        if(top <= -1)
        {
            Console.WriteLine("Stack is EMpty!");
            return;
        }
        Console.WriteLine("Elements of Stack!");
        for(int i = 0; i <= top; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}
public class Program
{
    static void Main()
    {
        MyStack<int> stack1 = new MyStack<int>();
        stack1.push(1);
        stack1.push(2);
        stack1.push(7);
        stack1.pop();
        stack1.pop();
        Console.WriteLine();
        stack1.show();
        Console.WriteLine();

        MyStack<string> stack2 = new MyStack<string>();
        stack2.push("Vanshika");
        stack2.push("Varun");
        stack2.push("Yash");
        stack2.push("Tanya");
        stack2.pop();
        Console.WriteLine();
        stack2.show();

    }
}