using NUnit.Framework;
using Tyuiu.LeushinP.Sprint1.Task2.V25.Lib;

namespace Tyuiu.LeushinP.Sprint1.Task2.V25.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ConvertRadsToDegrees()
        {
            DataService ds = new DataService();

            int radians1 = 1;
            double expected1 = 57.296;
            double result1 = ds.ConvertRadsToDegrees(radians1);
            Assert.AreEqual(expected1, result1, 0.001);
        }
    }
}