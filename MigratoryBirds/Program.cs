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
    
    
    static List<int> getRepeated(List<int> arr)
    {
        int[] ids = {1, 2, 3, 4, 5};
        List<int> repeated = new List<int>();  
              
        foreach(int item in ids)
        {
            if(arr.Contains(item))
            {
                repeated.Add(item);
            }
        }
        
        return repeated;
    }

    static int migratoryBirds(List<int> repeatedID, List<int> arr) {        
        int birdID = 0;
        int birdCounter = 0;
        int larger = 0;
        for(int i =0; i < repeatedID.Count(); i++)
        {
            for(int j = 0; j < arr.Count(); j++)
            {
                if(repeatedID[i] == arr[j])
                {
                    birdCounter++;
                }
            }
            
            if(birdCounter > larger)
            {
                larger = birdCounter;
                birdID = repeatedID[i];
            }
            birdCounter = 0;
        }
        return birdID;

    }
    


    static void Main(string[] args) {

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
         List<int> repeatedId = new List<int>();
         foreach(int item in arr){
            if(item > 5 || item < 1){
                throw new ArgumentException("The bird's id must be between 1 and 5.");
            }
         }
        
        repeatedId = getRepeated(arr);
        int result = migratoryBirds(repeatedId, arr);

        Console.WriteLine(result);
    }
}
