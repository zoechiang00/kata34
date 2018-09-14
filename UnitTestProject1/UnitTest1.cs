using System;
using kata1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
                Console.WriteLine("****** Basic Tests");
            NUnit.Framework.Assert.AreEqual(3, Class1.Persistence(39));
            NUnit.Framework.Assert.AreEqual(0, Class1.Persistence(4));
            NUnit.Framework.Assert.AreEqual(2, Class1.Persistence(25));
            NUnit.Framework.Assert.AreEqual(4, Class1.Persistence(999));
        }
    }
}
