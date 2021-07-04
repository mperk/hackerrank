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

    /*
     * Complete the 'minimumBribes' function below.
     *
     * The function accepts INTEGER_ARRAY q as parameter.
     */

    public static string minimumBribes(List<int> q)
    {
        int n = 0;
        for (int i = q.Count -1 ; i >= 0; i--)
        {
            //if an integer move 3 or more position from current index, it bribed more than 2 
            if (q[i] > i + 3 ) return "Too chaotic"; //Too chaotic

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


    class Solution
    {
        public static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());
            var results = new List<string>();
            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> q = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(qTemp => Convert.ToInt32(qTemp)).ToList();

                var result = Result.minimumBribes(q);
                results.Add(result);
            }

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}