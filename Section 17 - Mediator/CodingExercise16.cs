using System;

namespace Section17Mediator
{
    internal class CodingExercise16
    {
        static void Main(string[] args)
        {
            Test1();
        }

        static void Test1()
        {
            Mediator mediator = new Mediator();
            var p1 = new Participant(mediator);
            var p2 = new Participant(mediator);

            Console.WriteLine($"p1 Value: {p1.Value} should be 0");
            Console.WriteLine($"p2 Value: {p2.Value} should be 0");

            p1.Say(2);

            Console.WriteLine($"p1 Value: {p1.Value} should be 0");
            Console.WriteLine($"p2 Value: {p2.Value} should be 2");

            p2.Say(4);

            Console.WriteLine($"p1 Value: {p1.Value} should be 4");
            Console.WriteLine($"p2 Value: {p2.Value} should be 2");
            Console.ReadKey();
        }
    }

}
