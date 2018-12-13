using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace UnitTestDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCalendar()
        {
            LunarDate lunar = new LunarDate();
            Assert.AreEqual(lunar.GetLunarData(LunarDate.LunarDataType.SEXAGENARYYEAR, 59), "癸亥");
        }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
