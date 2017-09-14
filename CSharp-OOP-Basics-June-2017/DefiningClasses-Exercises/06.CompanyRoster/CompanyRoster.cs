using System;
using System.Collections.Generic;
using System.Linq;

public class CompanyRoster
{
    public static void Main()
    {
        var listOfEmployees = new List<Employee>();
        var n = int.Parse(Console.ReadLine().Trim());

        for (int i = 0; i < n; i++)
        {
            var inputArgs = Console.ReadLine().Trim().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            var name = inputArgs[0];
            var salary = decimal.Parse(inputArgs[1]);
            var position = inputArgs[2];
            var dept = inputArgs[3];

            var currentEE = new Employee(name, salary, position, dept);

            if (inputArgs.Length == 5)
            {
                if (int.TryParse(inputArgs[4], out int result))
                {
                    currentEE.Age = result;
                }
                else
                {
                    currentEE.Email = inputArgs[4];
                }
            }
            else if (inputArgs.Length == 6)
            {
                currentEE.Email = inputArgs[4];
                currentEE.Age = int.Parse(inputArgs[5]);
            }

            listOfEmployees.Add(currentEE);
        }

        var employeesByDeptAndAvgSalary = listOfEmployees.GroupBy(x => x.Department)
            .Select(gr => new
            {
                Name = gr.Key,
                AvgSalary = gr.Average(s => s.Salary),
                Employees = gr
            })
            .OrderByDescending(x => x.AvgSalary)
            .FirstOrDefault();

        Console.WriteLine($"Highest Average Salary: {employeesByDeptAndAvgSalary.Name}");

        foreach (var ee in employeesByDeptAndAvgSalary.Employees.OrderByDescending(x => x.Salary))
        {
            Console.WriteLine($"{ee.Name} {ee.Salary:f2} {ee.Email} {ee.Age}");
        }
    }
}