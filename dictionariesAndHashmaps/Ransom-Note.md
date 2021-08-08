#  Ransom-Note

**Not Efficient Solution**
```
    public static string checkMagazine(List<string> magazine, List<string> note)
    {
        if(note.Count() == 0 || magazine.Count() == 0)
        {
            return "Yes";
        }
        var checkWord = magazine.Contains(note[0]);
        if (checkWord == false)
        {
            return "No";
        }
        magazine.Remove(note[0]);
        note.Remove(note[0]);
        return checkMagazine(magazine, note);
    }
```

**Efficient Solution**
```
    static string checkMagazine(List<string> magazine, List<string> note)
    {
        Dictionary<string, int> dicMagazine = new Dictionary<string, int>();
        foreach (var item in magazine)
        {
            if (!dicMagazine.ContainsKey(item))
                dicMagazine.Add(item, 1);
            else dicMagazine[item] += 1;
        }

        foreach (var item in note)
        {
            if (dicMagazine.ContainsKey(item))
            {
                if (dicMagazine[item] > 0)
                {
                    dicMagazine[item] -= 1;
                }
                else
                {
                    return "No";
                }
            }
            else
            {
                return "No";
            }
        }
        return "Yes";
    }
```