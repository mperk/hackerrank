# Counting Valleys

**Solution**
```
   static int countingValleys (int n, string s) {
        int valley = 0;
        int altitude = 0; //sea level
        for (int i = 0; i < s.Length; i++) {
            if (s[i].ToString () == "U") {
                altitude++;
            } else {
                altitude--;
            }
            if (altitude == 0 && s[i].ToString() == "U") {
                valley++;
            }
        }
        return valley;
    }
    
```