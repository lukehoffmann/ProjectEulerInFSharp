using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerInCSharp
{
    public class Solutions
    {
        public Int32 SumOfMultiplesOfThreeOrFive(Int32 below)
        {
            //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
            //The sum of these multiples is 23.
            //Find the sum of all the multiples of 3 or 5 below 1000.
            if (below < 1) { throw new ArgumentOutOfRangeException(); };
       
            Int32 result = 0;
            for (Int32 i = 1; i < below; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
    }
}
