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

    public static int minimumBribes(List<int> q)
    {
        int n = 0;
        for (int i = 0; i < q.Count; i++)
        {
            int caoticCount = 0;
            for (int j = i + 1; j < q.Count; j++)
            {
                if (q[i] > q[j])
                {
                    n++;
                    caoticCount++;
                }
                if (caoticCount > 2)
                {
                    return -1;
                }
            }
        }
        return n;
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
                if (result == -1)
                {
                    results.Add("Too chaotic");
                }
                else
                {
                    results.Add(result.ToString());
                }
            }

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}