#  Minimum-Swaps 2


**Efficient Solution**
```
        static int minimumSwaps(int[] arr)
        {
            int n = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                n = recursiveSwap(arr, i, n);
            }
            return n;
        }

        static int recursiveSwap(int[] arr, int i, int n)
        {
            if (arr[i] != i + 1)
            {
                int temp = arr[i];
                arr[i] = arr[temp - 1];
                arr[temp - 1] = temp;
                n++;
                if (arr[i] != i + 1)
                {
                    n = recursiveSwap(arr, i, n);
                }
            }
            return n;
        }
```