using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheri
{
    internal interface IShape
    {
        void CalculateArea();
        
    }

    class Circle : IShape
    {
        public int radius { get; set; }
        public void CalculateArea()
        {
            Console.WriteLine($"Area of Circle:{Math.PI * Math.Pow(radius, 2)}");
        }
    }
    class Rect : IShape
    {
        public int l { get; set; }
        public int b { get; set; }
        public void CalculateArea()
        {
            Console.WriteLine($"Area of Rectangle:{l * b}");
        }
    }
}
