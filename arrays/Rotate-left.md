#  Left-Rotation

**Solution**
```
	static List<int> rotateLeft(int d, List<int> arr)
    {
        d = d % arr.Count();
        var result = arr.GetRange(d, arr.Count() - d).Concat(arr.GetRange(0, d));
        return result.ToList();
    }
```
