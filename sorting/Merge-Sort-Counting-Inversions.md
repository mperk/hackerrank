# Merge-Sort-Counting-Inversions

**Not Efficient Solution**
```
    static long countInversions(List<int> arr)
    {
        long count = 0;
        for (int i = 0; i < arr.Count-1; i++)
        {
            for (int j = i + 1; j < arr.Count; j++)
            {
                if (arr[i] > arr[j])
                {
                    count++;
                }
            }
        }
        return count;
    }
```

**Solution**
```
   
```