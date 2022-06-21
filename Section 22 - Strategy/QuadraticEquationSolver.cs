using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Section22Strategy
{
    public interface IDiscriminantStrategy
    {
        double CalculateDiscriminant(double a, double b, double c);
    }

    public class OrdinaryDiscriminantStrategy : IDiscriminantStrategy
    {
        public double CalculateDiscriminant(double a, double b, double c)
        {
            return ((b * b) - (4 * a * c));
        }
    }

    public class RealDiscriminantStrategy : IDiscriminantStrategy
    {
        public double CalculateDiscriminant(double a, double b, double c)
        {
            double discriminant = ((b * b) - (4 * a * c));

            if (discriminant < 0) return double.NaN;

            return discriminant;
        }
    }

    public class QuadraticEquationSolver
    {
        private readonly IDiscriminantStrategy strategy;

        public QuadraticEquationSolver(IDiscriminantStrategy strategy)
        {
            this.strategy = strategy;
        }

        public Tuple<Complex, Complex> Solve(double a, double b, double c)
        {
            double discriminant = strategy.CalculateDiscriminant(a, b, c);

            if (discriminant == double.NaN)
                return NaNTuple();

            Complex complexDiscriminant = new Complex(discriminant, 0);
            Complex discriminantSqrtd = Complex.Sqrt(complexDiscriminant);

            Complex res1 = ((-b) + discriminantSqrtd) / (2 * a);
            Complex res2 = ((-b) - discriminantSqrtd) / (2 * a);

            return new Tuple<Complex, Complex>(res1, res2);
        }

        private Tuple<Complex, Complex> NaNTuple()
        {
            Complex res1 = new Complex(double.NaN, double.NaN);
            Complex res2 = new Complex(double.NaN, double.NaN);

            return new Tuple<Complex, Complex>(res1, res2);
        }
    }
}
