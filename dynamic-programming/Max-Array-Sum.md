# Max-Array-Sum

**Solution**
```
    static int maxSubsetSum(int[] arr)
    {
        int prevWith = 0;
        int prevWithout = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int oldPrevWithout = prevWithout;
            prevWithout = Math.Max(prevWithout, prevWith);
            prevWith = arr[i] + oldPrevWithout;
        }
        return Math.Max(prevWithout, prevWith);
    }
```
