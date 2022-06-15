using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section08Composite
{
    internal class CodingExercise7
    {
        static void Main(string[] args)
        {
            IValueContainer single = new SingleValue() { Value = 5 };
            IValueContainer many = new ManyValues() { 1, 2, 3, 4 };
            IValueContainer many2 = new ManyValues() { 6, 7 };

            List<IValueContainer> list = new List<IValueContainer>() { single, many, many2 };

            int res = list.Sum();

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
