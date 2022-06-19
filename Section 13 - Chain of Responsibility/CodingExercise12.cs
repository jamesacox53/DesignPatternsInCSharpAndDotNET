using System;

namespace Section13ChainOfResponsibility
{
    internal class CodingExercise12
    {
        static void Main(string[] args)
        {
            // Test1();
            // Test2();
            // Test3();
            // Test4();
            Test5();
        }

        static void Test1()
        {
            Game game = new Game();

            Goblin goblin = new Goblin(game);
            game.Creatures.Add(goblin);

            Console.WriteLine(goblin);
            Console.ReadKey();
        }

        static void Test2()
        {
            Game game = new Game();

            Goblin goblin1 = new Goblin(game);
            game.Creatures.Add(goblin1);

            Goblin goblin2 = new Goblin(game);
            game.Creatures.Add(goblin2);


            Console.WriteLine("Goblin1: " + goblin1.ToString());
            Console.WriteLine("Goblin2: " + goblin2.ToString());
            Console.ReadKey();
        }

        static void Test3()
        {
            Game game = new Game();

            Goblin goblin1 = new Goblin(game);
            game.Creatures.Add(goblin1);

            Goblin goblin2 = new Goblin(game);
            game.Creatures.Add(goblin2);

            GoblinKing goblinKing1 = new GoblinKing(game);
            game.Creatures.Add(goblinKing1);


            Console.WriteLine("Goblin1: " + goblin1.ToString());
            Console.WriteLine("Goblin2: " + goblin2.ToString());
            Console.WriteLine("GoblinKing1: " + goblinKing1.ToString());
            Console.ReadKey();
        }

        static void Test4()
        {
            Game game = new Game();

            Goblin goblin1 = new Goblin(game);
            game.Creatures.Add(goblin1);

            Goblin goblin2 = new Goblin(game);
            game.Creatures.Add(goblin2);

            GoblinKing goblinKing1 = new GoblinKing(game);
            game.Creatures.Add(goblinKing1);

            GoblinKing goblinKing2 = new GoblinKing(game);
            game.Creatures.Add(goblinKing2);


            Console.WriteLine("Goblin1: " + goblin1.ToString());
            Console.WriteLine("Goblin2: " + goblin2.ToString());
            Console.WriteLine("GoblinKing1: " + goblinKing1.ToString());
            Console.WriteLine("GoblinKing2: " + goblinKing2.ToString());
            Console.ReadKey();
        }

        static void Test5()
        {
            Game game = new Game();

            Goblin goblin1 = new Goblin(game);
            game.Creatures.Add(goblin1);

            Goblin goblin2 = new Goblin(game);
            game.Creatures.Add(goblin2);

            Console.WriteLine("Goblin1: " + goblin1.ToString());

            game.Creatures.Remove(goblin2);

            Console.WriteLine("Goblin1: " + goblin1.ToString());
            Console.ReadKey();
        }
    }
}
