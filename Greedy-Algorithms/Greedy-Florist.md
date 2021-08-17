# Greedy-Florist

**Solution**
```
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
    
```