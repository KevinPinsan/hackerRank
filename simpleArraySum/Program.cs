using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the simpleArraySum function below.
     */
    static int simpleArraySum(int[] ar) {
       int total = 0;
       
       for(int c = 0; c < ar.Length; c++)
       {
          total += ar[c]; 
       }
       
       return total;
    }

    static void Main(string[] args) {

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = simpleArraySum(ar);

        Console.WriteLine(result);
    }
}