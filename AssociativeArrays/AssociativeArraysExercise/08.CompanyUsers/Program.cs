using System;
using System.Collections.Generic;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyEmployees = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] data = Console.ReadLine().Split(" -> ");
                if (data[0] == "End")
                {
                    break;
                }
                string companyName = data[0];
                string employee = data[1];
                if (!companyEmployees.ContainsKey(companyName))
                {
                    companyEmployees.Add(companyName, new List<string>());
                }
                if (!companyEmployees[companyName].Contains(employee))
                {
                    companyEmployees[companyName].Add(employee);
                }
            }

            foreach (var company in companyEmployees)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var employee in companyEmployees[company.Key])
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
