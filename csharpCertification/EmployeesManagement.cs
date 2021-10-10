using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hackerrank.csharpCertification
{
    class EmployeesManagement
    {
        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item.Age + "" + item.Company + "" + item.FirstName + "" + item.LastName);
            //}
            var result = employees.GroupBy(x => x.Company).Select(x => new { c = x.Key, l = x.ToList() })
                .OrderBy(x => x.c)
                .ToDictionary(x => x.c, y => (int)Math.Round(y.l.Average(z => z.Age)));
            return result;
        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            var result = employees.GroupBy(x => x.Company).Select(x => new { c = x.Key, l = x.ToList().Count() })
                .OrderBy(x => x.c)
                .ToDictionary(x => x.c, y => y.l);
            return result;
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            var result = employees.GroupBy(x => x.Company).Select(x => new { c = x.Key, l = x.ToList().OrderByDescending(y => y.Age).First() })
                .OrderBy(x => x.c)
                .ToDictionary(x => x.c, y => y.l);
            return result;
        }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
}
