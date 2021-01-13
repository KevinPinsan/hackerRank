using System.Collections.Generic;
using System.Linq;
using System;


namespace diagonalDifference
{
    class Result
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int valorAbsoluto = 0;
            int resultadoMatrizA = 0;
            int resultadoMatrizB = 0;
            
            //Calculo esquerda > direita
            for(int c = 0; c < arr.Count() ; c++)
            {
                for(int j = 0; j < arr.Count(); j++)
                {
                    if(c == j)
                    {
                        resultadoMatrizA += arr[c][j];
                    }
                }
            }
            
            //calculo direita > esquerda
            for(int c = 0; c < arr.Count() ; c++)
            {
                for(int j = 0; j < arr.Count(); j++)
                {
                        if(c + j == arr.Count()-1)
                        {
                            resultadoMatrizB += arr[c][j];
                        }
                }
            }
            valorAbsoluto = Math.Abs(resultadoMatrizA - resultadoMatrizB);
            return valorAbsoluto;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

            Console.WriteLine(result);
        }
    }
}
