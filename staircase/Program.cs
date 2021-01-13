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

namespace staircase
{
    class Solution {

        // Complete the staircase function below.
        static void staircase(int n) {
            for(int c = 1; c <= n; c++)
            {   
                string resultado = new String('#', c);
                string espacos = new String(' ', n - c);
                Console.WriteLine(espacos + resultado);
            }

        }

        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }
    }

}
