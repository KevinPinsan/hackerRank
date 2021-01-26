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

    // Complete the countApplesAndOranges function below.
    static void countApplesAndOranges(int startHouse, int endHouse, int appleTree, int orangeTree, int[] applesDistance, int[] orangesDistance, int applesCount, int orangesCount) {
        
        int sum = 0;
           
        for(int i = 0; i < applesCount; i++){
            int applePoint = applesDistance[i] + appleTree;
            if( applePoint >= startHouse && applePoint <= endHouse)
            {
                sum++;      
            }
        }
        Console.WriteLine(sum);
        
        sum = 0;
        for(int i = 0; i < orangesCount; i++){
            int orangePoint = orangesDistance[i] + orangeTree;
            if(orangePoint <= endHouse && orangePoint >= startHouse)
            {
                sum++;
            }
        }
        Console.WriteLine(sum);
    }

    static void Main(string[] args) {
        string[] st = Console.ReadLine().Split(' ');

        int startHouse = Convert.ToInt32(st[0]);

        int endHouse = Convert.ToInt32(st[1]);

        string[] ab = Console.ReadLine().Split(' ');

        int appleTree = Convert.ToInt32(ab[0]);

        int orangeTree = Convert.ToInt32(ab[1]);

        string[] mn = Console.ReadLine().Split(' ');

        int applesCount = Convert.ToInt32(mn[0]);

        int orangesCount = Convert.ToInt32(mn[1]);

        int[] applesDistance = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
        ;

        int[] orangesDistance = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
        ;
        countApplesAndOranges(startHouse, endHouse, appleTree, orangeTree, applesDistance, orangesDistance, applesCount, orangesCount);
    }
}
