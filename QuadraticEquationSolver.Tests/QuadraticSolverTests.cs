using System;
using Xunit;
using QuadraticEquationSolver;

namespace QuadraticEquationSolver.Tests
{
    public class QuadraticSolverTests
    {
        [Theory]
        [InlineData(1, -5, 6, new[] { 3.0, 2.0 }, "The equation has two distinct real roots.")]
        [InlineData(1, 4, 4, new[] { -2.0 }, "The equation has one real root.")]
        [InlineData(1, 0, 5, new double[0], "The equation has no real roots.")]
        public void SolveEquation_ValidInput_ReturnsExpectedResults(double a, double b, double c, double[] expectedSolutions, string expectedMessage)
        {
            // Act
            var (solutions, resultMessage) = QuadraticSolver.SolveEquation(a, b, c);

            // Assert
            Assert.Equal(expectedSolutions.Length, solutions.Length);
            Assert.Equal(expectedSolutions, solutions);
            Assert.Equal(expectedMessage, resultMessage);
        }

        [Fact]
        public void SolveEquation_NotQuadratic_ReturnsErrorMessage()
        {
            // Act
            var (solutions, resultMessage) = QuadraticSolver.SolveEquation(0, 3, 7);

            // Assert
            Assert.Empty(solutions);
            Assert.Equal("The equation is not quadratic.", resultMessage);
        }
    }
}
