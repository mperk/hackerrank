# Min-Max-Riddle

**Solution**
```
    
    
```


**Not Efficient Solution**
```
    static long[] riddle(List<long> arr)
    {
        var result = new List<long>();

        int n = arr.Count;
        result.Add(arr.Max());
        for (int i = 2; i < n; i++)
        {
            var subArr = new List<List<long>>();
            for (int j = 0; j < arr.Count - i + 1; j++)
            {
                var temp = arr.GetRange(j, i);
                subArr.Add(temp);
            }
            var r = subArr.Select(x => x.Min()).Max();
            result.Add(r);
        }
        result.Add(arr.Min());

        return result.ToArray();
    }
```
