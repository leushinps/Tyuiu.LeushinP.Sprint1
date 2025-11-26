
using NUnit.Framework;
using Tyuiu.LeushinP.Sprint1.Task5.V7.Lib;

namespace Tyuiu.LeushinP.Sprint1.Task5.V7.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidCalculation30Degrees()
        {
            DataService ds = new DataService();
            double f = 30;
            int wait = 1;
            int res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(wait, res);
        }
    }
}