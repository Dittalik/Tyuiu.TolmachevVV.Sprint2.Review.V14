using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint2.Review.V14.Lib;

namespace Tyuiu.TolmachevVV.Sprint2.Review.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            Assert.IsTrue(service1.CheckDotInShadedArea(0.1, 0.1));
        }
    }
}
