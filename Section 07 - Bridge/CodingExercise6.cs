using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section07Bridge
{
    internal class CodingExercise6
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Triangle(new RasterRenderer()).ToString());
            Console.ReadKey();


        }
    }
}
