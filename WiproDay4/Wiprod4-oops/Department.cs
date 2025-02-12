using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiprod4_oops
{
    internal class Department : Employee
    {

        public Department(int id, string name, string dname, decimal salary) : base(id, name)
        {
            DeptName = dname;
            Salary = salary;
        }

        public string DeptName { get; set; }
        public decimal Salary { get; set; }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(DeptName + " " + Salary);

        }
    }
}
