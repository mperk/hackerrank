#  Cheat-Sheet

**Triple-Sum**
```
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
            while(aCount < a.Length && a[aCount] <= b[i])
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
```

**Kadanes Algorithm**
```
    //Max sum sub array
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

    //Max array sum non-adjacent
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
```

**Common-Child**
```
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
```
//var dic = arr.Distinct().Select((x, i) => new { item = x, index = i }).ToDictionary(x => x.item, x => x.index);

**Activity-Notifications**
```
    static void AddSorted<T>(this List<T> list, T value)
    {
        int x = list.BinarySearch(value);
        list.Insert((x >= 0) ? x : ~x, value);
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
```

// lcm: least common multiples
// gcd: greatest common divisor

```
    static long LCM(long[] numbers)
    {
        return numbers.Aggregate(lcm);
    }
    static long lcm(long a, long b)
    {
        return Math.Abs(a * b) / GCD(a, b);
    }
    static long GCD(long a, long b)
    {
        return b == 0 ? a : GCD(b, a % b);
    }
```