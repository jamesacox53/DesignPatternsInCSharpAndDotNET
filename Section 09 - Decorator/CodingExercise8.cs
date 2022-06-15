using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section09Decorator
{
    internal class CodingExercise8
    {
        static void Main(string[] args)
        {
            Dragon dragon = new Dragon();
            dragon.Age = 30;

            Console.WriteLine(dragon.Fly());
            Console.WriteLine(dragon.Crawl());
            Console.ReadKey();
        }
    }
}
