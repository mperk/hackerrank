#  Non-Divisible-Subset

**Solution**
```
    //  biggerIsGreater("adeffmbbeeddbbaa");
    //  biggerIsGreater("dkhc");
    //  biggerIsGreater("zalqxykemvzzgaka");
    static string biggerIsGreater(string w)
    {
        for (int i = w.Length - 1; i > 0; i--)
        {
            if (w[i].CompareTo(w[i - 1]) > 0)
            {
                string firstPart = w.Substring(0, i - 1);
                string secondPart = w.Substring(i, w.Length - i);
                var secondPartOrdered = secondPart.OrderBy(x => x).ToList();
                var nextBigger = secondPartOrdered.Select((item, index) => new { item, index }).First(x => w[i - 1].CompareTo(x.item) < 0);
                secondPartOrdered[nextBigger.index] = w[i - 1];
                var result = firstPart + nextBigger.item + string.Join("", secondPartOrdered);

                if (result == w)
                    return "no answer";
                else
                    return result;
            }
        }
        return "no answer";
    }
```