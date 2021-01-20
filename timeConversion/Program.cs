using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static string timeConversion(string s) {

        List<char> fullTime = s.Replace(":", "").Remove(s.Count()-3).ToList();
        string hour = "";
        int convertedHour;
        
        for(int c = 0; c < 2; c++)
        {
            hour += fullTime[c];
        }
        convertedHour = Int32.Parse(hour);
        
        
        if(s.Contains("PM"))
        {   
            s = s.Remove(s.Count()-2);       
            if(convertedHour != 12)
            {
                convertedHour += 12;
                s = s.Replace(hour, convertedHour.ToString());    
            }            
        }else{
            s = s.Remove(s.Count()-2);
            if(convertedHour == 12)
            {
                s = s.Replace(hour, "00");
            }            
        }
        
        return s;
    }

    static void Main(string[] args) {

        string s = Console.ReadLine();

        string result = timeConversion(s);

        Console.WriteLine(result);
    }
}