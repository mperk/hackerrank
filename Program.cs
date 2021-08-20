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


public static class Extensions
{
    public static void AddSorted<T>(this List<T> list, T value)
    {
        int x = list.BinarySearch(value);
        list.Insert((x >= 0) ? x : ~x, value);
    }
}

class Solution
{
    static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = pairs(k, arr);

        //foreach (var result in results)
        //{
        //    Console.WriteLine(result);
        //}
        Console.WriteLine(result);
        //Console.ReadLine();
    }

    static int pairs(int k, List<int> arr)
    {
        int count = 0;
        var dic = arr.Distinct().Select((x, i) => new { item = x, index = i }).ToDictionary(x => x.item, x => x.index);
        for (int i = 0; i < arr.Count; i++)
        {
            if(dic.ContainsKey(arr[i] - k))
            {
                count++;
            }
        }
        return count;
    }

    static void whatFlavors(List<long> cost, long money)
    {
        var dic = new Dictionary<long, long>();
        for (int i = 0; i < cost.Count; i++)
        {
            long diff = money - cost[i];
            if (dic.ContainsKey(diff))
            {
                Console.WriteLine($"{dic[diff] + 1} {i + 1}");
                return;
            }
            //dic.Add(cost[i], i);
            dic[cost[i]] = i;
        }
    }

    static string whatFlavorsNotEfficient(List<int> cost, int money)
    {
        for (int i = 0; i < cost.Count - 1; i++)
        {
            int index = cost.IndexOf(money - cost[i], i + 1);
            if(index > -1)
            {
                return $"{i + 1} {index + 1}";
            }
        }
        return string.Empty;
    }

    static int maxMin(int k, List<int> arr)
    {
        arr.Sort();
        int result = Int32.MaxValue;
        for (int i = 0; i <= arr.Count() - k; i++)
        {
            result = Math.Min(result, arr[i + k - 1] - arr[i]);
        }
        return result;
    }

    static int getMinimumCost(int k, int[] c)
    {
        var kDic = new Dictionary<int, int[]>();
        for (int i = 0; i < k; i++)
        {
            kDic.Add(i, new int[] { 0, 0 });
        }

        var cReverse = c.OrderByDescending(x => x).ToArray();
        for (int i = 0; i < c.Length; i++)
        {
            var element = kDic[i % k];
            if(element[0] == 0)
            {
                element[1] = cReverse[i];
            }
            else
            {
                element[1] += (element[0] + 1) * cReverse[i];
            }
            element[0]++;
        }

        var total = kDic.Sum(x => x.Value[1]);
        return total;
    }

    static int luckBalance(int k, List<List<int>> contests)
    {
        int luck = 0;
        var importants = contests.Where(x => x.Last() == 1).Select(x => x.First()).OrderByDescending(x => x).ToList();
        var unimportantsSum = contests.Where(x => x.Last() == 0).Sum(x => x.First());
        if(k > importants.Count())
        {
            k = importants.Count();
        }
        for (int i = 0; i < k; i++)
        {
            luck += importants[i];
        }
        for (int i = k; i < importants.Count(); i++)
        {
            luck -= importants[i];
        }
        luck += unimportantsSum;
        return luck;
    }

    static int minimumAbsoluteDifference(List<int> arr)
    {
        arr.Sort();
        int minDifference = Int32.MaxValue;
        for (int i = 0; i < arr.Count - 1; i++)
        {
            int tempDiff = Math.Abs(arr[i] - arr[i + 1]);
            if(tempDiff < minDifference)
            {
                minDifference = tempDiff;
            }

        }
        return minDifference;
    }

    static int commonChildOld(string s1, string s2)
    {
        var commonList = new List<KeyValuePair<char, int>>(); // char and index
        string s1Temp = s1;
        for (int i = 0; i < s2.Length; i++)
        {
            int index = s1.IndexOf(s2[i]);
            if (index > -1)
            {
                if (commonList.Any(x=> x.Value == index))
                {
                    int existingLastIndex = commonList.Where(x => x.Value == index).OrderBy(x => x.Value).Last().Value;
                    int lastIndex = s1.IndexOf(s2[i], existingLastIndex+ 1);
                    if(lastIndex > -1)
                    {
                        commonList.Add(new KeyValuePair<char, int>(s2[i], lastIndex));
                    }
                }
                else
                {
                    commonList.Add(new KeyValuePair<char, int>(s2[i], index));
                }
            }
        }

        var willRemove = new List<int>();
        for (int i = 0; i < commonList.Count() - 1; i++)
        {
            if(commonList[i].Value > commonList[i + 1].Value)
            {
                willRemove.Add(i);
            }
        }

        willRemove.ForEach(x => commonList.RemoveAt(x));

        return commonList.Count();
    }

    static int commonChild(string a, string b)
    {
        int[,] C = new int[a.Length + 1, b.Length + 1]; // (a, b).Length + 1
        for (int i = 0; i < a.Length; i++)
            C[i, 0] = 0;
        for (int j = 0; j < b.Length; j++)
            C[0, j] = 0;
        for (int i = 1; i <= a.Length; i++)
            for (int j = 1; j <= b.Length; j++)
            {
                if (a[i - 1] == b[j - 1])//i-1,j-1
                    C[i, j] = C[i - 1, j - 1] + 1;
                else
                    C[i, j] = Math.Max(C[i, j - 1], C[i - 1, j]);
            }
        return C[a.Length,b.Length];
    }

    static long substrCount(int n, string s)
    {
        long count = 0;
        var slist = new List<KeyValuePair<char, long>>();

        long repeatCount = 1;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == s[i + 1])
            {
                repeatCount++;
            }
            else
            {
                slist.Add(new KeyValuePair<char, long>(s[i], repeatCount));
                repeatCount = 1;
            }
        }
        slist.Add(new KeyValuePair<char, long>(s[s.Length - 1], repeatCount)); //last item

        for (int i = 0; i < slist.Count; i++)
        {
            //this is a formula for same and sequential=> (n * (n+1)) /2
            count += (slist[i].Value * (slist[i].Value + 1)) / 2;
        }

        for (int i = 1; i < slist.Count - 1; i++)
        {
            if(slist[i].Value == 1 && slist[i -1].Key == slist[i+1].Key)
            {
                count += Math.Min(slist[i - 1].Value, slist[i + 1].Value);
            }
        }

        return count;
    }

    static string isValid(string s)
    {
        var sdic = new Dictionary<string, int>();
        foreach (var item in s)
        {
            string items = item.ToString();
            if (sdic.ContainsKey(items))
            {
                sdic[items] += 1;
            }
            else
            {
                sdic.Add(items, 1);
            }
        }
        // insted of dictionary use this
        // s.GroupBy(x => x.ToString()).Select(x=> new {key = x, count = x.Count()})

        var groupCount = sdic.Select(x => x.Value).GroupBy(x => x).Select(x => new { key = x.Key, count = x.Count() });

        if (groupCount.Count() > 2)
        {
            return "NO";
        }
        else if (groupCount.Count() == 2)
        {
            if ((groupCount.First().key == 1 && groupCount.First().count == 1) || (groupCount.Last().key == 1 && groupCount.Last().count == 1))
            {
                return "YES";
            }
            int diff = groupCount.First().key - groupCount.Last().key;
            if (diff == -1 || diff == 1)
            {
                if (groupCount.First().count == 1 || groupCount.Last().count == 1)
                {
                    return "YES";
                }
                else { return "NO"; }
            }
            else
            {
                return "NO";
            }
        }
        return "YES";
    }

    static int alternatingCharacters(string s)
    {
        int adjacent = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == s[i + 1])
            {
                adjacent++;
            }
        }

        return adjacent;
    }

    static int makeAnagram(string a, string b)
    {
        int deletion = 0;
        int common = 0;
        string t = a;
        foreach (var item in b)
        {
            if (!t.Contains(item))
            {
                deletion++;
            }
            else
            {
                common++;
                int ind = t.IndexOf(item);
                t = t.Remove(ind, 1);
            }
        }

        deletion = deletion + (a.Length - common);
        return deletion;
    }

    static long countInversions(List<int> arr)
    {
        long count = 0;
        for (int i = 0; i < arr.Count - 1; i++)
        {
            for (int j = i + 1; j < arr.Count; j++)
            {
                if (arr[i] > arr[j])
                {
                    count++;
                }
            }
        }
        return count;
    }

    static int activityNotifications(List<int> expenditure, int d)
    {
        int notification = 0;
        var sortedSubDays = expenditure.GetRange(0, d).ToList();
        sortedSubDays.Sort();

        for (int i = d; i < expenditure.Count; i++)
        {
            double median = 0.0;
            if (d % 2 == 0)
            {
                median = (sortedSubDays[d / 2] + sortedSubDays[d / 2 - 1]) / 2.0;
            }
            else
            {
                median = sortedSubDays[d / 2];
            }
            if (expenditure[i] >= median * 2)
            {
                notification++;
            }
            sortedSubDays.Remove(expenditure[i - d]);
            sortedSubDays.AddSorted(expenditure[i]);
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

            if (d % 2 == 0)
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
        foreach (var item in s2)
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
