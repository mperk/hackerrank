# Alternating-Characters

**Solution**
```
    static int alternatingCharacters(string s)
    {
        int adjacent = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if(s[i] == s[i + 1])
            {
                adjacent++;
            }
        }

        return adjacent;
    }
```