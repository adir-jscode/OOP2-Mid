using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp.Employee;

namespace ConsoleApp
{
    internal class PartTime : Employee
    {
        public PartTime(string id, string name, double salary, MidDate joiningDate, double commission)
       : base(id, name, salary, joiningDate)
        {
            Commission = commission;
        }

        public override double GrossIncome()
        {
            
            double grossIncomeCommission = Salary  + Commission;
            return grossIncomeCommission;


        }

        public void ShowInfo()
        {

            Console.WriteLine("Gross Income as Part Time " + GrossIncome());


            Console.WriteLine();
        }
    }
}
