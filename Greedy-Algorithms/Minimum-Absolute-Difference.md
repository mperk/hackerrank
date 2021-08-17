# Minimum-Absolute-Difference

**Solution**
```
    static int minimumAbsoluteDifference(List<int> arr)
    {
        arr.Sort();
        int minDifference = Int32.MaxValue;
        for (int i = 0; i < arr.Count - 1; i++)
        {
            int tempDiff = Math.Abs(arr[i] - arr[i + 1]);
            if(tempDiff < minDifference)
            {
                minDifference = tempDiff;
            }

        }
        return minDifference;
    }
    
```