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

namespace plusMinus
{
    class Solution {

        static void plusMinus(int[] arr) {
            int divisor = arr.Count();
            int positivos = 0;
            int negativos = 0;
            int qntZero = 0;
            
            for(int c = 0; c < arr.Count(); c++)
            {
                if(arr[c] > 0)
                {
                    positivos++;
                }            
                else if(arr[c] < 0)
                {
                    negativos++;
                }
                else
                {
                    qntZero++;
                }
            }
            
            double proporcaoPositiva = (double)positivos/divisor;
            double proporcaoNegativa = (double)negativos/divisor;
            double proporcaoZeros = (double)qntZero/divisor;
            
            Console.WriteLine(proporcaoPositiva.ToString("N6"));
            Console.WriteLine(proporcaoNegativa.ToString("N6"));
            Console.WriteLine(proporcaoZeros.ToString("N6"));
        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr);
        }
    }

}
