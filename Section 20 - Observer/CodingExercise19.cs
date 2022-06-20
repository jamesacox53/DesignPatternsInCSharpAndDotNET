using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section20Observer
{
    internal class CodingExercise19
    {
        static void Main(string[] args)
        {
            // SingleRatTest();
            // TwoRatTest();
            ThreeRatsOneDies();
        }
       
        public static void SingleRatTest()
        {
            var game = new Game();
            var rat = new Rat(game);
            Console.WriteLine($"Rat Attack is {rat.Attack} and should be 1");
            Console.ReadKey();
        }
        
        public static void TwoRatTest()
        {
            var game = new Game();
            var rat1 = new Rat(game);
            var rat2 = new Rat(game);
            Console.WriteLine($"Rat1 Attack is {rat1.Attack} and should be 2");
            Console.WriteLine($"Rat2 Attack is {rat2.Attack} and should be 2");
            Console.ReadKey();
        }

        public static void ThreeRatsOneDies()
        {
            var game = new Game();

            var rat1 = new Rat(game);
            Console.WriteLine($"Rat1 Attack is {rat1.Attack} and should be 1");

            var rat2 = new Rat(game);
            Console.WriteLine($"Rat1 Attack is {rat1.Attack} and should be 2");
            Console.WriteLine($"Rat2 Attack is {rat2.Attack} and should be 2");
            
            using (var rat3 = new Rat(game))
            {
                Console.WriteLine($"Rat1 Attack is {rat1.Attack} and should be 3");
                Console.WriteLine($"Rat2 Attack is {rat2.Attack} and should be 3");
                Console.WriteLine($"Rat3 Attack is {rat3.Attack} and should be 3");
            }

            Console.WriteLine($"Rat1 Attack is {rat1.Attack} and should be 2");
            Console.WriteLine($"Rat2 Attack is {rat2.Attack} and should be 2");
            Console.ReadKey();
        }
    }
}
