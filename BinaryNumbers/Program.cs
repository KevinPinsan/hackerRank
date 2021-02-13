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

class Solution {
    
    static List<int> getBinary(int n){
        List<int> resto = new List<int>();
        while(true){
            if(n >= 2){
                resto.Add(n%2);
                n = n/2;
            }else{
                resto.Add(n);
                break;
            }
        }  
        return resto;      
    }

    static int consecutiveNumberOne(List<int> resto){
        List<int> consecutiveOne = new List<int>();
        int cont = 0;
        int restoCount = resto.Count();
      
        for(int i = 0; i < restoCount; i++){
            if(resto[i] == 1){
                cont += 1;
                consecutiveOne.Add(cont);
            }else if(resto[i] == 0){
                cont = 0;
            }
        }
        
        cont = consecutiveOne.Max();
        return cont;   
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        List<int> resto = new List<int>();
        resto = getBinary(n);
        int result = consecutiveNumberOne(resto);
                
        Console.WriteLine(result);
    
    }
}
