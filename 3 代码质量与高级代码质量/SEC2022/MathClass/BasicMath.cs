using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClass
{
    /// <summary>
    /// Th main Basic Math class. Contains all methods for performing basic math functions.
    /// <list type="number">
    /// <item>
    /// <term>Add</term>
    /// <description>Addition Operation</description>
    /// </item>
    /// <item>
    /// <term>Substract</term>
    /// <description>Substraction Operation</description>
    /// </item>
    /// <item>
    /// <term>Multiply</term>
    /// <description>Multiplicaition Operation</description>
    /// </item>
    /// <item>
    /// <term>Divide</term>
    /// <description>Dvision Operation</description>
    /// </item>
    /// </list>
    /// </summary>
    public class BasicMath
    {

        /// <summary>
        /// Add two integers and returns the result
        /// </summary>
        /// <param name="a">An integer</param>
        /// <param name="b">An interger</param>
        /// <returns>The sum of two integers</returns>
        public static int Add(int a, int b)
        {
            if ((a == int.MaxValue && b > 0) || (b == int.MaxValue && a > 0))
            {
                throw new OverflowException();
            }
            return a + b;
        }

        /// <summary>
        /// Add two doubles and returns the result
        /// </summary>
        /// <param name="a">A double precision number</param>
        /// <param name="b">A double precision number</param>
        /// <returns>The sum of two doubles</returns>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Substracts b from a and returns the result
        /// </summary>
        /// <param name="a">An integer</param>
        /// <param name="b">An integer</param>
        /// <example>
        /// <code>
        /// int c = BasicMath.Substract(4, 5);
        /// if (c > 1)
        /// {
        ///     Console.WriteLine(c);
        ///  }
        /// </code>
        /// </example>
        /// <returns>The difference between two integers</returns>
        public static int Substract(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        /// Substracts a double from another double and returns the result
        /// </summary>
        /// <param name="a">A double precision number</param>
        /// <param name="b">A double precision number</param>
        /// <returns>The differences of two doubles</returns>
        public static double Substract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplies two integers and returns the result
        /// </summary>
        /// <param name="a">An integer</param>
        /// <param name="b">An integer</param>
        /// <returns>The product of two integers</returns>
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Multiplies two doubles and returns the result
        /// </summary>
        /// <param name="a">A double precision number</param>
        /// <param name="b">A double precision number</param>
        /// <returns>The product of two doubles</returns>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Divide an integer by another and returns the result
        /// </summary>
        /// <param name="a">An integer dividend</param>
        /// <param name="b">An integer divisor</param>
        /// <exception cref="System.DivideByZeroException">Thrown when <paramref name="b"/> is equal to 0.</exception>
        /// <returns>The quotient of two integers</returns>
        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }

        /// <summary>
        /// Divides a double by another and returns the result
        /// </summary>
        /// <param name="a">A double precision number</param>
        /// <param name="b">A double precision number</param>
        /// <returns>the quotient of two doubles</returns>
        public static double Divide(double a, double b)
        {
            double eps = 0.000000000000001;
            if (Math.Abs(b - 0) < eps)
            {

            }
            return a / b;
        }

        public static void ExecuteRefactor(int a, double b)
        {

        }

    }
}
