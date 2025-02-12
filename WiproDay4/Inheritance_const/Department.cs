﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_const
{
    internal class Department : Employee
    {
        public string DeptName { get; set; }
        public decimal Salary { get; set; }

        public Department(int id, string name, string dname, decimal salary) : base(id, name)
        {
            DeptName = dname;
            Salary = salary;
        }

        //public void show()
        //{
        //    Console.WriteLine(DeptName + " " + Salary);
        //}
        public override void Display()
        {
            base.Display();//control goes to the base class(Employee) display method
            Console.WriteLine(DeptName + " " + Salary);
        }
    }
}
