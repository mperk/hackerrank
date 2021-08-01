#  Two Strings

**Not Efficient Solution**
```
    public static string twoStrings(string s1, string s2)
    {
        string result = "No";
        foreach (var item in s1)
        {
            if (s2.Contains(item))
            {
                result = "YES";
                return result;
            }
        }
        return result;
    }
```

**Efficient Solution**
```
    public static string twoStrings(string s1, string s2)
    {
        string result = "NO";
        Dictionary<char, short> s1Dic = new Dictionary<char, short>();
        foreach (var item in s1)
        {
            if (s1Dic.ContainsKey(item))
            {
                s1Dic[item] += 1;
            }
            else
            {
                s1Dic.Add(item, 1);
            }
        }
        foreach(var item in s2)
        {
            if (s1Dic.ContainsKey(item))
            {
                if (s1Dic[item] > 0)
                {
                    result = "YES";
                    return result;
                }
            }
        }
        return result;
    }
```