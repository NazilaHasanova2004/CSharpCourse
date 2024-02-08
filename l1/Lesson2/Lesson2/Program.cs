using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            float rad = float.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter:"+2*Math.PI*rad);
            Console.WriteLine("Area:" +  Math.PI * rad*rad);

            Console.ReadLine();
        }
    }
}
