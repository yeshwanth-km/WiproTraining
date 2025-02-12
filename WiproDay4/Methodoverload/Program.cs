using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverload
{
    class AddOperation
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Add(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        public static void Add(int a, int b, int c)
        {
            Console.WriteLine(a + b + c);
        }
        public string Add(string a, string b)
        {
            return a + b;
        }
        public void Add(double c, float d)
        {
            Console.WriteLine(c + d);
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            AddOperation op = new AddOperation();
            Console.WriteLine(op.Add("Wipro", "training"));
            AddOperation.Add(10, 20, 30);
            op.Add(10, 20);
        }
    }
}
