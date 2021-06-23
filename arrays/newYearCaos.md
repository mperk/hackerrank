#  New Year Chaos

**Solution**
```
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
```