#  New Year Chaos

**Not Efficient Solution**
```
public static int minimumBribes(List<int> q)
    {
        int n = 0;
        for (int i = 0; i < q.Count; i++)
        {
            int chaoticCount = 0;
            for (int j = i + 1; j < q.Count; j++)
            {
                if (q[i] > q[j])
                {
                    n++;
                    chaoticCount++;
                }
                if (chaoticCount > 2)
                {
                    return -1;
                }
            }
        }
        return n;
    }
```

**Efficient Solution**
```
public static string minimumBribes(List<int> q)
    {
        int n = 0;
        for (int i = q.Count -1 ; i >= 0; i--)
        {
            //if an integer move 3 or more position from current index, it bribed more than 2 
            if (q[i] > i + 3 ) return "Too chaotic"; //Too chaotic

            // We need to count how many times RECEIVED bribed. Give a bribe is not important anymore
            for (int j = Math.Max(0, q[i] - 2); j < i; j++)
            {
                if (q[j] > q[i])
                {
                    n++;
                }
                
            } 
        }
        return n.ToString();
    }
```