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
namespace _2dArrayDs
{
    class Solution {
        static int hourglassSum(int[][] arr) {
            List <int> listaSoma = new List<int>();
            for(int i = 1; i < 5; i++)
            {
                for(int j = 1; j < 5; j++)
                {
                    int soma = arr[i-1][j-1] + arr[i-1][j] + arr[i-1][j+1] + 
                                                arr[i][j] + 
                                arr[i+1][j-1] + arr[i+1][j] + arr[i+1][j+1];
                    
                    listaSoma.Add(soma);
                }
            }
            return listaSoma.Max();

        }

        static void Main(string[] args) {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++) {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            Console.WriteLine(result);
        }
    }

}
