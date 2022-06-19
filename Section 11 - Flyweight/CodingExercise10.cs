using System;

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
