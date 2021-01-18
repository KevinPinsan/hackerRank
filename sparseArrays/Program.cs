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

namespace sparseArrays
{
    class Solution {

        static int[] matchingStrings(string[] strings, string[] queries) {
            int counter = 0;
            int[] results = new int[queries.Count()];
            for(int i = 0; i < queries.Count(); i++)
            {
                for(int j = 0; j < strings.Count(); j++)
                {
                    if(queries[i].Equals(strings[j]))
                    {
                        counter++;
                        
                    }
                }
                results[i] = counter;
                counter = 0;
            }
            
            return results;
        
        }

        static void Main(string[] args) {
            int stringsCount = Convert.ToInt32(Console.ReadLine());

            string[] strings = new string [stringsCount];

            for (int i = 0; i < stringsCount; i++) {
                string stringsItem = Console.ReadLine();
                strings[i] = stringsItem;
            }

            int queriesCount = Convert.ToInt32(Console.ReadLine());

            string[] queries = new string [queriesCount];

            for (int i = 0; i < queriesCount; i++) {
                string queriesItem = Console.ReadLine();
                queries[i] = queriesItem;
            }

            int[] res = matchingStrings(strings, queries);

            Console.WriteLine(string.Join("\n", res));
        }
    }
}
