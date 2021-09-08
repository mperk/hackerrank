# A-Tale-of-Two-Stacks

**Solution**
```
    static void aTaleOfTwoStack(List<string> q)
    {
        var lifo = new LinkedList<string>();
        var fifo = new LinkedList<string>();
        for (int i = 0; i < q.Count; i++)
        {
            if (q[i].StartsWith("1") && q[i].Contains(" "))
            {
                string ee = q[i].Split(" ")[1];
                fifo.AddLast(ee);
                lifo.AddFirst(ee);
            }
            else if (q[i].Equals("2"))
            {
                fifo.RemoveFirst();
                lifo.RemoveFirst();
            }
            else if ((q[i].Equals("3")))
            {
                Console.WriteLine(fifo.ElementAt(0));
            }
        }
    }
```
