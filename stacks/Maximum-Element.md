# Maximum-Element


**Not Efficient Solution**
```
    static List<int> getMax(List<string> operations)
    {
        var resultMax = new LinkedList<int>();
        var main = new LinkedList<MaxAndValue>();
        int max = Int32.MinValue;
        foreach (var item in operations)
        {
            if (item.StartsWith("1"))
            {
                int value = Convert.ToInt32(item.Split(' ')[1]);
                max = Math.Max(max, value);
                main.AddLast(new MaxAndValue(max, value));
            }
            else if (item.StartsWith("2"))
            {
                if (main.Count() > 0)
                {
                    main.RemoveLast();
                }

                if(main.Count() > 0)
                {
                    max = main.Last().Max;
                }
                else
                {
                    max = Int32.MinValue;
                }
            }
            else if (item.StartsWith("3"))
            {
                if(main.Count() > 0)
                {
                    resultMax.AddLast(main.Last().Max);
                }
            }
        }
        return resultMax.ToList();
    }
```