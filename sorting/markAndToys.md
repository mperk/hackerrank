#  Mark And Toys

**Solution**
```
    static int maximumToys(List<int> prices, int k)
    {
        prices.Sort();
        int count = 0;
        int total = 0;
        foreach (var item in prices)
        {
            int temp = total + item;
            if (temp < k) 
            {
                total += item;
                count++;
            }
            else
            {
                break;
            }
        }
        return count;
    }
```