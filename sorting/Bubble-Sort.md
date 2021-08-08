#  Bubble-Sort

**Solution**
```
   static void countSwaps(List<int> a)
    {
        int count = 0;
        for (int i = 0; i < a.Count; i++)
        {
            for (int j = 0; j < a.Count - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                {
                    var temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    count++;
                }
            }
        }
        Console.WriteLine($"Array is sorted in {count} swaps.");
        Console.WriteLine($"First Element: {a[0]}");
        Console.WriteLine($"Last Element: {a[a.Count - 1]}");
    }
```