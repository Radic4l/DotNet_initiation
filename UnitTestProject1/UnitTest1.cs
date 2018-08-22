using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IDate fakeDateProvider = new FakeDateProvider(new DateTime(year: 2018, month: 8, day: 18)); //Samedi

            Messages mess = new Messages(fakeDateProvider,9, 13, 18);

            string result = mess.HelloMessages();

            Assert.IsTrue(result.Contains("Bon Week-End"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            IDate fakeDateProvider = new FakeDateProvider(new DateTime(year: 2018, month: 8, day: 21, hour: 10, minute: 0, second: 0)); //Mardi 10h

            Messages mess = new Messages(fakeDateProvider,9, 13, 18);

            string result = mess.HelloMessages();

            Assert.IsTrue(result.Contains("Bonjour"));
        }
    }
}
