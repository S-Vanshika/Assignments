using System;
using System.Collections.Generic;
using System.Buffers;
using System.Collections;
using System.Diagnostics.Contracts;

interface Iprintable
{
    string print();
}
class Employee : Iprintable
{
    public int EmpNo { get; set; }
    public string EmpName { get; set; }
    public double Salary { get; set; }
    private double HRA;
    private double TA;
    private double DA;
    public double PF { get; set; }
    public double TDS { get; set; }
    public double NetSalary { get; set; }
    public double GrossSalary { get; set; }

    public Employee()
    {

    }

    public Employee(int EmpNo, string EmpName, double Salary, double HRA, double TA, double DA, double PF, double TDS, double NetSalary, double GrossSalary)
    {
        this.EmpNo = EmpNo;
        this.EmpName = EmpName;
        this.Salary = Salary;
        this.HRA = HRA;
        this.TA = TA;
        this.DA = DA;
        this.PF = PF;
        this.TDS = TDS;
        this.NetSalary = NetSalary;
        this.GrossSalary = GrossSalary;
    }
    public Employee(int EmpNo, string EmpName, double Salary)
    {
        this.EmpNo = EmpNo;
        this.EmpName = EmpName;
        this.Salary = Salary;
    }
    public virtual void EnterDetails()
    {
    start1:
        Console.WriteLine("Enter Employee Number");
        try
        {
            this.EmpNo = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Enter a valid number");
            goto start1;
        }

        Console.WriteLine("Enter Employee Name");
        this.EmpName = Console.ReadLine();
    start2:
        Console.WriteLine("Enter Employee Salary");
        try
        {
            this.Salary = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Enter a valid value");
            goto start2;
        }
    }
    public virtual int CalculateSalary()
    {

        if (this.Salary < 5000)
        {
            this.HRA = (.10 * this.Salary);
            this.TA = (.05 * this.Salary);
            this.DA = (.15 * this.Salary);
            this.GrossSalary = this.Salary + this.HRA + this.TA + this.DA;
            this.PF = (.1 * this.GrossSalary);
            this.TDS = (.18 * this.GrossSalary);
            this.NetSalary = this.GrossSalary - this.PF - this.TDS;
            return (int)this.GrossSalary;
        }
        else if (this.Salary >= 5000 && this.Salary < 10000)
        {
            this.HRA = (.15 * this.Salary);
            this.TA = (.10 * this.Salary);
            this.DA = (.20 * this.Salary);
            this.GrossSalary = this.Salary + this.HRA + this.TA + this.DA;
            this.PF = (.1 * this.GrossSalary);
            this.TDS = (.18 * this.GrossSalary);
            this.NetSalary = this.GrossSalary - this.PF - this.TDS;
            return (int)this.GrossSalary;
        }
        else if (this.Salary >= 10000 && this.Salary < 15000)
        {
            this.HRA = (.20 * this.Salary);
            this.TA = (.15 * this.Salary);
            this.DA = (.25 * this.Salary);
            this.GrossSalary = this.Salary + this.HRA + this.TA + this.DA;
            this.PF = (.1 * this.GrossSalary);
            this.TDS = (.18 * this.GrossSalary);
            this.NetSalary = this.GrossSalary - this.PF - this.TDS;
            return (int)this.GrossSalary;
        }
        else if (this.Salary >= 15000 && this.Salary < 20000)
        {
            this.HRA = (.25 * this.Salary);
            this.TA = (.20 * this.Salary);
            this.DA = (.30 * this.Salary);
            this.GrossSalary = this.Salary + this.HRA + this.TA + this.DA;
            this.PF = (.1 * this.GrossSalary);
            this.TDS = (.18 * this.GrossSalary);
            this.NetSalary = this.GrossSalary - this.PF - this.TDS;
            return (int)this.GrossSalary;
        }
        else
        {
            this.HRA = (.30 * this.Salary);
            this.TA = (.25 * this.Salary);
            this.DA = (.35 * this.Salary);
            this.GrossSalary = this.Salary + this.HRA + this.TA + this.DA;
            this.PF = (.1 * this.GrossSalary);
            this.TDS = (.18 * this.GrossSalary);
            this.NetSalary = this.GrossSalary - this.PF - this.TDS;
            return (int)this.GrossSalary;
        }

    }
    public string print()
    {
        return "Employee name = " + this.EmpName + " having Employee Number =  " +
                  this.EmpNo + " and ,Gross Salary = " + this.CalculateSalary();
    }

    public bool Search(string name)
    {
        if(this.EmpName == name)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
class Manager : Employee
{
    public double petrolAllowance { get; set; }
    public double foodAllowance { get; set; }
    public double OtherAllowance { get; set; }

    public override int CalculateSalary()
    {
        this.petrolAllowance = .08 * base.Salary;
        this.foodAllowance = .13 * base.Salary;
        this.OtherAllowance = .03 * base.Salary;
        this.GrossSalary = base.CalculateSalary() + (int)this.petrolAllowance + (int)this.foodAllowance + (int)this.OtherAllowance;
        this.PF = (.1 * this.GrossSalary);
        this.TDS = (.18 * this.GrossSalary);
        this.NetSalary = this.GrossSalary - this.PF - this.TDS;
        return (int)this.GrossSalary;
    }

    public string print()
    {
        return "Manager Name: = " + this.EmpName + " Manager EmployeeID = " + this.EmpNo + " ,Gross " +
            " Salary is = " + this.CalculateSalary() + ", Net Salary = " + Convert.ToString(this.NetSalary);
    }


}
class MarketingExecutive : Employee
{
    public double kilometerTravel { get; set; }
    public double TourAllowance { get; set; }
    public double TelephoneAllowance { get; set; }

    public override void EnterDetails()
    {
    start1:
        Console.WriteLine("Enter Employeee Number");
        try
        {
            this.EmpNo = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Enter a valid number");
            goto start1;
        }

        Console.WriteLine("Enter Employee Name");
        this.EmpName = Console.ReadLine();
    start2:
        Console.WriteLine("Enter Employee Salary");
        try
        {
            this.Salary = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Enter a valid value");
            goto start2;
        }
        Console.WriteLine("Enter kilometers ");
        this.kilometerTravel = int.Parse(Console.ReadLine());
    }

    public override int CalculateSalary()
    {
        this.TourAllowance = this.kilometerTravel * 5;
        this.TelephoneAllowance = 1000;
        this.GrossSalary = base.CalculateSalary() + (int)this.TourAllowance + (int)this.TelephoneAllowance;
        this.PF = (.1 * this.GrossSalary);
        this.TDS = (.18 * this.GrossSalary);
        this.NetSalary = this.GrossSalary - this.PF - this.TDS;
        return (int)this.GrossSalary;
    }
    public string print()
    {
        return "MarketingExecutive Name: = " + this.EmpName + " MarketingExecutive EmployeeID = " + this.EmpNo + " ,Gross " +
            " Salary is = " + this.CalculateSalary() + ", Net Salary = " + Convert.ToString(this.NetSalary) + "\n";
    }


}
class Program
{
    public static void Main()
    {
        Employee E1 = new Employee();
        Employee E2 = new Employee();
        Employee E3 = new Employee();

        ArrayList arr = new ArrayList();
        arr.Add(E1);
        arr.Add(E2);
        arr.Add(E3);

        foreach (Employee e in arr)
        {
            e.EnterDetails();
            Console.WriteLine(e.print());
        }

        //Functionality to search an Employee
        Console.WriteLine("Enter the Employee Name to be searched:");
        string name = Console.ReadLine();
        int count = 0;
        foreach(Employee e in arr)
        {
            if(e.Search(name))
            {
                Console.WriteLine("Employee Name found: {0}",e.print());
                count++;
            }
        }
        if(count == 0)
        {
            Console.WriteLine("Employee Name not Found!");
        }
    }
}