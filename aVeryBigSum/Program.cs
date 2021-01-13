using System.Linq;
using System;

namespace aVeryBigSum
{
    class Solution {
        static long aVeryBigSum(long[] ar) {
                long total = 0;
                
                for(int c = 0; c < ar.Count(); c++)
                {
                    total += ar[c];
                }         
                
                return total;
        }

        static void Main(string[] args) {
            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
            ;
            long result = aVeryBigSum(ar);

            Console.WriteLine(result);
        }
    }

}
