#  Left-Rotation

**Solution**
```
static int[] rotLeft (int[] a, int d) {
    int mod = d % a.Length;
    int diff = a.Length - mod;
    if (mod > diff) {
        for (int i = 0; i < diff; i++) {
            int temp = a[a.Length - 1];
            for (int j = a.Length - 1; j > 0; j--) {
                a[j] = a[j - 1];
            }
            a[0] = temp;
        }
    } else {
        for (int i = 0; i < mod; i++) {
            int temp = a[0];
            for (int j = 0; j < a.Length - 1; j++) {
                a[j] = a[j + 1];
            }
            a[a.Length - 1] = temp;
        }
    }
    return a;
}
```
