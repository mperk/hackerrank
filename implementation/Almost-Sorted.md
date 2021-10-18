#  Almost-Sorted

**Solution**
```
        static void almostSorted(List<int> arr)
    {
        //almostSorted(new List<int> { 1, 5, 4, 3, 2, 6 });
        //almostSorted(new List<int> { 2, 3, 5, 7, 41, 13, 17, 19, 23, 29, 31, 37, 11 });
        //almostSorted(new List<int> { 3,1,2 });
        int startIndex = -1;
        int endIndex = -1;

        for (int i = 0; i < arr.Count - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                startIndex = i;
                break;
            }
        }

        if(startIndex == -1)
        {
            Console.WriteLine("yes");
            return;
        }

        for (int i = arr.Count - 1; i > 0; i--)
        {
            if(arr[i] < arr[i - 1])
            {
                endIndex = i;
                break;
            }
        }

        

        var copyArr = new List<int>(arr);
        int temp = arr[startIndex];
        arr[startIndex] = arr[endIndex];
        arr[endIndex] = temp;

        bool trySwap = false;
        for (int i = 0; i < arr.Count - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                trySwap = true;
                break;
            }
        }

        if (trySwap)
        {
            if (startIndex == 0 && endIndex == arr.Count - 1)
            {
                Console.WriteLine("no");
                return;
            }

            var reverse = copyArr.GetRange(startIndex, endIndex - startIndex + 1);
            reverse.Reverse();
            var firstPart = copyArr.GetRange(0, startIndex);
            firstPart.AddRange(reverse);
            var lastPart = copyArr.GetRange(endIndex + 1, arr.Count - endIndex - 1);
            firstPart.AddRange(lastPart);
            for (int i = 0; i < firstPart.Count - 1; i++)
            {
                if (firstPart[i] > firstPart[i + 1])
                {
                    Console.WriteLine("no");
                    return;
                }
            }
            Console.WriteLine("yes");
            Console.WriteLine($"reverse {startIndex + 1} {endIndex + 1}");
        }
        else
        {
            Console.WriteLine("yes");
            Console.WriteLine($"swap {startIndex + 1} {endIndex + 1}");
            return;
        }
    }
```