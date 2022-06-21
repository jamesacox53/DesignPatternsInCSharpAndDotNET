using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section23TemplateMethod
{
    internal class CodingExercise22
    {
        static void Main(string[] args)
        {
            // ImpasseTest();
            // TemporaryMurderTest();
            // DoubleMurderTest();
            PermanentDamageDeathTest();
        }

        public static void ImpasseTest()
        {
            var c1 = new Creature(1, 2);
            var c2 = new Creature(1, 2);
            CardGame game = new TemporaryCardDamageGame(new[] { c1, c2 });
            Console.WriteLine($"Game Combat was {game.Combat(0, 1)} and should have been {-1}");
            Console.WriteLine($"Game Combat was {game.Combat(0, 1)} and should have been {-1}");
            Console.ReadKey();
        }

        public static void TemporaryMurderTest()
        {
            var c1 = new Creature(1, 1);
            var c2 = new Creature(2, 2);
            CardGame game = new TemporaryCardDamageGame(new[] { c1, c2 });
            Console.WriteLine($"Game Combat was {game.Combat(0, 1)} and should have been {1}");
            Console.ReadKey();
        }

        public static void DoubleMurderTest()
        {
            var c1 = new Creature(2, 2);
            var c2 = new Creature(2, 2);
            CardGame game = new TemporaryCardDamageGame(new[] { c1, c2 });
            Console.WriteLine($"Game Combat was {game.Combat(0, 1)} and should have been {-1}");
            Console.ReadKey();
        }

        public static void PermanentDamageDeathTest()
        {
            var c1 = new Creature(1, 2);
            var c2 = new Creature(1, 3);
            CardGame game = new PermanentCardDamage(new[] { c1, c2 });
            Console.WriteLine($"Game Combat was {game.Combat(0, 1)} and should have been {-1}");
            Console.WriteLine($"Game Combat was {game.Combat(0, 1)} and should have been {1}");
            Console.ReadKey();
        }
    }
}
