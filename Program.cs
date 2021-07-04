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
using hackerrank;

class Result
{
    class Solution
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            int res = minimumSwaps(arr);
            Console.WriteLine(res);
            Console.ReadKey();
        }

        static int minimumSwaps(int[] arr)
        {
            int n = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                n = recursiveSwap(arr, i, n);
            }
            return n;
        }

        static int recursiveSwap(int[] arr, int i, int n)
        {
            if (arr[i] != i + 1)
            {
                int temp = arr[i];
                arr[i] = arr[temp - 1];
                arr[temp - 1] = temp;
                n++;
                if (arr[i] != i + 1)
                {
                    n = recursiveSwap(arr, i, n);
                }
            }
            return n;
        }

        static string minimumBribes(List<int> q)
        {
            int n = 0;
            for (int i = q.Count - 1; i >= 0; i--)
            {
                //if an integer move 3 or more position from current index, it bribed more than 2 
                if (q[i] > i + 3) return "Too chaotic"; //Too chaotic

                // We need to count how many times RECEIVED bribed. Give a bribe is not important anymore
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                {
                    if (q[j] > q[i])
                    {
                        n++;
                    }

                }
            }
            return n.ToString();
        }

    }
}