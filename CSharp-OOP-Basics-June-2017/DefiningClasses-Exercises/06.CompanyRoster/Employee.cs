using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Employee
{
    private int age = -1;
    private string email = "n/a";

    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Position { get; set; }
    public string Department { get; set; }

    public string Email
    {
        get { return this.email; }
        set { this.email = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public Employee(string name, decimal salary, string position, string department)
    {
        this.Name = name;
        this.Salary = salary;
        this.Position = position;
        this.Department = department;
    }

}

