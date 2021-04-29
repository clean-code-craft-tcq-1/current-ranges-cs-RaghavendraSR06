using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MeasurementTest
{
    [TestClass]
    public class MeasurementsTest
    {
        public readonly List<int> MesurementReadings = new List<int>() { 3, 3, 5, 4, 10, 11, 12 };

        [TestMethod]
        public void GivenEmptyReadings__WhenListIsEmpty_ThenFalseIsReturned()
        {
            List<int> readings = new List<int>();
            Assert.IsFalse(Measurements.IsReadingsAvailable(readings));
        }

        [TestMethod]
        public void GivenReadings__WhenListIsNotEmpty_ThenTrueIsReturned()
        {
            Assert.IsTrue(Measurements.IsReadingsAvailable(MesurementReadings));
        }

        [TestMethod]
        public void GivenReadings_WhenListHasExpectedRange_ThenTrueIsReturned()
        {
            Dictionary<string, int> result = Measurements.GetReadingRange(MesurementReadings);
            Assert.IsTrue(result.ContainsKey("3-5"));
        }

    }
}
