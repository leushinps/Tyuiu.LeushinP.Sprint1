
using NUnit.Framework;
using Tyuiu.LeushinP.Sprint1.Task4.V8.Lib;

namespace Tyuiu.LeushinP.Sprint1.Task4.V8.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidCalculation()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 1;
            double wait = 2.538;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}