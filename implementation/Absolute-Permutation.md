#  Absolute-Permutation

**Solution**
```
    //absolutePermutation(2,1);
    //absolutePermutation(3,0);
    //absolutePermutation(3,2);
    //absolutePermutation(100,2);
    static List<int> absolutePermutation(int n, int k)
    {
        var dic = new Dictionary<int, int>();
        for (int i = 1; i <= n; i++)
        {
            int diff = i - k;
            if (diff > 0 && !dic.ContainsKey(diff))
                dic.Add(diff,diff);
            else
            {
                int sum = i + k;
                if(sum > n)
                {
                    dic.Clear();
                    dic.Add(-1,-1);
                    break;
                }
                else
                    dic.Add(sum,sum);
            }
        }
        return dic.Select(x=>x.Key).ToList();
    }
```