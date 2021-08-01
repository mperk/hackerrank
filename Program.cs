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
            int q = Convert.ToInt32(Console.ReadLine().Trim());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();

                string result = twoStrings(s1, s2);

                Console.WriteLine(result);
            }
            Console.ReadLine();
        }

        public static string twoStrings(string s1, string s2)
        {
            string result = "NO";
            Dictionary<char, short> s1Dic = new Dictionary<char, short>();
            foreach (var item in s1)
            {
                if (s1Dic.ContainsKey(item))
                {
                    s1Dic[item] += 1;
                }
                else
                {
                    s1Dic.Add(item, 1);
                }
            }
            foreach(var item in s2)
            {
                if (s1Dic.ContainsKey(item))
                {
                    if (s1Dic[item] > 0)
                    {
                        result = "YES";
                        return result;
                    }
                }
            }
            return result;
        }

        static string checkMagazine(List<string> magazine, List<string> note)
        {
            Dictionary<string, int> dicMagazine = new Dictionary<string, int>();
            foreach (var item in magazine)
            {
                if (!dicMagazine.ContainsKey(item))
                    dicMagazine.Add(item, 1);
                else dicMagazine[item] += 1;
            }

            foreach (var item in note)
            {
                if (dicMagazine.ContainsKey(item))
                {
                    if (dicMagazine[item] > 0)
                    {
                        dicMagazine[item] -= 1;
                    }
                    else
                    {
                        return "No";
                    }
                }
                else
                {
                    return "No";
                }
            }
            return "Yes";
        }

        public static string checkMagazine2(List<string> magazine, List<string> note)
        {
            foreach (var item in note)
            {
                if (magazine.Remove(item) == false)
                {
                    return "No";
                }
            }
            return "Yes";
        }

        // not work
        static long arrayManipulation(int n, List<List<int>> queries)
        {
            var result = new long[n, n];
            long max = 0;
            for (int i = 0; i < queries.Count; i++)
            {
                int k = i + 1;
                for (int j = queries[i][0] - 1; j < queries[i][1]; j++)
                {
                    if (result[k - 1, j] == 0 && i != 0)
                    {
                        int z = k - 1;
                        while (z >= 1 && result[z, j] == 0)
                        {
                            z--;
                        }
                        result[k, j] = result[z, j] + queries[i][2];
                    }
                    else
                    {
                        result[k, j] = result[k - 1, j] + queries[i][2];
                    }
                    if (result[k, j] > max) max = result[k, j];
                }
            }
            return max;
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