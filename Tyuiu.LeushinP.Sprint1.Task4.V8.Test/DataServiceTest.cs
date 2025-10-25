using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            double x = 4;
            double y = 1;
            double wait = 2.154;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, Math.Round(res, 3));
        }
    }
}