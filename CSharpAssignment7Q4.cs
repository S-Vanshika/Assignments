using System;
using System.Collections.Generic;
using System.Buffers;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

class DataSerializer
{
    public void BinarySerializer(object data, string filePath)
    {
        FileStream fileStream;
        BinaryFormatter bf = new BinaryFormatter();
        if(File.Exists(filePath)) File.Delete(filePath);
        fileStream = File.Create(filePath);
        bf.Serialize(fileStream, data);
        fileStream.Close();
    }

    public object BinaryDeserialize(string filePath)
    {
        object obj = null;
        FileStream fileStream;
        BinaryFormatter bf = new BinaryFormatter();
        if(File.Exists(filePath))
        {
            fileStream = File.OpenRead(filePath);
            obj = bf.Deserialize(fileStream);
            fileStream.Close();
        }
        return obj;
    }
}

[Serializable]
class Employee
{

    public int EmpNo { get; set; }
    public string EmpName { get; set; }
    public double Salary { get; set; }
        
    public Employee()
    {

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
    
    
    public void PrintMessage()
    {
        Console.WriteLine("Manager Name: = " + this.EmpName + " Manager EmployeeID = " + this.EmpNo + " ,Gross Salary is = " + this.Salary);
    }

}

class Program
{
    public static void Main()
    {
        Employee E1 = new Employee();
        E1.EnterDetails();
        string filePath = "data.save";
        DataSerializer dataSerializer = new DataSerializer();
        Employee e = null;

        dataSerializer.BinarySerializer(E1, filePath);

        e = dataSerializer.BinaryDeserialize(filePath) as Employee;

        Console.WriteLine(e.EmpNo);
        Console.WriteLine(e.EmpName);
        Console.WriteLine(e.Salary);
    }
}