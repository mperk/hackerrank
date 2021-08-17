# Luck-Balance

**Solution**
```
    static int luckBalance(int k, List<List<int>> contests)
    {
        int luck = 0;
        var importants = contests.Where(x => x.Last() == 1).Select(x => x.First()).OrderByDescending(x => x).ToList();
        var unimportantsSum = contests.Where(x => x.Last() == 0).Sum(x => x.First());
        if(k > importants.Count())
        {
            k = importants.Count();
        }
        for (int i = 0; i < k; i++)
        {
            luck += importants[i];
        }
        for (int i = k; i < importants.Count(); i++)
        {
            luck -= importants[i];
        }
        luck += unimportantsSum;
        return luck;
    }
    
```