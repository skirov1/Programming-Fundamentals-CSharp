using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CompanyRoster
{
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                var data = Console.ReadLine().Split();

                string name = data[0];
                double salary = double.Parse(data[1]);
                string department = data[2];

                Employee employee = new Employee(name, salary, department);
                employees.Add(employee);
            }

            double highestAverageSalary = 0;
            string bestDepartment = "";

            for (int i = 0; i < employees.Count; i++)
            {
                int employeesCount = 1;
                double averageSalary = employees[i].Salary;
                int index = 0;

                for (int j = i + 1; j < employees.Count; j++)
                {
                    if (employees[i].Department == employees[j].Department)
                    {
                        averageSalary += employees[j].Salary;
                        employeesCount++;
                        index = j;
                    }
                }
                if (!employees.Any(employee => employee.Department == employees[i].Department))
                {
                    averageSalary /= employeesCount;
                }

                if (averageSalary > highestAverageSalary)
                {
                    highestAverageSalary = averageSalary;
                    bestDepartment = employees[index].Department;
                }
            }
            Console.WriteLine($"Highest Average Salary: {bestDepartment}");
            var orderedEmployees = employees.OrderByDescending(employee => employee.Salary).ToList();
            foreach (var employee in orderedEmployees)
            {
                if (employee.Department == bestDepartment)
                {
                    Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
                }
            }
        }
    }
}
