using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section24Visitor
{
    internal class CodingExercise23
    {
        static void Main(string[] args)
        {
            // SimpleAddition();
            ProductOfAdditionAndValue();
        }

        public static void SimpleAddition()
        {
            var simple = new AdditionExpression(new Value(2), new Value(3));
            var ep = new ExpressionPrinter();
            ep.Visit(simple);
            Console.WriteLine($"Expression Printer is \"{ep}\" and should be \"(2+3)\"");
            Console.ReadKey();
        }

        public static void ProductOfAdditionAndValue()
        {
            var expr = new MultiplicationExpression(
              new AdditionExpression(new Value(2), new Value(3)),
              new Value(4)
              );
            var ep = new ExpressionPrinter();
            ep.Visit(expr);
            Console.WriteLine($"Expression Printer is \"{ep}\" and should be \"(2+3)*4\"");
            Console.ReadKey();
        }
    }
}
