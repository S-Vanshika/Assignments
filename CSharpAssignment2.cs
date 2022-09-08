using System;
using System.Runtime.CompilerServices;

namespace LitwareLib
{
    class Employee
    {
        private int EmpNo
        {
            get;
            set;
        }
        private string EmpName
        {
            get;
            set;
        }
        private double Salary
        {
            get;
            set;
        }
        double HRA, TA, DA, PF, TDS, NetSalary, GrossSalary;

        public Employee()
        {

        }
        public Employee(int EmployeeNo, string EmployeeName, double Sal)
        {
            this.EmpNo = EmployeeNo;
            this.EmpName = EmployeeName;
            this.Salary = Sal;
        }

        public void CalculateSalary()
        {
            if (Salary < 5000)
            {
                HRA = 0.10 * Salary;
                TA = 0.05 * Salary;
                DA = 0.15 * Salary;
            }
            else if (Salary < 10000 && Salary >= 5000)
            {
                HRA = 0.15 * Salary;
                TA = 0.10 * Salary;
                DA = 0.20 * Salary;
            }
            else if (Salary < 15000 && Salary >= 10000)
            {
                HRA = 0.20 * Salary;
                TA = 0.15 * Salary;
                DA = 0.25 * Salary;
            }
            else if (Salary < 20000 && Salary >= 15000)
            {
                HRA = 0.25 * Salary;
                TA = 0.20 * Salary;
                DA = 0.30 * Salary;
            }
            else
            {
                HRA = 0.30 * Salary;
                TA = 0.25 * Salary;
                DA = 0.35 * Salary;
            }
            this.GrossSalary = Salary + HRA + TA + DA;

            PF = 0.10 * GrossSalary;
            TDS = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (PF + TDS);
            Console.WriteLine("Gross Salary of the employee is: {0}\n", GrossSalary);
        }
        public void EnterDetails()
        {
            start1:
            Console.WriteLine("Enter the Employee Number");
            try
            {
                this.EmpNo = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Enter Valid Value!");
                goto start1;
            }

            Console.WriteLine("Enter the Employee Name");
            this.EmpName = Console.ReadLine();

            start2:
            Console.WriteLine("Enter the Employee Salary");
            try
            {
                this.Salary = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Enter Valid Value!");
                goto start2;
            }
        }


    }

    internal class Test
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number of employees");
            int n = int.Parse(Console.ReadLine());

            Employee[] emp = new Employee[n];
            for(int i = 0; i<n; i++)
            {
                emp[i] = new Employee();
                emp[i].EnterDetails();
                emp[i].CalculateSalary();
            }
            
        }
        
    }
}