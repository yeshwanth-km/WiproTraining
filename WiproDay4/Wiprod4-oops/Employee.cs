using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiprod4_oops
{
    internal class Employee
    {

        public Employee(int Empid, string EmpName)
        {
            this.Empid = Empid;
            this.EmpName = EmpName;
        }
        public int Empid { get; set; }

        public string EmpName { get; set; }


        public virtual void Display()
        {
            Console.WriteLine(Empid + " " + EmpName);
        }
    }
}
