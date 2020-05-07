using System.Collections.Generic;
using UnityEngine;

public class CDRandom
{
    static bool initialized = false;
    static Dictionary<string, List<int>> values = new Dictionary<string, List<int>>()
   {
       {"37", new List<int>(){ 5 } },
       {"38", new List<int>(){16 } },
       {"39", new List<int>(){(int)Random.Range(3, 4.999f)} },
       {"310", new List<int>(){ (int)Random.Range(-10, 0.999f) } },
       {"48", new List<int>(){ 5, 6, 4, 7, 3, 8, 2, 9, 1, 0 } },
       {"49", new List<int>(){ 3, 4, 1, 9 } },
       {"410", new List<int>(){ 5, 6, 1, 6, 2 } }
   };

    static Dictionary<string, int> indexes = new Dictionary<string, int>();

   public static int range(string topicLevel, int min, int max)
   {
        if (!initialized)
        {
            reset();
        }
        if (values.ContainsKey(topicLevel) && indexes[topicLevel] < values[topicLevel].Count)
        {
            int val = values[topicLevel][indexes[topicLevel]];
            indexes[topicLevel]++;
            return val;
        }
        return (int)Random.Range(min, max + 0.99f);
    }

    public static void reset()
    {
        indexes.Clear();
        foreach(KeyValuePair<string, List<int>> pair in values)
        {
            indexes.Add(pair.Key, 0);
        }
        initialized = true;
    }
}
