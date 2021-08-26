# Abbreviation

**Solution**
```
    static string abbreviation(string a, string b)
    {
        bool[,] C = new bool[a.Length + 1, b.Length + 1]; // (a, b).Length + 1
        C[0, 0] = true;
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i - 1] == Char.ToUpper(a[i - 1]))
                C[i, 0] = false;
            else
                C[i, 0] = true;
        }

        for (int i = 1; i <= a.Length; i++)
            for (int j = 1; j <= b.Length; j++)
            {
                if (a[i - 1] == b[j - 1])//i-1,j-1
                    C[i, j] = C[i - 1, j - 1];
                else if (Char.ToUpper(a[i - 1]) == b[j - 1])
                    C[i, j] = C[i - 1, j] || C[i - 1, j - 1];
                else if (Char.ToUpper(a[i - 1]) == a[i - 1])
                    C[i, j] = false;
                else
                    C[i, j] = C[i - 1, j];
            }
        return C[a.Length, b.Length] ? "YES" : "NO";
    }
```
