using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatteryMonitoring
{
    public class Measurements
    {
        public static bool IsReadingsAvailable(List<int> readings)
        {
            return readings.Count > 0;
        }

        public static Dictionary<string,int> GetReadingRange(List<int> readings)
        {
           Dictionary<string, int> ranges = new Dictionary<string, int>();
            values.Sort();
            int count = 1;
            int first = values[0];
            int last = values[0];
            int current = values[0];

            for (int i = 1; i < values.Count(); i++)
            {
                if (current == values[i] || current + 1 == values[i])
                {
                    current = last = values[i];
                    count++;
                }
                else
                {
                    ranges.Add(first + "-" + last, count);
                    current = last = first = values[i];
                    count = 1;
                }
            }
            ranges.Add(first + "-" + last, count);
            return ranges;
        }
    }
}
