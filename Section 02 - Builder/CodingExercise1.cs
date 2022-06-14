using System;

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
