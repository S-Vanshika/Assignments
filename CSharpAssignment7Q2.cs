using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpAssignment7Q2
{

    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int TotalAmount { get; set; }

        public Customer()
        {

        }
        public Customer(int customerId, string customerName, int totalAmount)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.TotalAmount = totalAmount;
        }
        public void EnterDetails()
        {
            Console.WriteLine("Enter Customer ID:");
            this.CustomerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer Name:");
            this.CustomerName = Console.ReadLine();
            Console.WriteLine("Enter Total Amount:");
            this.TotalAmount = int.Parse(Console.ReadLine());

        }

        public string Print()
        {
            return "Cutomer ID: "+CustomerId+" having Customer Name: "+CustomerName+" , Total Amount: "+TotalAmount;
        }
    }
    class Program
    {
        public static void Main()
        {
            StreamWriter SW = new StreamWriter(@"CustomerData");

            Customer C1 = new Customer();
            C1.EnterDetails();
            SW.WriteLine(C1.Print());



            SW.Close();
            string text;
            StreamReader SR = new StreamReader(@"CustomerData1.txt");
            text = SR.ReadLine();

            SR.Close();

            Console.WriteLine("TEXT FROM THE FILE:");
            Console.WriteLine(text);
        }
    }
}