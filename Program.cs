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
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int d = Convert.ToInt32(firstMultipleInput[1]);

            List<int> expenditure = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(expenditureTemp => Convert.ToInt32(expenditureTemp)).ToList();

            int result = activityNotifications(expenditure, d);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int activityNotifications(List<int> expenditure, int d)
        {
            int notification = 0;
            for (int i = 0; i < expenditure.Count - d - 1; i++)
            {
                var subDays = expenditure.GetRange(i, d);
                var sortedList = new SortedList(subDays.Distinct().ToDictionary(x => x));
                int median = 0;
                if (d % 2 == 0)
                {
                    _ = sortedList[d / 2];
                    median = (subDays[d / 2] + subDays[d / 2 + 1]) / 2;
                }
                else
                {
                    median = subDays[d / 2 + 1];
                }

                if (expenditure[i + d] < median * 2)
                {
                    notification++;
                }
            }
            return notification;
        }

        static int activityNotifications2(List<int> expenditure, int d)
        {
            int notification = 0;
            for (int i = 0; i < expenditure.Count - d - 1; i++)
            {
                var subDays = expenditure.GetRange(i, d);
                subDays.Sort();
                int median = 0;
                
                if(d % 2 == 0)
                {
                    median = (subDays[d / 2] + subDays[d / 2 + 1]) / 2;
                }
                else
                {
                    median = subDays[d / 2 + 1];
                }

                if (expenditure[d] < median * 2)
                {
                    notification++;
                }
            }
            return notification;
        }

        static int maximumToys(List<int> prices, int k)
        {
            prices.Sort();
            int count = 0;
            int total = 0;
            foreach (var item in prices)
            {
                int temp = total + item;
                if (temp < k) 
                {
                    total += item;
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }

        static void countSwaps(List<int> a)
        {
            int count = 0;
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < a.Count - 1; j++)
                {
                    // Swap adjacent elements if they are in decreasing order
                    if (a[j] > a[j + 1])
                    {
                        var temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        count++;
                    }
                }
            }
            Console.WriteLine($"Array is sorted in {count} swaps.");
            Console.WriteLine($"First Element: {a[0]}");
            Console.WriteLine($"Last Element: {a[a.Count - 1]}");
        }

        static long countTriplets3(List<long> arr, long r)
        {
            //var d1 = arr.Distinct().ToDictionary(Key => Key, Value => 0L);
            var pairs = arr.Distinct().ToDictionary(Key => Key, Value => new long[] { 0, 0, 0 });
            //var triplets = new Dictionary<long, long[]>();
            long triplets = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                var current = arr[i];
                if (pairs.ContainsKey(arr[i] / r)) pairs[current / r][0] = current;
                if (current % r == 0)
                {
                    var candidates = pairs.Select(x => x.Value)?.Where(x => x[0] == (current / r));
                    foreach (var item in candidates)
                    {
                        item[1] = current;
                        ++item[2];
                    }
                }
            }

            var result = pairs.Where(x => x.Value[0] != 0 && x.Value[1] != 0).Sum(x => x.Value[2]);
            return result;
        }

        private static long countTriplets(List<long> arr, long r)
        {
            long count = 0;
            var d1 = arr.Distinct().ToDictionary(Key => Key, Value => 0L); // count occurrence of value in array
            var d2 = new Dictionary<long, long>(d1); // 

            foreach (var i in arr.Reverse<long>())
            {
                long ir = i * r;

                if (d2.TryGetValue(ir, out long d2ir)) count += d2ir;

                if (d1.TryGetValue(ir, out long d1ir)) d2[i] += d1ir;

                d1[i]++;
            }

            return count;
        }

        static long countTriplets2(List<long> arr, long r)
        {
            var pairs = new Dictionary<long, long[]>();
            long triplets = 0;

            foreach (var n in arr)
            {
                if (!pairs.ContainsKey(n))
                {
                    pairs.Add(n, new long[] { 0, 0 });
                }

                if (n % r == 0 && pairs.ContainsKey(n / r))
                {
                    var prevPair = pairs[n / r];
                    triplets += prevPair[1];
                    pairs[n][1] += prevPair[0];
                }

                pairs[n][0]++;
            }

            return triplets;
        }

        static long countTriplets4(List<long> arr, long r)
        {
            var pairs = arr.Distinct().ToDictionary(Key => Key, Value => new long[] { 0, 0 });
            long triplets = 0;

            foreach (var n in arr)
            {
                if (n % r == 0 && pairs.ContainsKey(n / r))
                {
                    var prevPair = pairs[n / r];
                    triplets += prevPair[1];
                    pairs[n][1] += prevPair[0];
                }
                pairs[n][0]++;
            }

            return triplets;
        }

        public static int sherlockAndAnagrams(string s)
        {
            return 0;
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