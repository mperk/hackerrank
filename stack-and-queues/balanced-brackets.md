# Balanced-Brackets

**Solution**
```
    static string isBalanced(string s)
    {
        var dic = new Dictionary<string, string>();
        dic["("] = ")";
        dic["["] = "]";
        dic["{"] = "}";

        int l = s.Length;
        if (l % 2 != 0) return "NO";

        LinkedList<string> ll = new LinkedList<string>();
        for (int i = 0; i < s.Length; i++)
        {
            if (dic.ContainsKey(s[i].ToString()))
            {
                ll.AddLast(s[i].ToString());
            }
            else
            {
                if (ll.Count == 0) return "NO";

                if(dic[ll.Last()] == s[i].ToString())
                {
                    ll.RemoveLast();
                }
                else
                {
                    return "NO";
                }
            }
        }
        if(ll.Count == 0) return "YES";
        else return "NO";
    }
```
