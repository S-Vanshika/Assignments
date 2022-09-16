using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public delegate void Delegate1();
public delegate void Delegate2();

class Events
{
    public void Handler1()
    {
        Console.WriteLine("Transaction can't be performed");
    }
    public void Handler2()
    {
        Console.WriteLine("Zero Balance");
    }

    public Events(Account b)
    {
        Delegate1 del1 = new Delegate1(Handler1);
        Delegate2 del2 = new Delegate2(Handler2);
        b.UnderBalance += del1;
        b.ZeroBalance += del2;

    }
}
class Account
{
    public int AccountNumber { get; set; }
    public string CustomerName { get; set; }
    public double AccountBalance { get; set; }
    public double WithdrawBalanace { get; set; }
    public double DepositeBalance { get; set; }

    public void EnterDetails()
    {
        Console.WriteLine("Enter the Account Balance:");
        AccountBalance = double.Parse(Console.ReadLine());
    }
    public void Withdraw()
    {
        Console.WriteLine("Enter the Withdraw Balance:");
        WithdrawBalanace = double.Parse(Console.ReadLine());
        this.AccountBalance = this.AccountBalance - this.WithdrawBalanace;
        Console.WriteLine("Current Account Balance After Withdrawing: {0}", this.AccountBalance);
    }

    public void Deposite()
    {
        Console.WriteLine("Enter the Deposite Balance:");
         DepositeBalance = double.Parse(Console.ReadLine());
        this.AccountBalance = this.AccountBalance + DepositeBalance;
        Console.WriteLine("Current Account Balance After Depsoiting: {0}", this.AccountBalance);
    }

    public Account()
    {

    }

    public Account(int accountNumber, string customerName, double accountBalance)
    {
        AccountNumber = accountNumber;
        CustomerName = customerName;
        AccountBalance = accountBalance;
    }

    public event Delegate1 UnderBalance;
    public event Delegate2 ZeroBalance;

    public void FireEvent1()
        {
            if(UnderBalance != null)
            {
                UnderBalance();
            }
        }
    public void FireEvent2()
    {
        if(ZeroBalance != null)
        {
            ZeroBalance();
        }
    }
}

class Program
{
    public static void Main()
    {
        Account A1 = new Account();
        A1.EnterDetails();
        Events a = new Events(A1);

        A1.Withdraw();
        if(A1.AccountBalance < 1000)
        {
            A1.FireEvent1();
        }

        if(A1.AccountBalance == 0)
        {
            A1.FireEvent2();    
        }

        A1.Deposite();


    }
    
}