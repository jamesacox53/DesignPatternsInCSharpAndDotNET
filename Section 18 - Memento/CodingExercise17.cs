using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section18Memento
{
    internal class CodingExercise17
    {
        static void Main(string[] args)
        {
            // SingleTokenTest();
            // TwoTokenTest();
            FiddledTokenTest();
        }

        public static void SingleTokenTest()
        {
            var tm = new TokenMachine();
            var m = tm.AddToken(123);
            tm.AddToken(456);
            tm.Revert(m);
            Console.WriteLine($"Token Count is: {tm.Tokens.Count} and should be 1");
            Console.WriteLine($"Token at 0 has value: {tm.Tokens[0].Value} and should be 123");

            Console.ReadKey();
        }

        public static void TwoTokenTest()
        {
            var tm = new TokenMachine();
            tm.AddToken(1);
            var m = tm.AddToken(2);
            tm.AddToken(3);
            tm.Revert(m);

            Console.WriteLine($"Token Count is: {tm.Tokens.Count} and should be 2");
            Console.WriteLine($"Token at 0 has value: {tm.Tokens[0].Value} and should be 1");
            Console.WriteLine($"Token at 1 has value: {tm.Tokens[1].Value} and should be 2");

            Console.ReadKey();
        }

        public static void FiddledTokenTest()
        {
            var tm = new TokenMachine();
            Console.WriteLine("Made a token with value 111 and kept a reference");
            var token = new Token(111);
            Console.WriteLine("Added this token to the list");
            tm.AddToken(token);
            var m = tm.AddToken(222);
            Console.WriteLine("Changed this token's value to 333 :)");
            token.Value = 333;
            tm.Revert(m);

            Console.WriteLine($"Token Count is: {tm.Tokens.Count} and should be 2");
            Console.WriteLine($"Token at 0 has value: {tm.Tokens[0].Value} and should be 111");

            Console.ReadKey();
        }
    }
}

