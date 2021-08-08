# Jumping-on-the-Clouds

**Solution**
```
    static int jumpingOnClouds (int[] c) {
        int i = 0;
        int jump = 0;
        while (c.Length - 2 > i) {
            if (c[i + 2] == 0) {
                i = i + 2;
            } else {
                i++;
            }
            jump++;
        }
        if(c.Length - 2 == i) {
            jump++;
        }
        return jump;
    }
```