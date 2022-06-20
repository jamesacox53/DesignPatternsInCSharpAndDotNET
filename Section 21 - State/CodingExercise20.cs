using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section21State
{
    internal class CodingExercise20
    {
        static void Main(string[] args)
        {
            // TestSuccess();
            TestFailure();
        }

        public static void TestSuccess()
        {
            var cl = new CombinationLock(new[] { 1, 2, 3, 4, 5 });
            Console.WriteLine($"Lock status is {cl.Status} and should be \"LOCKED\"");
            cl.EnterDigit(1);
            Console.WriteLine($"Lock status is {cl.Status} and should be \"1\"");
            cl.EnterDigit(2);
            Console.WriteLine($"Lock status is {cl.Status} and should be \"12\"");
            cl.EnterDigit(3);
            Console.WriteLine($"Lock status is {cl.Status} and should be \"123\"");
            cl.EnterDigit(4);
            Console.WriteLine($"Lock status is {cl.Status} and should be \"1234\"");
            cl.EnterDigit(5);
            Console.WriteLine($"Lock status is {cl.Status} and should be \"OPEN\"");
            Console.ReadKey();
        }

        public static void TestFailure()
        {
            var cl = new CombinationLock(new[] { 1, 2, 3 });
            Console.WriteLine($"Lock status is {cl.Status} and should be \"LOCKED\"");
            cl.EnterDigit(1);
            Console.WriteLine($"Lock status is {cl.Status} and should be \"1\"");
            cl.EnterDigit(2);
            Console.WriteLine($"Lock status is {cl.Status} and should be \"12\"");
            cl.EnterDigit(5);
            Console.WriteLine($"Lock status is {cl.Status} and should be \"ERROR\"");
            Console.ReadKey();
        }
    }
}
