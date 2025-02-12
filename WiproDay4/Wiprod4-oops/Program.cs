using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiprod4_oops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Empid = 1;
            emp.EmpName = "Yeshwanth";


            emp.Display();


            Department dpt = new Department(); //creating instance for the derived class
            dpt.Empid = 1;
            dpt.EmpName = "Yeshwanth";
            dpt.DeptName = "Develoepr";
            dpt.Salary = 50000;


            //dpt.Display();
            // dpt.Show(:


            Manager mgr = new Manager();
            mgr.Empid = 1;

            mgr.EmpName = "Yeshwanth";
            mgr.DeptName = "Develoepr";
            mgr.Salary = 50000;
            mgr.ManagerName = "Pooja";

            mgr.Display();


            
        }
    }
}
