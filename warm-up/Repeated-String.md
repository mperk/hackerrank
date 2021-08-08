# Repeated-String

**Solution**

```
    static long repeatedString(string s, long n) {
        long count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'a') count++;
        }
        long division = n / s.Length;
        count = count * division;

        long mod = n % s.Length;
        for (int i = 0; i < mod; i++)
        {
            if(s[i] == 'a') count++;
        }
        return count;
    }

```
