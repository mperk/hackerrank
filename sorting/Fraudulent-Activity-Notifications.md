#  Fraudulent-Activity-Notifications

**Not Efficient Solution**
```
   static int activityNotifications(List<int> expenditure, int d)
    {
        int notification = 0;
        for (int i = 0; i < expenditure.Count - d - 1; i++)
        {
            var subDays = expenditure.GetRange(i, d);
            subDays.Sort();
            int median = 0;
                
            if(d % 2 == 0)
            {
                median = (subDays[d / 2] + subDays[d / 2 + 1]) / 2;
            }
            else
            {
                median = subDays[d / 2 + 1];
            }

            if (expenditure[d] < median * 2)
            {
                notification++;
            }
        }
        return notification;
    }
```

**Solution**
```
    static int activityNotifications(List<int> expenditure, int d)
    {
        int notification = 0;
        var sortedSubDays = expenditure.GetRange(0, d).ToList();
        sortedSubDays.Sort();

        for (int i = d; i < expenditure.Count; i++)
        {
            double median = 0.0;
            if (d % 2 == 0)
            {
                median = (sortedSubDays[d / 2] + sortedSubDays[d / 2 - 1]) / 2.0;
            }
            else
            {
                median = sortedSubDays[d / 2];
            }
            if (expenditure[i] >= median * 2)
            {
                notification++;
            }
            sortedSubDays.Remove(expenditure[i-d]);
            sortedSubDays.AddSorted(expenditure[i]);
        }
        return notification;
    }

    public static class Extensions
    {
        public static void AddSorted<T>(this List<T> list, T value)
        {
            int x = list.BinarySearch(value);
            list.Insert((x >= 0) ? x : ~x, value);
        }
    }
```