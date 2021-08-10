# Making-Anagrams

**Solution**
```
   static int makeAnagram(string a, string b)
    {
        int deletion = 0;
        int common = 0;
        string t = a;
        foreach (var item in b)
        {
            if (!t.Contains(item)) 
            {
                deletion++;
            }
            else
            {
                common++;
                int ind = t.IndexOf(item);
                t = t.Remove(ind, 1);
            }
        }

        deletion = deletion + (a.Length - common);
        return deletion;
    }
```