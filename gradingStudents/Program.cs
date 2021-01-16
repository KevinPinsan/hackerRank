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

namespace gradingStudents
{
    class Result
    {

        public static List<int> gradingStudents(List<int> grades, int gradesCount)
        {
            for(int c = 0; c < gradesCount; c++)
            {
                while(grades[c] >= 38 && grades[c] % 5 >= 3)
                {
                    grades[c] ++;
                }
            }
            return grades;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.gradingStudents(grades, gradesCount);
            Console.WriteLine("");
            Console.WriteLine(String.Join("\n", result));
        }
    }

}
