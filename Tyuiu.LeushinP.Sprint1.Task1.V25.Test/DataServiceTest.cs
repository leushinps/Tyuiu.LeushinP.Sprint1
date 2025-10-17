using Tyuiu.LeushinP.Sprint1.Task1.V25.Lib;
using NUnit.Framework;

namespace Tyuiu.LeushinP.Sprint1.Task1.V25.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            double res = ds.Calculate(x, y);
            NUnit.Framework.Assert.AreEqual(1, res);
        }
    }
}