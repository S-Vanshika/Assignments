using System;
using System.Runtime.CompilerServices;
using static LitwareLib.Employee;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace LitwareLib
{
    interface IPrintable
    {
        void EnterDetails();
    }
    [Serializable]
    public class Employee : IPrintable
    {
        private int EmpNo;
        private string EmpName;
        private double salary;
        public int empNo
        {
            get;
            set;
        }
        public string empName
        {
            get;
            set;
        }
        public double Salary
        {
            get;
            set;
        }
        double HRA, TA, DA, PF, TDS, NetSalary, GrossSalary;

        public Employee()
        {

        }
        public Employee(int EmpNo, string EmpName, double salary)
        {
            this.EmpNo = EmpNo;
            this.EmpName = EmpName;
            this.Salary = salary;
        }

        public virtual void CalculateSalary()
        {
            if (Salary < 5000)
            {
                HRA = 0.10 * Salary;
                TA = 0.05 * Salary;
                DA = 0.15 * Salary;
            }
            else if (Salary < 10000)
            {
                HRA = 0.15 * Salary;
                TA = 0.10 * Salary;
                DA = 0.20 * Salary;
            }
            else if (Salary < 15000)
            {
                HRA = 0.20 * Salary;
                TA = 0.15 * Salary;
                DA = 0.25 * Salary;
            }
            else if (Salary < 20000)
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
            GrossSalary = Salary + HRA + TA + DA;
            PF = 0.10 * GrossSalary;
            TDS = 0.18 * GrossSalary;
            NetSalary = GrossSalary - (PF + TDS);
            Console.WriteLine("Gross Salary of the employee is: {0}\n", GrossSalary);
        }
        public void EnterDetails()
        {
            Console.WriteLine("Gross Salary of Employee : {0}", GrossSalary);
            Console.WriteLine("Net Salary of Employee : {0}", NetSalary);
            Console.WriteLine("Base Salary of Employee : {0}", Salary);

        }
        public class Manager : Employee
        {
            private double _petrolAllowance;
            private double _foodAllowance;
            private double _otherAllowance;
            public Manager(int EmpNo, string EmpName, double salary) : base(EmpNo, EmpName, salary)
            {

            }
            public override void CalculateSalary()
            {
                base.CalculateSalary();

                _petrolAllowance = 0.08 * Salary;
                _foodAllowance = 0.13 * Salary;
                _otherAllowance = 0.03 * Salary;

                GrossSalary = GrossSalary + _petrolAllowance + _foodAllowance + _otherAllowance;
                PF = 0.10 * GrossSalary;
                TDS = 0.18 * GrossSalary;
                NetSalary = GrossSalary - (PF + TDS);
            }
        }
        public class MarketingExecutive : Employee
        {
            private double _kilometeresTravelled;
            private double _tourAllowance;
            private int _telephoneAllowance = 1000;

            public MarketingExecutive(int EmpNo, string EmpName, double salary, double kilometersTravelled) : base(EmpNo, EmpName, salary)
            {
                this._kilometeresTravelled = kilometersTravelled;
            }
            public override void CalculateSalary()
            {
                base.CalculateSalary();
                _tourAllowance = 5 * _kilometeresTravelled;
                GrossSalary = GrossSalary + _telephoneAllowance + _tourAllowance;
                PF = 0.10 * GrossSalary;
                TDS = 0.18 * GrossSalary;
                NetSalary = GrossSalary - (PF + TDS);
            }
        }


    }

    internal class Test
    {
        public static void Main()
        {
            int option;

            do
            {
                Console.WriteLine("Select a number to enter the type of Employee:\n" +
                                  "1. Employee\n" +
                                  "2. Manager\n" +
                                  "3. MarketingExecutive\n");
                option = int.Parse(Console.ReadLine());
                if (option != 1 && option != 2 && option != 3)
                {
                    Console.WriteLine("Enter a Valid Number.\n");
                }
            } while (option != 1 && option != 2 && option != 3);
            switch (option)
            {
                case 1:
                    //case for entering employee data
                    Console.WriteLine("Enter the number of Employees to be entered :");
                    int numOfEmployees = int.Parse(Console.ReadLine());
                    for (int i = 0; i < numOfEmployees; i++)
                    {
                        Console.WriteLine("Enter the Employee Number:");
                        int employeeNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Employee Name:");
                        string employeeName = Console.ReadLine();
                        Console.WriteLine("Enter the Employee Salary:");
                        double employeeSalary = double.Parse(Console.ReadLine());
                        Employee emp1 = new Employee(employeeNumber, employeeName, employeeSalary);
                        emp1.CalculateSalary();
                        emp1.EnterDetails();
                    }
                    break;
                case 2:
                    //case to add manager data
                    Console.WriteLine("Enter the number of Managers to be entered :");
                    int numOfManagers = int.Parse(Console.ReadLine());
                    for (int i = 0; i < numOfManagers; i++)
                    {
                        Console.WriteLine("Enter the Manager's employee Number:");
                        int employeeNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Manager Name:");
                        string employeeName = Console.ReadLine();
                        Console.WriteLine("Enter the Manager Salary:");
                        double employeeSalary = double.Parse(Console.ReadLine());
                        Manager manager1 = new Manager(employeeNumber, employeeName, employeeSalary);
                        manager1.CalculateSalary();
                        manager1.EnterDetails();

                    }
                    break;
                case 3:
                    //case to add marketing executive data
                    Console.WriteLine("Enter the number of Marketing Executive to be entered :");
                    int numOfExecutives = int.Parse(Console.ReadLine());
                    for (int i = 0; i < numOfExecutives; i++)
                    {
                        Console.WriteLine("Enter the Marketing Executive's employee number:");
                        int employeeNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Marketing Executive name:");
                        string employeeName = Console.ReadLine();
                        Console.WriteLine("Enter the Marketing Exceutive salary:");
                        double employeeSalary = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the kilometers travelled:");
                        double kilometersTravelled = double.Parse(Console.ReadLine());
                        MarketingExecutive manager1 = new MarketingExecutive(employeeNumber, employeeName, employeeSalary, kilometersTravelled);
                        manager1.CalculateSalary();
                        manager1.EnterDetails();

                    }
                    break;

            }
        }
    }
}