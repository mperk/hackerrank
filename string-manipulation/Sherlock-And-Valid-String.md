# Sherlock-And-Valid-String

**Solution**
```
   static string isValid(string s)
    {
        var sdic = new Dictionary<string, int>();
        foreach (var item in s)
        {
            string items = item.ToString();
            if (sdic.ContainsKey(items))
            {
                sdic[items] += 1;
            }
            else
            {
                sdic.Add(items, 1);
            }
        }

        var groupCount = sdic.Select(x => x.Value).GroupBy(x => x).Select(x => new { key = x.Key, count = x.Count() });

        if (groupCount.Count() > 2)
        {
            return "NO";
        }
        else if (groupCount.Count() == 2)
        {
            if((groupCount.First().key == 1 && groupCount.First().count ==1) || (groupCount.Last().key == 1 && groupCount.Last().count == 1))
            {
                return "YES";
            }
            int diff = groupCount.First().key - groupCount.Last().key;
            if (diff == -1 || diff == 1)
            {
                if (groupCount.First().count == 1 || groupCount.Last().count == 1)
                {
                    return "YES";
                }
                else { return "NO"; }
            }
            else
            {
                return "NO";
            }
        }
        return "YES";
    }
```