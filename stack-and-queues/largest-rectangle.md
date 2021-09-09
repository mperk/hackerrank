# Largest-Rectangle

**Solution**
```
    static long largestRectangle(List<int> h)
    {
        long result = h[0];
        for (int i = 1; i < h.Count - 1; i++)
        {
            int count = 1;
            for (int j = i - 1; j >= 0 ; j--)
            {
                if (h[j] >= h[i])
                {
                    count++;
                }
                else break;
            }

            for (int k = i + 1; k < h.Count; k++)
            {
                if (h[k] >= h[i])
                {
                    count++;
                }
                else break;
            }
            result = Math.Max(result, count * h[i]);
        }
        return result;
    }
```
