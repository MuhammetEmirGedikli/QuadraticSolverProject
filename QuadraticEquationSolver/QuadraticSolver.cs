using System;

namespace QuadraticEquationSolver
{
    public static class QuadraticSolver
    {
        public static (double[] solutions, string resultMessage) SolveEquation(double a, double b, double c)
        {
            if (Math.Abs(a) < 1e-10) // Check if 'a' is effectively zero
            {
                return (Array.Empty<double>(), "The equation is not quadratic.");
            }

            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            if (discriminant > 0)
            {
                double firstRoot = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double secondRoot = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return (new[] { firstRoot, secondRoot }, "The equation has two distinct real roots.");
            }
            else if (Math.Abs(discriminant) < 1e-10) // Discriminant is zero
            {
                double singleRoot = -b / (2 * a);
                return (new[] { singleRoot }, "The equation has one real root.");
            }
            else
            {
                return (Array.Empty<double>(), "The equation has no real roots.");
            }
        }
    }
}
