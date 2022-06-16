using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section11Flyweight
{
    internal class CodingExercise10
    {
        static void Main(string[] args)
        {
            Sentence sentence = new Sentence("hello world");

            sentence[1].Capitalize = true;

            Console.WriteLine(sentence);
            Console.ReadKey();
        }
    }
}
