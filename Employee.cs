using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public abstract class Employee
    {


        //Creating custom type for joining date
        public struct MidDate
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            public MidDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }

            
        }

        
        public string ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Bonus { get; set; }
        public double Commission { get; set; }
        public MidDate JoiningDate { get; set; }



        public  Employee(string id, string name, double salary, MidDate joiningDate)
        {
            ID = id;
            Name = name;
            Salary = salary;
            JoiningDate = joiningDate;
        }

        public abstract double GrossIncome();

        
        public  void ShowInfo()
        {
            
            Console.WriteLine("Id:" + ID);
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Salary:" + Salary);
            Console.WriteLine("Joining Date:" + JoiningDate.Day  + "/" + JoiningDate.Month + "/" + JoiningDate.Year);

            Console.WriteLine("Gross Income:" + GrossIncome());

            Console.WriteLine();
        }
    }
}
