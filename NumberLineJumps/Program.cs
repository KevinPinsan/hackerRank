﻿using System.CodeDom.Compiler;
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

class Solution {
    
    static string kangaroo(int x1, int v1, int x2, int v2) {

        string result;        
        
        if((x1 < x2 && v1 < v2) || (x2 < x1 && v2 < v1) || (v1 == v2 && x1 != x2)){
            result = "NO";
        }else{
            if((x2 - x1) % (v2 - v1) == 0) result = "YES";
            else result = "NO";
        }
        return result;            
    }

    static void Main(string[] args) {

        string[] x1V1X2V2 = Console.ReadLine().Split(' ');

        int x1 = Convert.ToInt32(x1V1X2V2[0]);

        int v1 = Convert.ToInt32(x1V1X2V2[1]);

        int x2 = Convert.ToInt32(x1V1X2V2[2]);

        int v2 = Convert.ToInt32(x1V1X2V2[3]);

        string result = kangaroo(x1, v1, x2, v2);

        Console.WriteLine(result);

        
    }
}
