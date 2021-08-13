# Special-String-Again

**Solution**
```
    static long substrCount(int n, string s)
    {
        long count = 0;
        var slist = new List<KeyValuePair<char, long>>();

        long repeatCount = 1;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == s[i + 1])
            {
                repeatCount++;
            }
            else
            {
                slist.Add(new KeyValuePair<char, long>(s[i], repeatCount));
                repeatCount = 1;
            }
        }
        slist.Add(new KeyValuePair<char, long>(s[s.Length - 1], repeatCount)); //last item

        for (int i = 0; i < slist.Count; i++)
        {
            //this is a formula for same and sequential=> (n * (n+1)) /2
            count += (slist[i].Value * (slist[i].Value + 1)) / 2;
        }

        for (int i = 1; i < slist.Count - 1; i++)
        {
            if(slist[i].Value == 1 && slist[i -1].Key == slist[i+1].Key)
            {
                count += Math.Min(slist[i - 1].Value, slist[i + 1].Value);
            }
        }

        return count;
    }
```