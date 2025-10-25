
using NUnit.Framework;
using Tyuiu.LeushinP.Sprint1.Task6.V5.Lib;

namespace Tyuiu.LeushinP.Sprint1.Task6.V5.Test
{

    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidFindSymmetricalWords()
        {
            DataService ds = new DataService();
            string text = "казак прошел мимо шалаша и увидел довод";
            string result = ds.CheckSymmetricalWords(text);
            string expected = "казак, шалаша, довод";
            Assert.AreEqual(expected, result);
        }
    }
}