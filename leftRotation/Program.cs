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
using System;
namespace leftRotation
{
class Result
{
    public static List<int> rotateLeft(int d, List<int> arr)
    {
        for(int i = 0; i < d; i++)
        {
            int troca = arr[0];
            arr.RemoveAt(0);
            arr.Insert(arr.Count(), troca);
        }
        return arr;
    }

}

    class Solution
    {
        public static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = Result.rotateLeft(d, arr);

            Console.WriteLine(String.Join(" ", result));
        }
    }

}
