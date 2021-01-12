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


namespace compareTheTriplets
{
    
    class Solution {

        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b) {
                
                List<int> total = new List<int>();
                int pontosA = 0;
                int pontosB = 0;
                for(int c = 0; c < a.Count; c++)
                {
                    if(a[c] > b[c])
                    {
                        pontosA++;
                    }
                    else if(a[c] < b[c])
                    {
                        pontosB++;
                    }
                }
                
                total.Add(pontosA);
                total.Add(pontosB);        
                return total;

        }

        static void Main(string[] args) {

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
