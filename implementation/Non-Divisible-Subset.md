#  Non-Divisible-Subset

**Solution**
```
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

        if(k % 2 == 0 && dic.ContainsKey(k / 2))
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
```