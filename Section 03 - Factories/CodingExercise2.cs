using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03Factories
{
    internal class CodingExercise2
    {
        static void Main(string[] args)
        {
            PersonFactory personFactory = new PersonFactory();

            Person mark = personFactory.CreatePerson("Mark");

            Person geoff = personFactory.CreatePerson("Geoff");

            Console.WriteLine(mark);
            Console.WriteLine(geoff);
            Console.ReadKey();
        }
    }
}
