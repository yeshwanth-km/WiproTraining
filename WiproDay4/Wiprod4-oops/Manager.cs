using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiprod4_oops
{
    internal class Manager : Department
    {

        public Manager(int eid, string ename, string dname, decimal sal, string ManagerName) : base(eid, ename, dname, sal)
        {
            this.ManagerName = ManagerName;
        }

        public string ManagerName { get; set; }


public override void Display()
        {
            base.Display();//call display method of departrent class
            Console.WriteLine("Manager Name" + ManagerName);
        }



    }
}
