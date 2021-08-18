# Max-Min

**Solution**
```
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
    
```


**Not Efficient Solution**
```
    static int maxMin(int k, List<int> arr)
    {
        arr.Sort();
        int result = Int32.MaxValue;
        for (int i = 0; i <= arr.Count() - k; i++)
        {
            var subarr = arr.GetRange(i, k);
            var diff = subarr.Last() - subarr.First();
            if(diff < result)
            {
                result = diff;
            }
        }
        return result;
    }
```