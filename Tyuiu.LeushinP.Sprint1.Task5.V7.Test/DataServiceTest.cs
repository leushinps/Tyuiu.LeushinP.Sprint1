
using Tyuiu.LeushinP.Sprint1.Task5.V7.Lib;

namespace Tyuiu.LeushinP.Sprint1.Task5.V7.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 90;
            int result = ds.AngleToHoursMinutes(x);
            int wait = 3;

            Assert.AreEqual(wait, result);
        }
    }
}
