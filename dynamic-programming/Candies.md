# Candies

**Solution**
```
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
        if(arr.Count > 2)
        {
            for (int i = arr.Count - 2; i >= 0; i--)
            {
                if(arr[i] > arr[i + 1])
                {
                    dic[i] = Math.Max(dic[i], dic[i + 1] + 1);
                }
            }
        }
        return dic.Sum(x => x.Value);
    }
```
