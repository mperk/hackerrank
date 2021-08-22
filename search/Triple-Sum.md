# Triple-Sum

**Solution**
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

**Not Efficient Solution**
```

    static long triplets(int[] a, int[] b, int[] c)
    {
        long count = 0L;
        a = a.Distinct().ToArray();
        b = b.Distinct().ToArray();
        c = c.Distinct().ToArray();

        for (int i = 0; i < b.Length; i++)
        {
            var aCount = a.Count(x => b[i] >= x);
            var cCount = c.Count(x => b[i] >= x);
            count += aCount * cCount;
        }

        return count;
    }

    static long triplets(int[] a, int[] b, int[] c)
    {
        long count = 0L;
        for (int i = 0; i < a.Length; i++)
        {
            var qArr = b.Where(q => a[i] <= q).Distinct();
            for (int j = 0; j < qArr.Count(); j++)
            {
                var rArrCount = c.Count(r => qArr.ElementAt(j) >= r);
                count += rArrCount;
            }
            
        }
        return count;
    }
```