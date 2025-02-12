using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_const
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter emp id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter emp Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter dept name:");
            string dname = Console.ReadLine();
            Console.WriteLine("Enter salary:");
            decimal sal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter manager name:");
            string mname = Console.ReadLine();
            Manager mgrcon = new Manager(id, name, dname, sal, mname);
            mgrcon.Display();
        }
    }
}
