using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section19NullObject
{
    internal class CodingExercise18
    {
        static void Main(string[] args)
        {
            // SingleCallTest();
            ManyCallsTest();
        }

        public static void SingleCallTest()
        {
            var a = new Account(new NullLog());
            a.SomeOperation();
            Console.ReadKey();
        }

        public static void ManyCallsTest()
        {
            var a = new Account(new NullLog());
            for (int i = 0; i < 100; ++i)
                a.SomeOperation();

            Console.ReadKey();
        }

    }
}
