using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp
{
    internal class FullTime : Employee
    {
        public FullTime(string id, string name, double salary, MidDate joiningDate, double bonus)
       : base(id, name, salary, joiningDate)
        {
            Bonus = bonus;
        }

        public override double GrossIncome()
        {
            double grossIncome = Salary * 12 + Bonus * 2;
            return grossIncome;
            

        }

        public void ShowInfo()
        {

            Console.WriteLine("Gross Income as Full Time " + GrossIncome());


            Console.WriteLine();
        }
    }
}
