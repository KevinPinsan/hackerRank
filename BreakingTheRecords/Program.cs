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

class Solution {

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores, int scoreCount) {

        int max, min, countMax, countMin;
        int [] result = new int[2];
        
        max = scores[0];
        min = scores[0];
        countMin = 0;
        countMax = 0;
        
        
        for(int i = 1; i < scoreCount; i++){
            if( scores[i] > max){
                countMax++;
                max = scores[i];
            }else if(scores[i] < min){
                countMin++;
                min = scores[i];
            }
        }
        
        result[0] = countMax;
        result[1] = countMin;
        
        return result;        

    }

    static void Main(string[] args) {

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores, n);

        Console.WriteLine(string.Join(" ", result));
    }
}
