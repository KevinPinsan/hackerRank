using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace miniMaxSum
{
    class Solution {

        static void miniMaxSum(int[] arr) {
            
            long min = arr.Min();
            long max = arr.Max();
            
            long maxSum = 0;
            long miniSum = 0;
            for(int c = 0; c < arr.Count(); c++)
            {
                maxSum += arr[c];
                miniSum += arr[c];
            }
            
            maxSum -= min;
            miniSum -= max;
            
            Console.WriteLine($"{miniSum} {maxSum}");       

        }

        static void Main(string[] args) {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            miniMaxSum(arr);
        }
    }

}
