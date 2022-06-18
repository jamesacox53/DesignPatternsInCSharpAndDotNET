using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section15Interpreter
{
    internal class CodingChallenge14
    {
        static void Main(string[] args)
        {
            var ep = new ExpressionProcessor();
            ep.Variables.Add('x', 5);

            // 1
            Console.WriteLine(ep.Calculate("1"));

            // 3
            Console.WriteLine(ep.Calculate("1+2"));

            // 6
            Console.WriteLine(ep.Calculate("1+x"));

            // 0
            Console.WriteLine(ep.Calculate("1+xy"));

            // 6
            Console.WriteLine(ep.Calculate("1+2+3"));

            // 0
            Console.WriteLine(ep.Calculate("1+2+xy"));


            ep.Variables.Add('y', 3);
            
            // 5
            Console.WriteLine(ep.Calculate("10-2-y"));

            Console.ReadKey();
        }
    }
}
