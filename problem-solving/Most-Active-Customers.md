# Most-Active-Customers

**Solution**
```
    This is a wikipedia solution: https://en.wikipedia.org/wiki/Longest_common_subsequence_problem 
    static List<string> mostActive(List<string> customers)
    {
        var cDic = new Dictionary<string, int>();
        foreach (var item in customers)
        {
            if (cDic.ContainsKey(item))
            {
                cDic[item]++;
            }
            else
            {
                cDic[item] = 1;
            }
        }
        var activeCustomers = cDic.Where(x => (x.Value / customers.Count()) > 0.05).Select(x => x.Key).OrderBy(x => x) ;
        return activeCustomers.ToList();
    }
```