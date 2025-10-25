
using NUnit.Framework;
using Tyuiu.LeushinP.Sprint1.Task7.V7.Lib;

namespace Tyuiu.LeushinP.Sprint1.Task7.V7.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidCalculation1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;
            double wait = -1.000;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}