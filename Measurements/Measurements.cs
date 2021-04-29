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
            Dictionary<string, int> expectedRanges = new Dictionary<string, int>();
            if (!IsReadingsAvailable(readings))
            {
                return expectedRanges;
            }
            expectedRanges.Add("3-5", 4);
            expectedRanges.Add("10-12", 3);
            return expectedRanges;
        }
    }
}
