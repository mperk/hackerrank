﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using hackerrank;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using hackerrank.csharpCertification;
using System.Numerics;

public static class Extensions
{
    public static void AddSorted<T>(this List<T> list, T value)
    {
        int x = list.BinarySearch(value);
        list.Insert((x >= 0) ? x : ~x, value);
    }
}

public class MaxAndValue
{
    public int Value { get; set; }
    public int Max { get; set; }

    public MaxAndValue(int m, int v)
    {
        Max = m;
        Value = v;
    }
    public MaxAndValue()
    {

    }
}

class Solution
{
    static void Main(string[] args)
    {
        //largestRectangle(new List<int>() { 1, 2, 3, 4, 5 });

        //int w = Convert.ToInt32(Console.ReadLine().Trim());

        //int h = Convert.ToInt32(Console.ReadLine().Trim());

        //int isVerticalCount = Convert.ToInt32(Console.ReadLine().Trim());

        //List<bool> isVertical = new List<bool>();

        //for (int i = 0; i < isVerticalCount; i++)
        //{
        //    bool isVerticalItem = Convert.ToInt32(Console.ReadLine().Trim()) != 0;
        //    isVertical.Add(isVerticalItem);
        //}

        //int distanceCount = Convert.ToInt32(Console.ReadLine().Trim());

        //List<int> distance = new List<int>();

        //for (int i = 0; i < distanceCount; i++)
        //{
        //    int distanceItem = Convert.ToInt32(Console.ReadLine().Trim());
        //    distance.Add(distanceItem);
        //}

        //List<long> result = getMaxArea(w, h, isVertical, distance);

        //Console.WriteLine(String.Join(" ", result));
        //foreach (var result in results)
        //{
        //    Console.WriteLine(result);
        //}
        //Console.WriteLine(result);

        //var r = solutionT1("area,land\n3722,CN\n6612,RU\n3855,CA\n3797,USA", "area");

        //int T = Convert.ToInt32(Console.ReadLine().Trim());
        //var results = new List<string>();
        //for (int TItr = 0; TItr < T; TItr++)
        //{
        //    string w = Console.ReadLine();

        //    string result = biggerIsGreater(w);
        //    results.Add(result);
        //    //Console.WriteLine(result);
        //}
        //Console.WriteLine("---------------Resultssssssssss----------------------");
        //foreach (var result in results)
        //{
        //    Console.WriteLine(result);
        //}


        //lilysHomework(new List<int>() { 12, 15, 13, 11 });

        //minNotOccurPositiveNumber(new List<int>() { 1, 2, 3 }.ToArray());

        //BoundedSlice(2, new List<int>() { 3, 5, 7, 6, 3 }.ToArray());
        //BoundedSlice(0, new List<int>() { 1000000000 , 1000000000 }.ToArray());

        //var a = new Something();

        //Console.WriteLine(OddOccurrencesInArray(new List<int> { 9, 3, 9, 3, 9, 7, 9 }.ToArray()));

        //Console.WriteLine(binary_gap(32));
        //Console.WriteLine(cyclic_rotation(new int[] {  }, 3));

        //Console.WriteLine(frog_jmp(10, 85, 30));

        //Console.WriteLine(perm_missing_elem(new int[] { 2, 3, 1, 5}));

        //Console.WriteLine(tape_equilibrium(new int[] { 3, 1, 2, 4, 3 }));

        //Console.WriteLine(perm_check(new int[] { 4, 1 }));

        //Console.WriteLine(passing_cars(new int[] { 0, 0, 1, 1, 0 }));

        //Console.WriteLine(frog_river_one(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 }));

        //Console.WriteLine(distinct_sort(new int[] { 2, 1, 1, 2, 3, 1 }));

        //Console.WriteLine(max_product_of_three(new int[] { -3, 1, 2, -2, 5, 6 }));

        //Console.WriteLine(triangle(new int[] { 10, 2, 5, 1, 8, 20 }));

        //Console.WriteLine(brackets("{[()()]}"));
        //Console.WriteLine(brackets("{([)()]"));

        //Console.WriteLine(fish(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 1, 0, 0, 0 }));

        //Console.WriteLine(nesting("(()(())())"));

        //Console.WriteLine(dominator(new int[] { 3, 4, 3, 2, 3, -1, 3, 3 }));

        //Console.WriteLine(equi_leader(new int[] {-1,-1}));

        //Console.WriteLine(max_profit(new int[] { 23171, 21011, 21123, 21366, 21013, 21367 }));

        //Console.WriteLine(max_slice_sum(new int[] { 3, 2, -6, 4, 0 }));

        //Console.WriteLine(count_factors(25));

        //Console.WriteLine(min_perimeter_rectangle(30));

        //Console.WriteLine(chocolates_by_numbers(12, 8));

        //Console.WriteLine(abs_distinct(new int[] { -2147483648, 0 }));

        //Console.WriteLine(count_distinct_slices(6, new int[] { 3, 4, 5, 5, 2}));

        //Console.WriteLine(count_triangles(new int[] { 10, 2, 5, 1, 8, 12 }));

        //Console.WriteLine(max_nonoverlapping_segments(new int[] { 1, 3, 7, 9, 9 }, new int[] { 5, 6, 8, 9, 10 }));

        //Console.WriteLine(tie_ropes(4, new int[] { 1, 2, 3, 4, 1, 1, 3 }));

        //Console.WriteLine(challenge_bug_wars(new int[] { 0, 1, 0, 1, 1, 1, 0 }, new int[] { 1, 2, 3, 4, 5, 6, 7 }));

        //Console.WriteLine(Flipgame(new int[] { 1, 1 }, new int[] { 1, 2 }));

        //Console.WriteLine(MinReorder(6, new int[][] { new int[] { 0, 1 }, new int[] { 1, 3 }, new int[] { 2, 3 }, new int[] { 4, 0 }, new int[] { 4, 5 } }));
        //Console.WriteLine(MinReorder(4, new int[][] { new int[] { 0, 1 }, new int[] { 2, 0 }, new int[] { 3,2 } }));



        Console.ReadLine();

    }

    

    static int MinReorder(int n, int[][] connections)
    {
        int reorder = 0;
        var connectionsList = connections.ToList();
        var connected = new List<int[]>();
        var subConnections = connectionsList.Where(x => x[1] == 0).ToList();
        connectionsList = connectionsList.Where(x => x[1] != 0).ToList();
        connected.AddRange(subConnections);
        int i = 0;
        while (connectionsList.Count() > 0)
        {
            if (!connected.Any(x => x[0] == connectionsList[i][1]))
            {
                connected.Add(new int[] { connectionsList[i][1], connectionsList[i][0] });
                connectionsList.RemoveAt(i);
                reorder++;
            }
            else
            {
                connected.Add(new int[] { connectionsList[i][0], connectionsList[i][1] });
                connectionsList.RemoveAt(i);
            }
        }

        return reorder;
    }

    static int calcRecursiveConnections(int goal, int[][] connections)
    {
        int result = 0;
        var subConnections = connections.Where(x => x[1] == goal);
        //result += subConnections.Count();
        foreach (var item in subConnections)
        {
            int t = item[0];
            item[0] = item[1];
            item[1] = item[0];
            result++;
            //result += calcRecursiveConnections(item, connections);
        }
        return result;
    }

    //static int Flipgame(int[] fronts, int[] backs)
    //{
    //    int min = 2001;
    //    for (int i = 0; i < fronts.Length; i++)
    //    {
    //        int temp = Math.Min(fronts[i], backs[i]);
    //        if (fronts[i] < backs[i] && temp < min)
    //        {
    //            int t = fronts[i];
    //            fronts[i] = backs[i];
    //            backs[i] = t;
    //            break;
    //        }
    //    }

    //    HashSet<int> discard = new HashSet<int>();
    //    for (int i = 0; i < fronts.Length; i++)
    //    {
    //        if(fronts[i] == backs[i])
    //        {
    //            discard.Add(backs[i]);
    //        }
    //    }

    //    for (int i = 0; i < backs.Length; i++)
    //    {
    //        int temp = Math.Min(fronts[i], backs[i]);
    //        if (!fronts.Contains(backs[i]) && min > temp && )
    //            min = backs[i];
    //    }


    //    if (min == 2001) return 0;
    //    return min;
    //}

    //static int challenge_bug_wars(int[] A, int[] X)
    //{
    //    int count = 1;
    //    int fuel = 0;
    //    for (int i = 0; i < X.Length - 1; i++)
    //    {
    //        if (A[i] != 0)
    //        {
    //            fuel += A[i];
    //            fuel -= Math.Abs(X[i + 1] - X[i]);
    //            fuel += A[i + 1];
    //            if (fuel > 0) count++;
    //        }
    //    }

    //    return count;
    //}

    static int tie_ropes(int K, int[] A)
    {
        long tempSum = 0;
        int result = 0;
        for (int i = 0; i < A.Length; i++)
        {
            tempSum += A[i];
            if (tempSum >= K)
            {
                tempSum = 0;
                result++;
            }
        }
        return result;
    }

    static int max_nonoverlapping_segments(int[] A, int[] B)
    {
        int nonOverlap = 0;
        int last = -1;
        for (int i = 0; i < A.Length; i++)
        {
            if ((last < 0) || (A[i] > B[last]))
            {
                last = i;
                ++nonOverlap;
            }

        }

        return nonOverlap;
    }

    static int count_triangles(int[] A)
    {
        int triangles = 0;
        Array.Sort(A);
        for (int i = 0; i < A.Length - 2; i++)
        {
            int k = i + 2;
            for (int j = i + 1; j < A.Length - 1; j++)
            {
                while (k < A.Length && A[i] + A[j] > A[k] && A[j] + A[k] > A[i] && A[k] + A[i] > A[j])
                    k++;

                triangles += k - j - 1;

            }
        }
        return triangles;
    }

    static int count_distinct_slices(int M, int[] A)
    {
        // i dont understand the question.
        return 0;
    }

    static int abs_distinct(int[] A)
    {
        HashSet<long> stack = new HashSet<long>();
        for (int i = 0; i < A.Length; i++)
        {
            long abs = Math.Abs((long)A[i]);
            if (!stack.Contains(abs))
                stack.Add(abs);
        }
        return stack.Count;
    }

    static int chocolates_by_numbers(int N, int M)
    {
        return N / gcd_chocolates_by_numbers(N, M);
    }

    //greatest common divisor
    static int gcd_chocolates_by_numbers(int a, int b)
    {
        if (a % b == 0) return b;
        else return gcd_chocolates_by_numbers(b, a % b);
    }

    static int min_perimeter_rectangle(int N)
    {
        int minPerimeter = Int32.MaxValue;
        for (int i = 1; i < Math.Sqrt(N); i++)
        {
            if (N % i == 0)
            {
                int tempPerimeter = 2 * (i + (N / i));
                if (tempPerimeter < minPerimeter) minPerimeter = tempPerimeter;
            }
        }

        var sqrt = Math.Sqrt(N);
        if (sqrt % 1 == 0)
        {
            int sqrtInt = (int)sqrt;
            int tempPerimeter = 2 * (sqrtInt + sqrtInt);
            if (tempPerimeter < minPerimeter) minPerimeter = tempPerimeter;
        }

        return minPerimeter;
    }

    static int count_factors(int N)
    {
        var result = 0;
        for (int i = 1; i < Math.Sqrt(N); i++)
        {
            if (N % i == 0)
                result += 2;
        }

        // check exact square
        if (Math.Sqrt(N) % 1 == 0)
            result++;

        return result;
    }

    static int max_slice_sum(int[] A)
    {
        int max = A[0];
        int previousMax = A[0];
        for (int i = 1; i < A.Length; i++)
        {
            previousMax = Math.Max(A[i], previousMax + A[i]);
            max = Math.Max(previousMax, max);
        }
        return max;
    }

    static int max_profit(int[] A)
    {
        int maxProfit = 0;
        int min = Int32.MaxValue;
        for (int i = 0; i < A.Length; i++)
        {
            min = Math.Min(min, A[i]);
            maxProfit = Math.Max(maxProfit, A[i] - min);
        }
        return maxProfit;
    }

    static int equi_leader(int[] A)
    {
        Dictionary<int, int> equiFirst = new Dictionary<int, int>();
        for (int i = 0; i < A.Length; i++)
        {
            if (equiFirst.ContainsKey(A[i]))
                equiFirst[A[i]]++;
            else
                equiFirst[A[i]] = 1;
        }

        int result = 0;
        Dictionary<int, int> equiSecond = new Dictionary<int, int>();
        for (int i = 0; i < A.Length - 1; i++)
        {
            if (equiSecond.ContainsKey(A[i]))
                equiSecond[A[i]]++;
            else
                equiSecond[A[i]] = 1;

            if (equiFirst.ContainsKey(A[i]))
                equiFirst[A[i]]--;
            //else
            //    equiAll[A[i]] = 0;

            var firstLeader = equiFirst.FirstOrDefault(x => x.Value == equiFirst.Values.Max());
            var secondLeader = equiSecond.FirstOrDefault(x => x.Value == equiSecond.Values.Max());
            if (firstLeader.Key != 0 && secondLeader.Key != 0)
                if (firstLeader.Value > equiFirst.Values.Sum() / 2 && secondLeader.Value > equiSecond.Values.Sum() / 2)
                    if (firstLeader.Key == secondLeader.Key)
                        result++;

        }

        return result;
    }


    static int dominator(int[] A)
    {
        Dictionary<int, int> count = new Dictionary<int, int>();

        for (int i = 0; i < A.Length; i++)
        {
            if (count.ContainsKey(A[i]))
                count[A[i]]++;
            else
                count[A[i]] = 1;
        }
        var result = count.Where(x => x.Value > A.Length / 2).FirstOrDefault();
        return result.Key == 0 ? -1 : Array.IndexOf(A, result.Key);
    }

    static int nesting(string S)
    {
        Stack<string> strings = new Stack<string>();
        Dictionary<string, string> map = new Dictionary<string, string>();
        map.Add("(", ")");
        for (int i = 0; i < S.Length; i++)
        {
            if (S[i].ToString() == "(")
                strings.Push("(");
            else
            {
                if (strings.Count > 0 && strings.Peek() == "(")
                    strings.Pop();
                else
                    return 0;
            }
        }

        if (strings.Count > 0) return 0;
        else return 1;
    }

    static int fish(int[] A, int[] B)
    {
        Stack<int> alives = new Stack<int>();
        for (int i = 0; i < A.Length; i++)
        {
            if (alives.Count == 0)
                alives.Push(i);
            else
            {
                while (alives.Count != 0 && B[i] - B[alives.Peek()] == -1 && A[alives.Peek()] < A[i])
                    alives.Pop();

                if (alives.Count == 0)
                {
                    alives.Push(i);
                }
                else
                {
                    if (B[i] - B[alives.Peek()] != -1)
                        alives.Push(i);
                }
            }
        }
        return alives.Count;
    }

    static int brackets(String S)
    {
        Dictionary<string, string> pairs = new Dictionary<string, string>();
        pairs.Add("{", "}");
        pairs.Add("[", "]");
        pairs.Add("(", ")");
        List<string> set = new List<string>();
        for (int i = 0; i < S.Length; i++)
        {
            if (S[i].ToString() == "{" || S[i].ToString() == "[" || S[i].ToString() == "(")
                set.Add(S[i].ToString());
            else
            {
                if (set.Count == 0) return 0;
                string last = set.LastOrDefault();
                if (S[i].ToString() != pairs[last])
                    return 0;
                set.RemoveAt(set.Count - 1);
            }
        }
        if (set.Count > 0) return 0;
        else return 1;
    }

    static int triangle(int[] A)
    {
        /** https://stackoverflow.com/a/53144072/3110319
         * Since the array is sorted A[i + 2] is always greater or equal to previous values
         * So A[i + 2] + A[i] > A[i + 1] ALWAYS
         * As well ass A[i + 2] + A[i + 1] > A[i] ALWAYS
         * Therefore no need to check those. We only need to check if A[i] + A[i + 1] > A[i + 2]?
         * Since in case of A[i] + A[i + 1] > MAXINT the code would strike an overflow (ie the result will be greater than allowed integer limit)
         * We'll modify the formula to an equivalent A[i] > A[i + 2] - A[i + 1]
         * And inspect it there
         */

        if (A.Length < 3) return 0;
        Array.Sort(A);
        for (int i = 0; i < A.Length - 2; i++)
        {
            if (A[i] + A[i + 1] > A[i + 2])
                return 1;
        }
        return 0;
    }

    static int max_product_of_three(int[] A)
    {
        int count = A.Length;
        if (count == 3) return A.Aggregate((x, y) => x * y);
        var l = A.ToList();
        l.Sort();
        int max1 = l[count - 3] * l[count - 2] * l[count - 1];
        int max2 = l[0] * l[1] * l[count - 1];
        if (max1 > max2) return max1;
        else return max2;
    }

    static int distinct_sort(int[] A)
    {
        return A.Distinct().Count();
    }

    static int frog_river_one(int X, int[] A)
    {
        var temp = new HashSet<int>();
        for (int i = 0; i < A.Length; i++)
        {
            if (!temp.Contains(A[i]))
            {
                temp.Add(A[i]);
                if (temp.Count == X) { return i; }
            }
        }
        return -1;
    }

    static int passing_cars(int[] A)
    {
        int max = 1000000000;
        var eCount = 0;
        var pairsCount = 0;

        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == 0)
            {
                eCount++;
            }
            else
            {
                pairsCount += eCount;
                if (pairsCount > max) return -1;
            }
        }

        return pairsCount;
    }

    public static int perm_check(int[] A)
    {
        if (A.Length == 0) return 0;
        if (A.Length == 1 && A[0] != 1) return 0;
        else if (A.Length == 1 && A[0] == 1) return 1;

        var l = A.ToList();
        l.Sort();
        if (l[0] != 1) return 0;
        for (int i = 0; i < l.Count - 1; i++)
        {
            if (l[i + 1] - l[i] != 1) return 0;
        }

        return 1;
    }

    public static int tape_equilibrium(int[] A)
    {
        long first = A[0];
        long second = A.Skip(1).Sum();
        int min = (int)Math.Abs(first - second);
        for (int i = 1; i < A.Length - 1; i++)
        {
            first += A[i];
            second -= A[i];
            var diff = (int)Math.Abs(first - second);
            if (diff < min) min = diff;
        }

        return min;
    }

    public static int perm_missing_elem(int[] A)
    {
        long n = A.Length + 1;
        long sum = (n * (n + 1)) / 2;
        long sumA = A.Sum(v => (long)v);
        int miss = (int)(sum - sumA);
        return miss;
    }

    public static int frog_jmp(int X, int Y, int D)
    {
        if ((Y - X) % D == 0) return (Y - X) / D;
        else return (Y - X) / D + 1;
    }

    public static int[] cyclic_rotation(int[] A, int K)
    {
        if (A.Count() == 0) return A;
        List<int> aList = new List<int>(A);
        for (int i = 0; i < K; i++)
        {
            int t = aList.Last();
            aList.Insert(0, t);
            aList.RemoveAt(aList.Count - 1);
        }
        return aList.ToArray();
    }

    public static int binary_gap(int N)
    {
        int result = 0;

        result = Convert.ToString(N, 2)
            .Trim('0')
            .Split(new[] { '1' })
            .Max(x => x.Length);

        return result;
    }

    public static int OddOccurrencesInArray(int[] A)
    {
        var odd = A.GroupBy(x => x).First(x => x.Count() % 2 == 1).Key;
        return odd;
    }

    static int GetTopSecret(Something something)
    {
        var bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance;
        var field = something.GetType().GetField("topSecretValue", bindingFlags);
        var result = (int)field?.GetValue(something);
        return result;
    }

    public sealed class Something
    {
        public Something()
        {
            topSecretValue = 42;
        }
        private int topSecretValue;
    }

    static int BoundedSlice(int K, int[] A)
    {
        int result = 0;
        //var resultList = new List<(int, int)>();
        for (int i = 0; i < A.Length; i++)
        {
            int last = i + K > A.Length - 1 ? A.Length - 1 : i + K;
            for (int j = i; j <= last; j++)
            {
                if (Math.Abs(A[i] - A[j]) <= K)
                    result++;
            }
        }

        return result;
    }

    static int minNotOccurPositiveNumber(int[] A)
    {
        var positive = A.Where(x => x > 0).ToArray();
        Array.Sort(positive);

        int result = 1;
        for (int i = 0; i < positive.Length; i++)
        {
            if (result < positive[i]) return result;
            result = positive[i] + 1;
        }
        return result;
    }

    static int lilysHomework(List<int> arr)
    {
        var sortedArr = new List<int>(arr);
        sortedArr.Sort();
        int count = 0;

        var tempArr = new List<int>(arr);
        for (int i = 0; i < arr.Count; i++)
        {
            if (sortedArr[i] == arr[i])
                continue;
            int index = sortedArr.IndexOf(arr[i]);

            int temp = tempArr[index];
            tempArr[index] = arr[i];
            tempArr[i] = temp;
            count++;
        }

        return count;
    }

    static void almostSorted(List<int> arr)
    {
        //almostSorted(new List<int> { 1, 5, 4, 3, 2, 6 });
        //almostSorted(new List<int> { 2, 3, 5, 7, 41, 13, 17, 19, 23, 29, 31, 37, 11 });
        //almostSorted(new List<int> { 3,1,2 });
        int startIndex = -1;
        int endIndex = -1;

        for (int i = 0; i < arr.Count - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                startIndex = i;
                break;
            }
        }

        if (startIndex == -1)
        {
            Console.WriteLine("yes");
            return;
        }

        for (int i = arr.Count - 1; i > 0; i--)
        {
            if (arr[i] < arr[i - 1])
            {
                endIndex = i;
                break;
            }
        }



        var copyArr = new List<int>(arr);
        int temp = arr[startIndex];
        arr[startIndex] = arr[endIndex];
        arr[endIndex] = temp;

        bool trySwap = false;
        for (int i = 0; i < arr.Count - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                trySwap = true;
                break;
            }
        }

        if (trySwap)
        {
            if (startIndex == 0 && endIndex == arr.Count - 1)
            {
                Console.WriteLine("no");
                return;
            }

            var reverse = copyArr.GetRange(startIndex, endIndex - startIndex + 1);
            reverse.Reverse();
            var firstPart = copyArr.GetRange(0, startIndex);
            firstPart.AddRange(reverse);
            var lastPart = copyArr.GetRange(endIndex + 1, arr.Count - endIndex - 1);
            firstPart.AddRange(lastPart);
            for (int i = 0; i < firstPart.Count - 1; i++)
            {
                if (firstPart[i] > firstPart[i + 1])
                {
                    Console.WriteLine("no");
                    return;
                }
            }
            Console.WriteLine("yes");
            Console.WriteLine($"reverse {startIndex + 1} {endIndex + 1}");
        }
        else
        {
            Console.WriteLine("yes");
            Console.WriteLine($"swap {startIndex + 1} {endIndex + 1}");
            return;
        }
    }

    static int queensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
    {
        int result = 0;

        int cross1 = Math.Min(r_q - 1, n - c_q);
        cross1 += Math.Min(n - r_q, c_q - 1);

        int cross2 = n - Math.Max(r_q, c_q);
        cross2 += Math.Min(r_q, c_q) - 1;

        //int cross1 = n - Math.Max(r_q, c_q);
        //cross1 += Math.Min(r_q, c_q) - 1;

        //int cross2 = Math.Min(n - r_q, r_q - 1);
        //cross2 += Math.Min(n - c_q, c_q - 1);

        int vertical = n - 1;

        int horizontal = n - 1;

        int obsTotal = 0;
        foreach (var item in obstacles)
        {
            if (item[1] == c_q)
            {
                //vertical
                if (item[0] > r_q)
                {
                    obsTotal += n - item[0] + 1;
                }
                else
                {
                    obsTotal += item[0];
                }
            }
            else if (item[0] == r_q)
            {
                //horizontal
                if (item[1] < c_q)
                {
                    obsTotal += item[1];
                }
                else
                {
                    obsTotal += n - item[1] + 1;
                }
            }
            else if (Math.Abs(r_q - c_q) == Math.Abs(item[0] - item[1]) || Math.Abs(r_q - item[0]) == Math.Abs(c_q - item[1]))
            {
                //cross
                obsTotal += Math.Min(Math.Min(item[0], item[1]) - 1, n - Math.Max(item[0], item[1])) + 1;
            }
            //else if (Math.Abs(r_q - c_q) == Math.Abs(item[0] - item[1]))
            //{
            //    //cross1
            //    if (r_q > item[0])
            //    {
            //        obsTotal += Math.Min(item[0], item[1]);
            //    }
            //    else
            //    {
            //        obsTotal += n - Math.Max(item[0], item[1]) + 1;
            //    }
            //}
            //else if (Math.Abs(r_q - item[0]) == Math.Abs(c_q - item[1]))
            //{
            //    //cross2
            //    if(r_q > item[0])
            //    {
            //        obsTotal += n - item[0] + 1;
            //    }
            //    else
            //    {
            //        obsTotal += n - item[1] + 1;
            //    }
            //}


        }
        result = cross1 + cross2 + vertical + horizontal - obsTotal;

        return result;
    }

    static List<int> absolutePermutation(int n, int k)
    {
        var dic = new Dictionary<int, int>();
        for (int i = 1; i <= n; i++)
        {
            int diff = i - k;
            if (diff > 0 && !dic.ContainsKey(diff))
                dic.Add(diff, diff);
            else
            {
                int sum = i + k;
                if (sum > n)
                {
                    dic.Clear();
                    dic.Add(-1, -1);
                    break;
                }
                else
                    dic.Add(sum, sum);
            }
        }
        return dic.Select(x => x.Key).ToList();
    }

    static string biggerIsGreater(string w)
    {
        for (int i = w.Length - 1; i > 0; i--)
        {
            if (w[i].CompareTo(w[i - 1]) > 0)
            {
                string firstPart = w.Substring(0, i - 1);
                string secondPart = w.Substring(i, w.Length - i);
                var secondPartOrdered = secondPart.OrderBy(x => x).ToList();
                var nextBigger = secondPartOrdered.Select((item, index) => new { item, index }).First(x => w[i - 1].CompareTo(x.item) < 0);
                secondPartOrdered[nextBigger.index] = w[i - 1];
                var result = firstPart + nextBigger.item + string.Join("", secondPartOrdered);

                if (result == w)
                    return "no answer";
                else
                    return result;
            }
        }
        return "no answer";
    }

    static int nonDivisibleSubset(int k, List<int> s)
    {
        var dic = new Dictionary<int, int>();
        foreach (var item in s)
        {
            int remainder = item % k;
            if (dic.ContainsKey(remainder))
            {
                dic[remainder]++;
            }
            else
            {
                dic[remainder] = 1;
            }
        }
        int count = 0;

        if (dic.ContainsKey(0))
            count++; // only +1

        if (k % 2 == 0 && dic.ContainsKey(k / 2))
            count++; // only +1

        for (int i = 1; i < k / 2 + 1; i++)
        {
            if (i != k - i)
            {
                int rem = k - i;
                if (dic.ContainsKey(i))
                {
                    if (dic.ContainsKey(rem))
                    {
                        count += Math.Max(dic[i], dic[rem]);
                    }
                    else
                    {
                        count += dic[i];
                    }
                }
                else if (dic.ContainsKey(rem))
                {
                    count += dic[rem];
                }
            }
        }
        return count;
    }

    static void extraLongFactorials(int n)
    {
        BigInteger result = new BigInteger(1);
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        Console.WriteLine(result);
    }

    public int solutionT3(string[] R)
    {
        int count = 0;
        var dic = new Dictionary<string, string>();
        for (int i = 0; i < R.Length; i++)
        {
            for (int j = 0; j < R[i].Length; j++)
            {
                if (R[i][j] == '.')
                {
                    string key = i.ToString() + "," + j.ToString();
                    if (!dic.ContainsKey(key))
                    {
                        dic.Add(key, key);
                    }
                }
                else
                {
                    //if()
                }
            }
        }
        return count;
    }
    public Dictionary<string, string> moveRight(Dictionary<string, string> dic, string[] R, string endIndex)
    {
        int startI = Int32.Parse(endIndex.Split(',')[0]);
        int startJ = Int32.Parse(endIndex.Split(',')[1]);

        for (int j = startJ; j < R[startI].Length; j++)
        {
            if (R[startI][j] == '.')
            {
                string key = startI.ToString() + "," + j.ToString();
                if (!dic.ContainsKey(key))
                {
                    dic.Add(key, key);
                }
            }
            else
            {
                return moveDown(dic, R, startI.ToString() + "," + (j - 1).ToString());
            }
        }
        return dic;
    }

    public Dictionary<string, string> moveDown(Dictionary<string, string> dic, string[] R, string endIndex)
    {
        int startI = Int32.Parse(endIndex.Split(',')[0]);
        int startJ = Int32.Parse(endIndex.Split(',')[1]);

        for (int i = startI + 1; i < R.Length; i++)
        {
            if (R[i][startJ] == '.')
            {
                string key = i.ToString() + "," + startJ.ToString();
                if (!dic.ContainsKey(key))
                {
                    dic.Add(key, key);
                }
            }
            else
            {
                return moveLeft(dic, R, (i - 1).ToString() + "," + startJ.ToString());
            }
        }
        return dic;
    }

    public Dictionary<string, string> moveLeft(Dictionary<string, string> dic, string[] R, string endIndex)
    {
        int startI = Int32.Parse(endIndex.Split(',')[0]);
        int startJ = Int32.Parse(endIndex.Split(',')[1]);

        for (int j = startJ; j >= 0; j--)
        {
            if (R[startI][j] == '.')
            {
                string key = startI.ToString() + "," + j.ToString();
                if (!dic.ContainsKey(key))
                {
                    dic.Add(key, key);
                }
            }
            else
            {
                return moveUp(dic, R, startI.ToString() + "," + (j - 1).ToString());
            }
        }
        return dic;

    }

    public Dictionary<string, string> moveUp(Dictionary<string, string> dic, string[] R, string endIndex)
    {
        int startI = Int32.Parse(endIndex.Split(',')[0]);
        int startJ = Int32.Parse(endIndex.Split(',')[1]);

        for (int i = startI + 1; i < R.Length; i++)
        {
            if (R[i][startJ] == '.')
            {
                string key = i.ToString() + "," + startJ.ToString();
                if (!dic.ContainsKey(key))
                {
                    dic.Add(key, key);
                }
            }
            else
            {
                return moveLeft(dic, R, (i - 1).ToString() + "," + startJ.ToString());
            }
        }
        return dic;
    }


    public int solutionT2(int[] A)
    {
        int sum = 0;
        var moveEnd = new List<int>();
        var negative = new List<int>();
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] < 0)
            {
                int x = negative.BinarySearch(A[i]);
                negative.Insert((x >= 0) ? x : ~x, A[i]); //add sorted
            }
            else
            {
                negative.Clear();
            }
            sum += A[i];
            if (sum < 0)
            {
                int n = negative.First();
                sum -= n;
                moveEnd.Add(n);
            }
        }
        return moveEnd.Count();
    }

    public static int solutionT1(string S, string C)
    {
        var arr = S.Split("\n");
        var arrWithComma = arr.Select(x => x.Split(","));
        var index = Array.FindIndex(arrWithComma.ElementAt(0), x => x == C);
        var result = arrWithComma.Where((v, i) => i != 0).ToList().Select(x => Int32.Parse(x[index])).Max();
        return result;
    }

    static int activityNotifications3(List<int> expenditure, int d)
    {
        int notification = 0;
        int median = expenditure[0];
        List<int> subExpenditure = expenditure.GetRange(0, d);
        List<int> sortedSubExpenditure = new List<int>(subExpenditure);
        sortedSubExpenditure.Sort();
        if (d % 2 != 0)
        {
            median = sortedSubExpenditure[(d + 1) / 2];
        }
        else
        {
            median = (sortedSubExpenditure[d / 2] + sortedSubExpenditure[d / 2 - 1]) / 2;
        }

        for (int i = d; i < expenditure.Count - 1; i++)
        {
            if (expenditure[i] >= median * 2)
            {

            }
        }
        return notification;
    }

    static int beautifulTriplets(int d, List<int> arr)
    {
        int tripletCount = 0;
        for (int i = 0; i < arr.Count - 2; i++)
        {
            int second = arr.IndexOf(arr[i] + d);
            if (second > -1 && second > i)
            {
                int third = arr.IndexOf(arr[i] + d + d);
                if (third > -1 && third > second)
                {
                    tripletCount++;
                }
            }
        }
        return tripletCount;
    }

    static long tSol4(int[] a, int[] b, int[] c)
    {
        long count = 0L;
        a = a.OrderBy(x => x).ToArray();
        b = b.OrderBy(x => x).ToArray();
        c = c.OrderBy(x => x).ToArray();
        long aCount = a.Count(x => x < b[0]);
        c = c.Where(x => x > b[0]).ToArray();
        long cCount = c.Count();
        count += aCount * cCount;
        for (int i = 1; i < b.Length; i++)
        {
            while (aCount < a.Length && a[aCount] < b[i])
            {
                aCount++;
            }
            int j = 0;
            while (cCount > 0 && c[j] < b[i])
            {
                cCount--;
                j++;
            }
            c = c.ToList().GetRange(j, c.Length - j).ToArray();
            count += aCount * cCount;
        }
        return count;
    }

    static int minRouterPeripherality(int[] T)
    {
        Queue<int> queue = new Queue<int>();
        Queue<int> queue2 = new Queue<int>();
        HashSet<int> visited = new HashSet<int>();
        Dictionary<int, List<int>> levelQueue = new Dictionary<int, List<int>>();

        int mainRoute = T.First(x => x == T[x]);
        queue.Enqueue(mainRoute);
        queue2.Enqueue(mainRoute);
        int level = 0;
        levelQueue[level] = new List<int>() { mainRoute };
        while (queue.Count > 0)
        {
            int levelSize = queue.Count;
            while (levelSize > 0)
            {
                int item = queue.Dequeue();
                if (visited.Contains(item))
                    continue;
                else
                    visited.Add(item);

                var children = T.Select((value, index) => (value, index)).Where(x => x.value == item).Where(x => !visited.Contains(x.index));
                foreach (var ii in children)
                {
                    queue.Enqueue(ii.index);
                    queue2.Enqueue(ii.index);
                }

                levelSize--;
            }
            level++;
            levelQueue[level] = queue.ToList();
        }

        for (int i = 0; i < T.Length - 1; i++)
        {
            for (int j = i + 1; j < T.Length; j++)
            {

            }
        }

        return 0;
    }
    static int minRouterPeripherality_old(int[] T)
    {
        int result = 0;
        List<double> avgLevel = new List<double>();
        for (int route = 0; route < T.Length; route++)
        {
            List<int> routeLevel = new List<int>();

            for (int j = 0; j < T.Length; j++)
            {
                if (route == j)
                {
                    continue;
                }
                int level = 0;
                Queue<int> queue = new Queue<int>();
                HashSet<int> visited = new HashSet<int>();

                queue.Enqueue(route);

                while (queue.Count > 0)
                {
                    int levelSize = queue.Count();
                    while (levelSize > 0)
                    {
                        levelSize--;
                        var item = queue.Dequeue();
                        if (visited.Contains(item))
                            continue;
                        else
                            visited.Add(item);

                        Console.WriteLine(item);
                        var children = T.Select((value, index) => (value, index)).Where(x => x.value == item).Where(x => !visited.Contains(x.index));
                        var parents = T.Select((value, index) => (value, index)).Where(x => x.index == item).Where(x => !visited.Contains(x.value));

                        foreach (var ii in parents)
                        {
                            queue.Enqueue(ii.value);
                        }

                        foreach (var ii in children)
                        {
                            queue.Enqueue(ii.index);
                        }

                        if (queue.Contains(j))
                        {
                            queue.Clear();
                            break;
                        }
                    }
                    level++;
                }
                routeLevel.Add(level);
            }
            double avg = (double)routeLevel.Sum() / (T.Length - 1);
            avgLevel.Add(avg);
        }
        double min = avgLevel.Min();
        return Array.FindIndex(avgLevel.ToArray(), x => x == min);
    }

    static void bfs_example()
    {
        var tree = new Dictionary<int, List<int>>();
        tree[1] = new List<int> { 2, 3, 4 };
        tree[2] = new List<int> { 5 };
        tree[3] = new List<int> { 6, 7 };
        tree[4] = new List<int> { 8 };
        tree[5] = new List<int> { 9 };
        tree[6] = new List<int> { 10 };

        HashSet<int> visited = new HashSet<int>();
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(tree.ElementAt(0).Key);
        while (queue.Count() > 0)
        {
            var element = queue.Dequeue();
            if (visited.Contains(element))
                continue;
            else
                visited.Add(element);

            Console.WriteLine(element);

            List<int> neighbours = new List<int>();
            tree.TryGetValue(element, out neighbours);
            foreach (var item in neighbours)
            {
                queue.Enqueue(item);
            }
        }

    }

    static void bfs_traversal(Node node)
    {
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(node);
        while (q.Count > 0)
        {
            node = q.Dequeue();
            Console.WriteLine(node.Data + " ");
            if (node.Left != null)
            {
                q.Enqueue(node.Left);
            }
            if (node.Right != null)
            {
                q.Enqueue(node.Right);
            }
        }
    }

    static void dfs_traversal(Node node)
    {
        if (node == null)
        {
            return;
        }
        Console.WriteLine(node.Data + " ");
        dfs_traversal(node.Left);
        dfs_traversal(node.Right);
    }

    static List<string> tSol3(List<string> S)
    {
        //tSol3(new List<string>() 
        //    {
        //        "photo.jpg, Warsaw, 2013-09-05 14:08:15",
        //        "john.png, London, 2015-06-20 15:13:22",
        //        "myFriends.png, Warsaw, 2013-09-05 14:07:13",
        //        "Eiffel.jpg, Paris, 2015-07-23 08:03:02",
        //        "pisatower.jpg, Paris, 2015-07-22 23:59:59",
        //        "BOB.jpg, London, 2015-08-05 00:02:03",
        //        "notredame.png, Paris, 2015-09-01 12:00:00",
        //        "me.jpg, Warsaw, 2013-09-06 15:40:22",
        //        "a.png, Warsaw, 2016-02-13 13:33:50",
        //        "b.jpg, Warsaw, 2016-01-02 15:12:22",
        //        "c.jpg, Warsaw, 2016-01-02 14:34:30",
        //        "d.jpg, Warsaw, 2016-01-02 15:15:01",
        //        "e.jpg, Warsaw, 2016-01-02 09:49:09",
        //        "f.jpg, Warsaw, 2016-01-02 10:55:32",
        //        "g.jpg, Warsaw, 2016-02-29 22:13:11",
        //    });
        var result = new LinkedList<string>();
        var ss = S.Select(x => x.Split(",").ToList()).Select(x => new PhotoFile(x[0], x[1], x[2]));
        var subSs = ss.GroupBy(x => x.name).Select(x => new { n = x.Key, l = x.ToList().OrderBy(y => y.date), c = x.Count() });

        foreach (var item in ss)
        {
            int c = ss.Count(x => x.where == item.where);
            var temp = ss.Where(x => x.where == item.where).OrderBy(x => x.date).ToArray();
            int order = Array.FindIndex(temp, x => x.name == item.name) + 1;

            string ext = item.name.Split(".")[1];
            if (c >= 10 && order < 10)
            {
                result.AddLast(item.where + "0" + order + "." + ext);
            }
            else
            {
                result.AddLast(item.where + order + "." + ext);
            }
        }

        return result.ToList();
    }

    static int tSol2(int[] A, string[] D)
    {
        int result = 0;
        int fee = 12;

        var dicNeg = new Dictionary<string, int>();
        var dicNegCount = new Dictionary<string, int>();
        var dicFeeFlag = new Dictionary<string, bool>();
        var months = D.Select(x => x.Substring(5, 2)).ToList();
        for (int i = 0; i < months.Count(); i++)
        {
            result += A[i];
            if (A[i] < 0)
            {
                if (dicNeg.ContainsKey(months[i]))
                {
                    dicNeg[months[i]] += A[i];
                    dicNegCount[months[i]]++;
                }
                else
                {
                    dicNeg[months[i]] = A[i];
                    dicNegCount[months[i]] = 1;
                    dicFeeFlag[months[i]] = false;
                }

                if (dicNegCount[months[i]] >= 3 && dicNeg[months[i]] <= -100 && dicFeeFlag[months[i]] == false)
                {
                    fee--;
                    dicFeeFlag[months[i]] = true;
                }
            }
        }
        result = result - (fee * 5);

        return result;
    }

    static int tSol1(string S)
    {
        int max = 0;
        foreach (var item in S.Split("."))
        {
            foreach (var ite in item.Split("!"))
            {
                foreach (var i in ite.Split("?"))
                {
                    int temp = i.Split(" ").Where(x => !string.IsNullOrEmpty(x)).Count();
                    if (temp > max)
                    {
                        max = temp;
                    }
                }
            }
        }
        return max;
    }

    // Greatest Common Factor 
    static int gcf(int a, int b)
    {
        return (b == 0 ? a : gcf(b, a % b));
        //while (b != 0)
        //{
        //    int temp = b;
        //    b = a % b;
        //    a = temp;
        //}
        //return a;
    }

    // Least Common Multiple 
    static int lcm(int a, int b)
    {
        return (a / gcf(a, b)) * b;
    }

    static List<long> getMaxArea(int w, int h, List<bool> isVertical, List<int> distance)
    { //not work

        var result = new List<long>();
        if (isVertical[0])
        {
            w = Math.Max(w - distance[0], distance[0]);
            result.Add(w * h);
        }
        else
        {
            h = Math.Max(h - distance[0], distance[0]);
            result.Add(w * h);
        }

        for (int i = 1; i < distance.Count; i++)
        {
            if (isVertical[i])
            {
                w = Math.Max(w - distance[i] + distance[i - 1], distance[i] - distance[i - 1]);
                result.Add(w * h);
            }
            else
            {
                h = Math.Max(h - distance[i] + distance[i - 1], distance[i] - distance[i - 1]);
                result.Add(w * h);
            }
        }

        return result;
    }

    static long sortedSum(List<int> a)
    { //not work

        long result = 0;
        var sortedList = new SortedList<int>();
        for (int i = 0; i < a.Count; i++)
        {
            sortedList.Add(a[i]);
            //result =+ sortedList.Select((x,j) => x * j).Sum();
            for (int j = 0; j < sortedList.Count; j++)
            {
                result += (j + 1) * sortedList[j];
            }
        }
        return result;
    }

    static List<int> rotateLeft(int d, List<int> arr)
    {
        d = d % arr.Count();
        var result = arr.GetRange(d, arr.Count() - d).Concat(arr.GetRange(0, d));
        return result.ToList();
    }

    static List<int> reverseArray(List<int> a)
    {
        a.Reverse();
        return a;
    }

    static List<int> getMax(List<string> operations)
    {
        var resultMax = new LinkedList<int>();
        var result = new LinkedList<int>();

        foreach (var item in operations)
        {
            if (item.StartsWith("1"))
            {
                int value = Convert.ToInt32(item.Split(' ')[1]);
                if (resultMax.Count() > 0)
                {
                    value = Math.Max(resultMax.Last(), value);
                }
                resultMax.AddLast(value);
            }
            else if (item.StartsWith("2"))
            {
                if (resultMax.Count() > 0)
                {
                    resultMax.RemoveLast();
                }
            }
            else if (item.StartsWith("3"))
            {
                if (resultMax.Count() > 0)
                {
                    result.AddLast(resultMax.Last());
                }
            }
        }
        return result.ToList();
    }

    static List<long> findSum(List<int> numbers, List<List<int>> queries)
    {
        var result = new List<long>();
        foreach (var q in queries)
        {
            long sum = 0L;
            for (int i = q[0] - 1; i < q[1]; i++)
            {
                if (numbers[i] == 0)
                {
                    sum += q[2];
                }
                else
                {
                    sum += numbers[i];
                }
            }

            //var subArr = numbers.GetRange(q[0] - 1, q[1] - q[0] + 1);
            //long sum = 0L;
            //foreach (var item in subArr)
            //{
            //    if(item == 0)
            //    {
            //        sum += q[2];
            //    }
            //    else
            //    {
            //        sum += item;
            //    }
            //}
            //long countZero = subArr.Count(x => x == 0);
            //long sum = (long)subArr.Select(x=>(long)x).Sum() + ((long)countZero * q[2]);
            result.Add(sum);
        }
        return result;
    }

    static List<string> mostActive(List<string> customers)
    {
        var cDic = new Dictionary<string, int>();
        foreach (var item in customers)
        {
            if (cDic.ContainsKey(item))
            {
                cDic[item]++;
            }
            else
            {
                cDic[item] = 1;
            }
        }
        var activeCustomers = cDic.Where(x => (x.Value / customers.Count()) > 0.05).Select(x => x.Key).OrderBy(x => x);
        return activeCustomers.ToList();
    }

    static int minimumMoves(List<string> grid, int startX, int startY, int goalX, int goalY)
    { // castle on the grid
        var queue = new LinkedList<KeyValuePair<int, int>>();
        queue.AddLast(new KeyValuePair<int, int>(startX, startY));
        int xLength = grid.First().Length;
        int yLength = grid.Count;
        var x = string.Concat(Enumerable.Repeat("W", xLength));
        var matrixColor = new List<string>(Enumerable.Repeat(x, yLength));
        var xM = Enumerable.Repeat(new KeyValuePair<int, int>(-1, -1), yLength);
        var matrix = new List<List<KeyValuePair<int, int>>>();
        for (int i = 0; i < xLength; i++)
        {
            matrix.Add(xM.ToList());
        }

        var destination = new KeyValuePair<int, int>(goalX, goalY);

        int l = queue.Count();
        for (int qi = 0; qi < l; qi++)
        {
            var item = queue.ElementAt(qi);

            if (queue.Contains(destination))
            {
                break;
            }

            for (int i = 0; i < yLength; i++)
            {
                if (grid[item.Key][i] == 'X')
                {
                    break;
                }
                var node = new KeyValuePair<int, int>(item.Key, i);
                if (!queue.Contains(node))
                {
                    queue.AddLast(node);
                }

                if (matrixColor[item.Key][i] == 'W')
                {
                    //change the color
                    var aStringBuilder = new StringBuilder(matrixColor[item.Key]);
                    aStringBuilder.Remove(i, 1);
                    aStringBuilder.Insert(i, "G");
                    matrixColor[item.Key] = aStringBuilder.ToString();

                    matrix.ElementAt(item.Key).RemoveAt(i);
                    matrix.ElementAt(item.Key).Insert(i, new KeyValuePair<int, int>(item.Key, item.Value));
                }
            }
            for (int j = 0; j < xLength; j++)
            {
                if (grid[j][item.Value] == 'X')
                {
                    break;
                }
                var node = new KeyValuePair<int, int>(j, item.Value);
                if (!queue.Contains(node))
                {
                    queue.AddLast(node);
                }

                if (matrixColor[j][item.Value] == 'W')
                {
                    //change the color
                    var aStringBuilder = new StringBuilder(matrixColor[j]);
                    aStringBuilder.Remove(item.Value, 1);
                    aStringBuilder.Insert(item.Value, "G");
                    matrixColor[j] = aStringBuilder.ToString();

                    matrix.ElementAt(j).RemoveAt(item.Value);
                    matrix.ElementAt(j).Insert(item.Value, new KeyValuePair<int, int>(item.Key, item.Value));
                }
            }
            l = queue.Count();
        }

        int count = 0;
        int dX = goalX;
        int dY = goalY;
        while (true)
        {
            count++;
            var temp = matrix[dX][dY];
            dX = temp.Key;
            dY = temp.Value;
            if (dX == startX && dY == startY)
            {
                break;
            }
        }

        return count;
    }

    static long[] riddle(List<long> arr)
    {
        var result = new List<long>();

        var subArr = new LinkedList<List<long>>();
        var minDic = arr.Select((x, i) => new { item = x, index = i }).ToDictionary(x => x.index, x => x.item);
        long max = arr.FirstOrDefault();
        for (int j = 0; j < arr.Count; j++)
        {
            var temp = arr[j];
            subArr.AddLast(new List<long> { temp });
            if (max < temp)
            {
                max = temp;
            }
        }
        result.Add(max);

        for (int i = 2; i <= arr.Count; i++)
        {
            subArr.RemoveLast();
            minDic.Remove(minDic.Count - 1);
            max = 0;
            int length = subArr.First().Count();
            if (length < arr.Count())
            {
                for (int j = 0; j < subArr.Count(); j++)
                {
                    var temp = arr[length + j];
                    subArr.ElementAt(j).Add(temp);
                    if (minDic[j] > temp)
                    {
                        minDic[j] = temp;
                    }
                    if (minDic[j] > max)
                    {
                        max = minDic[j];
                    }
                }
            }

            result.Add(max);
        }
        return result.ToArray();
    }

    static long largestRectangle(List<int> h)
    {
        long result = h[0];
        for (int i = 1; i < h.Count - 1; i++)
        {
            int count = 1;
            for (int j = i - 1; j >= 0; j--)
            {
                if (h[j] >= h[i])
                {
                    count++;
                }
                else break;
            }

            for (int k = i + 1; k < h.Count; k++)
            {
                if (h[k] >= h[i])
                {
                    count++;
                }
                else break;
            }
            result = Math.Max(result, count * h[i]);
        }
        return result;
    }

    static void aTaleOfTwoStack(List<string> q)
    {
        var lifo = new LinkedList<string>();
        var fifo = new LinkedList<string>();
        for (int i = 0; i < q.Count; i++)
        {
            if (q[i].StartsWith("1") && q[i].Contains(" "))
            {
                string ee = q[i].Split(" ")[1];
                fifo.AddLast(ee);
                lifo.AddFirst(ee);
            }
            else if (q[i].Equals("2"))
            {
                fifo.RemoveFirst();
                lifo.RemoveFirst();
            }
            else if ((q[i].Equals("3")))
            {
                Console.WriteLine(fifo.ElementAt(0));
            }
        }
    }

    static string isBalanced(string s)
    {
        var dic = new Dictionary<string, string>();
        dic["("] = ")";
        dic["["] = "]";
        dic["{"] = "}";

        int l = s.Length;
        if (l % 2 != 0) return "NO";

        LinkedList<string> ll = new LinkedList<string>();
        for (int i = 0; i < s.Length; i++)
        {
            if (dic.ContainsKey(s[i].ToString()))
            {
                ll.AddLast(s[i].ToString());
            }
            else
            {
                if (ll.Count == 0) return "NO";

                if (dic[ll.Last()] == s[i].ToString())
                {
                    ll.RemoveLast();
                }
                else
                {
                    return "NO";
                }
            }
        }
        if (ll.Count == 0) return "YES";
        else return "NO";
    }

    static long candies(int n, List<int> arr)
    {
        var dic = new Dictionary<long, long>();
        dic[0] = 1;
        for (int i = 1; i < arr.Count; i++)
        {
            if (arr[i - 1] < arr[i])
            {
                dic[i] = dic[i - 1] + 1;
            }
            else
            {
                dic[i] = 1;
            }
        }
        if (arr.Count > 2)
        {
            for (int i = arr.Count - 2; i >= 0; i--)
            {
                if (arr[i] > arr[i + 1])
                {
                    dic[i] = Math.Max(dic[i], dic[i + 1] + 1);
                }
            }
        }
        return dic.Sum(x => x.Value);
    }

    static string abbreviation(string a, string b)
    {
        bool[,] C = new bool[a.Length + 1, b.Length + 1]; // (a, b).Length + 1
        C[0, 0] = true;
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i - 1] == Char.ToUpper(a[i - 1]))
                C[i, 0] = false;
            else
                C[i, 0] = true;
        }

        for (int i = 1; i <= a.Length; i++)
            for (int j = 1; j <= b.Length; j++)
            {
                if (a[i - 1] == b[j - 1])//i-1,j-1
                    C[i, j] = C[i - 1, j - 1];
                else if (Char.ToUpper(a[i - 1]) == b[j - 1])
                    C[i, j] = C[i - 1, j] || C[i - 1, j - 1];
                else if (Char.ToUpper(a[i - 1]) == a[i - 1])
                    C[i, j] = false;
                else
                    C[i, j] = C[i - 1, j];
            }
        return C[a.Length, b.Length] ? "YES" : "NO";
    }

    static int maxSubsetSum(int[] arr)
    {
        int prevWith = 0;
        int prevWithout = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int oldPrevWithout = prevWithout;
            prevWithout = Math.Max(prevWithout, prevWith);
            prevWith = arr[i] + oldPrevWithout;
        }
        return Math.Max(prevWithout, prevWith);
    }

    static int kadanesAlgorithm(int[] arr)
    {
        int localMax = 0;
        int globalMax = Int32.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            localMax = Math.Max(arr[i], arr[i] + localMax);
            globalMax = Math.Max(globalMax, localMax);
        }
        return globalMax;
    }

    static long minTime(long[] machines, long goal)
    {
        long min = goal * machines.Min() / machines.Count();
        long max = goal * machines.Max() / machines.Count();
        while (min < max)
        {
            long mid = (min + max) / 2;
            var total = machines.Sum(x => mid / x);
            if (total < goal)
            {
                min = mid + 1;
            }
            else
            {
                max = mid;
            }
        }
        return max;
    }

    static long minTimeNotEfficient(long[] machines, long goal)
    {
        long totalDays = 0L;
        long day = machines.Min();
        long min = machines.Min();
        while (true)
        {
            totalDays = machines.Sum(x => day / x);
            if (goal <= totalDays)
            {
                break;
            }
            day += min;
        }

        if (goal < totalDays)
        {
            day -= min;
            while (true)
            {
                day++;
                totalDays = machines.Sum(x => day / x);
                if (goal <= totalDays)
                {
                    break;
                }
            }
        }

        return day;
    }

    static long triplets(int[] a, int[] b, int[] c)
    {
        long count = 0L;
        a = a.Distinct().OrderBy(x => x).ToArray();
        b = b.Distinct().OrderBy(x => x).ToArray();
        c = c.Distinct().OrderBy(x => x).ToArray();

        long aCount = 0L;
        long cCount = 0L;
        for (int i = 0; i < b.Length; i++)
        {
            while (aCount < a.Length && a[aCount] <= b[i])
            {
                aCount++;
            }

            while (cCount < c.Length && c[cCount] <= b[i])
            {
                cCount++;
            }

            count += aCount * cCount;
        }

        return count;
    }

    static int pairs(int k, List<int> arr)
    {
        int count = 0;
        var dic = arr.Distinct().Select((x, i) => new { item = x, index = i }).ToDictionary(x => x.item, x => x.index);
        for (int i = 0; i < arr.Count; i++)
        {
            if (dic.ContainsKey(arr[i] - k))
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
            if (index > -1)
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
            if (element[0] == 0)
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
        if (k > importants.Count())
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
            if (tempDiff < minDifference)
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
                if (commonList.Any(x => x.Value == index))
                {
                    int existingLastIndex = commonList.Where(x => x.Value == index).OrderBy(x => x.Value).Last().Value;
                    int lastIndex = s1.IndexOf(s2[i], existingLastIndex + 1);
                    if (lastIndex > -1)
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
            if (commonList[i].Value > commonList[i + 1].Value)
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
        return C[a.Length, b.Length];
    }

    static int longestCommonSubstring(string a, string b)
    {
        int[,] C = new int[a.Length + 1, b.Length + 1]; // (a, b).Length + 1
        int max = 0;
        int end = 0;
        for (int i = 1; i <= a.Length; i++)
            for (int j = 1; j <= b.Length; j++)
            {
                if (a[i - 1] == b[j - 1])//i-1,j-1
                {
                    C[i, j] = C[i - 1, j - 1] + 1;
                    if (max < C[i, j])
                    {
                        max = C[i, j];
                        end = i;
                    }

                }
                else
                    C[i, j] = 0;
            }
        string result = "";
        for (int i = end - max; i <= end; i++)
        {
            result += a[i];
        }
        string result2 = a.Substring(end - max, max);
        return max;
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
            if (slist[i].Value == 1 && slist[i - 1].Key == slist[i + 1].Key)
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

    static List<int> compareTriplets(List<int> a, List<int> b)
    {
        var result = new List<int>();
        int aCount = 0;
        int bCount = 0;
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                aCount++;
            }
            else if (a[i] < b[i])
            {
                bCount++;
            }
        }
        result.Add(aCount);
        result.Add(bCount);
        return result;
    }

    static int diagonalDifference(List<List<int>> arr)
    {
        int lSum = 0;
        int rSum = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            lSum += arr[i][i];
        }
        for (int i = 0; i < arr.Count; i++)
        {
            rSum += arr[i][arr.Count - i - 1];
        }
        return Math.Abs(rSum - lSum);
    }

    static void plusMinus(List<int> arr)
    {
        int c = arr.Count();
        Console.WriteLine(Math.Round((decimal)arr.Where(x => x > 0).Count() / c, 6));
        Console.WriteLine(Math.Round((decimal)arr.Where(x => x < 0).Count() / c, 6));
        Console.WriteLine(Math.Round((decimal)arr.Where(x => x == 0).Count() / c, 6));
    }

    static void staircase(int n)
    {
        for (int i = n - 1; i >= 0; i--)
        {
            string space = string.Join(string.Empty, Enumerable.Repeat(" ", i));
            string d = string.Join(string.Empty, Enumerable.Repeat("#", n - i));
            Console.WriteLine(space + d);
        }
    }

    static int birthdayCakeCandles(List<int> candles)
    {
        int max = candles.Max();
        return candles.Count(x => x == max);
    }

    static void miniMaxSum(List<int> arr)
    {
        arr.Sort();
        long maxSum = arr.GetRange(1, 4).Select(x => (long)x).Sum();
        long minSum = arr.GetRange(0, 4).Select(x => (long)x).Sum();
        Console.WriteLine(minSum + " " + maxSum);
    }

    static string timeConversion(string s)
    {
        string result = s.Substring(2, 6);
        int hour = Convert.ToInt32(s.Substring(0, 2));
        if (s.Substring(s.Length - 2, 2) == "PM" && hour != 12)
        {
            hour += 12;
        }
        else if (s.Substring(s.Length - 2, 2) == "AM" && hour == 12)
        {
            hour = 0;
        }

        if (hour > 10)
        {
            result = hour + result;
        }
        else
        {
            result = "0" + hour + result;
        }

        return result;
    }

    //    def solution(A):
    //    # write your code in Python 3.6
    //    n = len(A)
    //    dp = [0] * n
    //    dp[0] = A[0]
    //    for i in range(1, n) :
    //        dp[i] = max(A[i], A[i]+dp[i - 1])
    //    return max(dp)

    //# MaxNonnegSliceSum

    static List<int> gradingStudents(List<int> grades)
    {
        var result = new List<int>();
        foreach (var item in grades)
        {
            if (item < 38)
            {
                result.Add(item);
            }
            else
            {
                int g = 5 - (item % 5);
                if (g < 3)
                {
                    result.Add(item + g);
                }
                else
                {
                    result.Add(item);
                }
            }
        }
        return result;
    }

    static string catAndMouse(int x, int y, int z)
    {
        int diffA = Math.Abs(x - z);
        int diffB = Math.Abs(y - z);
        if (diffA < diffB)
        {
            return "Cat A";
        }
        else if (diffA == diffB)
        {
            return "Mouse C";
        }
        else
        {
            return "Cat B";
        }
    }

    int getMoneySpent(int[] keyboards, int[] drives, int b)
    {
        int result = -1;

        for (int i = 0; i < keyboards.Length; i++)
        {
            for (int j = 0; j < drives.Length; j++)
            {
                int sum = keyboards[i] + drives[j];
                if (b >= sum && result < sum)
                {
                    result = sum;
                }
            }
        }

        return result;
    }

    static string angryProfessor(int k, List<int> a)
    {
        int arrived = a.Count(x => x <= 0);
        if (arrived >= k)
        {
            return "NO";
        }
        else
        {
            return "YES";
        }

    }

}

class PhotoFile
{
    public string name { get; set; }
    public string where { get; set; }
    public DateTime date { get; set; }
    public PhotoFile(string n, string w, string d)
    {
        name = n;
        where = w;
        date = Convert.ToDateTime(d);
    }
}

class Point
{
    int x { get; set; }
    int y { get; set; }
    public Point(int _x, int _y)
    {
        x = _x;
        y = _y;
    }
}

class Node
{
    public Node Left { get; set; }
    public Node Right { get; set; }
    public string Data { get; set; }
    public Node(string d)
    {
        Data = d;
    }
    public Node()
    {

    }
}