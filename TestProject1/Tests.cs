using System;
using NUnit.Framework;
using zd3_Shaidullin.types;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Shop shop = new Shop("test", "test", -1, -100.0);
            Assert.AreEqual(100, shop.Q());
        }
        
        [Test]
        public void Test2()
        {
            Stall stall = new Stall("test", "test", -1, -100, 55_000, "test", "test");
            Assert.AreEqual(200, stall.Qp());
        }
    }
}