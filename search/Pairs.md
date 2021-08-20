# Pairs

**Solution**
```
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
    
```

