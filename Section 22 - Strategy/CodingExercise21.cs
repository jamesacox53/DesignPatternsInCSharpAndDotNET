using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Section22Strategy
{
    internal class CodingExercise21
    {
        static void Main(string[] args)
        {
            // PositiveTestOrdinaryStrategy();
            // PositiveTestRealStrategy();
            // NegativeTestOrdinaryStrategy();
            NegativeTestRealStrategy();
        }

        public static void PositiveTestOrdinaryStrategy()
        {
            var strategy = new OrdinaryDiscriminantStrategy();
            var solver = new QuadraticEquationSolver(strategy);
            var results = solver.Solve(1, 10, 16);
            Console.WriteLine($"Result1 is {GetComplexNumberString(results.Item1)} and should be {GetComplexNumberString(new Complex(-2, 0))}");
            Console.WriteLine($"Result2 is {GetComplexNumberString(results.Item2)} and should be {GetComplexNumberString(new Complex(-8, 0))}");
            Console.ReadKey();
        }

        public static void PositiveTestRealStrategy()
        {
            var strategy = new RealDiscriminantStrategy();
            var solver = new QuadraticEquationSolver(strategy);
            var results = solver.Solve(1, 10, 16);
            Console.WriteLine($"Result1 is {GetComplexNumberString(results.Item1)} and should be {GetComplexNumberString(new Complex(-2, 0))}");
            Console.WriteLine($"Result2 is {GetComplexNumberString(results.Item2)} and should be {GetComplexNumberString(new Complex(-8, 0))}");
            Console.ReadKey();
        }

        public static void NegativeTestOrdinaryStrategy()
        {
            var strategy = new OrdinaryDiscriminantStrategy();
            var solver = new QuadraticEquationSolver(strategy);
            var results = solver.Solve(1, 4, 5);
            Console.WriteLine($"Result1 is {GetComplexNumberString(results.Item1)} and should be {GetComplexNumberString(new Complex(-2, 1))}");
            Console.WriteLine($"Result2 is {GetComplexNumberString(results.Item2)} and should be {GetComplexNumberString(new Complex(-2, -1))}");
            Console.ReadKey();
        }

        public static void NegativeTestRealStrategy()
        {
            var strategy = new RealDiscriminantStrategy();
            var solver = new QuadraticEquationSolver(strategy);
            var results = solver.Solve(1, 4, 5);
            var complexNaN = new Complex(double.NaN, double.NaN);

            Console.WriteLine($"Result1 is {GetComplexNumberString(results.Item1)} and should be {GetComplexNumberString(complexNaN)}");
            Console.WriteLine($"Result2 is {GetComplexNumberString(results.Item2)} and should be {GetComplexNumberString(complexNaN)}");
            Console.ReadKey();
            /*
            Assert.IsTrue(double.IsNaN(results.Item1.Real));
            Assert.IsTrue(double.IsNaN(results.Item1.Imaginary));
            Assert.IsTrue(double.IsNaN(results.Item2.Real));
            Assert.IsTrue(double.IsNaN(results.Item2.Imaginary));
            */
        }

        private static string GetComplexNumberString(Complex complex)
        {
            return $"Real: {complex.Real}, Imag: {complex.Imaginary}";
        }
    }
}
