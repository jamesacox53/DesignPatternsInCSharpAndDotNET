using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02Builder
{
    internal class CodingExercise1
    {
        static void Main(string[] args)
        {
            var cb = new CodeBuilder("Person").AddField("Name", "string").AddField("Age", "int");

            Console.WriteLine(cb);
            Console.ReadKey();
        }
    }
}
