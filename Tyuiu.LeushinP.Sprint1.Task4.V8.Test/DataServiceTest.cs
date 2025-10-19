
using Tyuiu.LeushinP.Sprint1.Task4.V8.Lib;

namespace Tyuiu.LeushinP.Sprint1.Task4.V8.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidExpression()
        {
            {

                DataService ds = new DataService();
                double x = 5;
                double y = 1;


                double result = ds.Calculate(x, y);

                double expected = 2.125;
                Assert.AreEqual(expected, result, 0.001);
            }
        }
    }
}