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
    
```