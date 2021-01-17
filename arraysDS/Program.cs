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
namespace arraysDS
{

    class Solution {

        static int[] reverseArray(int[] a, int arrCount) {
            int[] reversedArray = new int [arrCount];
            int cont = arrCount;
            for(int c = 0; c < arrCount; c++)
            {
                reversedArray[cont-1] = a[c]; 
                cont --;   
            }
            return reversedArray;
        }

        static void Main(string[] args) {

            int arrCount = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int[] res = reverseArray(arr, arrCount);

            Console.WriteLine(string.Join(" ", res));
        }
    }

}
