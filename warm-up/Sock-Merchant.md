# Sock-Merchant

**Solution**
```
    static int sockMerchant (int n, int[] ar) {
        Array.Sort(ar);
        int count = 0;
        for (int i = 0; i < ar.Length - 1; i++)
        {
            if(ar[i] == ar[i+1]){
                i++;
                count++;
            }
        }
        return count;
    }
    
```