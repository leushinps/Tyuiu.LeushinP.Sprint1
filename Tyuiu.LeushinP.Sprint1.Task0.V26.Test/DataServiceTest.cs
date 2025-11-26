using NUnit.Framework;
using Tyuiu.LeushinP.Sprint1.Task0.V26.Lib;

namespace Tyuiu.LeushinP.Sprint1.Task0.V26Test
{
    [TestFixture]
    public sealed class DataServiceTest
    {
        [Test]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(7, res);
        }
    }
}