# Minimum-Time-Required

**Solution**
```
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
```
