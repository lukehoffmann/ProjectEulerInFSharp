using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerInCSharp
{
    public class EulerProblems
    {
        /// <summary>
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
        /// The sum of these multiples is 23.
        /// </summary>
        public static int EulerProblem1Example()
        {
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
            //The sum of these multiples is 23.
            return Enumerable.Range(0, 10)
                .Where(i => (i.MultipleOf(3) || i.MultipleOf(5)))
                .Sum();
        }

        /// <summary>
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        public static int EulerProblem1()
        {
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
            //The sum of these multiples is 23.
            return Enumerable.Range(0, 1000)
                .Where(i => (i.MultipleOf(3) || i.MultipleOf(5)))
                .Sum();
        }

        /// <summary>
        /// By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
        /// </summary>
        /// <returns></returns>
        public static int EulerProblem2()
        {
            return MathHelpers.FibonacciNumbersLessThan(4000000)
                    .Where(f => f.MultipleOf(2))
                    .Sum();
        }
    }
}
