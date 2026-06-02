using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.OOP.Encapsulation
{
    internal class Employee
    {
        private int salary;

        //public void setSalary(int value)
        //{
        //    if(value > 0)
        //    {
        //        salary = value;

        //    }
        //    else
        //    {
        //        Console.WriteLine("Salary is invalid");
        //    }
        //}

        //public int getSalary()
        //{
        //    return salary;
        //}

        public int Salary
        {
            get { return salary; }

            set
            {
                if(salary < 0)
                {
                    Console.WriteLine("Salary is invalid");
                }
                else
                {
                    salary = value;
                }
            }
        }
    }
}
