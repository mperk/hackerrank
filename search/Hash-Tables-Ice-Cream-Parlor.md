# Hash-Tables-Ice-Cream-Parlor

**Solution**
```
    static void whatFlavors(List<long> cost, long money)
    {
        var dic = new Dictionary<long, long>();
        for (int i = 0; i < cost.Count; i++)
        {
            long diff = money - cost[i];
            if (dic.ContainsKey(diff))
            {
                Console.WriteLine($"{dic[diff] + 1} {i + 1}");
                return;
            }
            dic[cost[i]] = i;
        }
    }
    
```


**Not Efficient Solution**
```
    static string whatFlavors(List<int> cost, int money)
    {
        for (int i = 0; i < cost.Count - 1; i++)
        {
            int index = cost.IndexOf(money - cost[i], i + 1);
            if(index > -1)
            {
                return $"{i + 1} {index + 1}";
            }
        }
        return string.Empty;
    }
```