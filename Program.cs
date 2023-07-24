using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp.Employee;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee[] emp = new Employee[2];
            emp[0] = new FullTime("E-001", "Saef", 30000, new MidDate(12, 09, 2013), 15000);
            emp[1] = new PartTime("E-002", "Kawsur", 12000, new MidDate(23, 07, 2019), 1300);


            foreach (Employee e in emp)
            {
                e.ShowInfo();
                e.GrossIncome();
            }

        }
    }
}