# Beautiful-Triplets

**Solution**
```
    static int beautifulTriplets(int d, List<int> arr)
    {
        int tripletCount = 0;
        for (int i = 0; i < arr.Count - 2; i++)
        {
            int second = arr.IndexOf(arr[i] + d);
            if (second > -1 && second > i)
            {
                int third = arr.IndexOf(arr[i] + d + d);
                if (third > -1 && third > second)
                {
                    tripletCount++;
                }
            }
        }
        return tripletCount;
    }
    
```
