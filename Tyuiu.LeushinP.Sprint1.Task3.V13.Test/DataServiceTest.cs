using System;
using Tyuiu.LeushinP.Sprint1.Task3.V13.Lib;
using NUnit.Framework;

namespace Tyuiu.LeushinP.Sprint1.Task3.V13.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidMultiplyOfDigits()
        {
            DataService ds = new DataService();

            int number1 = 123;
            double expected1 = 6.0;
            double result1 = ds.MultiplyOfDigits(number1);
            Assert.AreEqual(expected1, result1);
        }

        [Test]
        public void InvalidNumberThrowsException()
        {
            DataService ds = new DataService();

            Assert.Throws<ArgumentException>(() => ds.MultiplyOfDigits(99));
            Assert.Throws<ArgumentException>(() => ds.MultiplyOfDigits(1000));
        }
    }
}