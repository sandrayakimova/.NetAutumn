using NUnit.Framework;
using System;
namespace Nodtest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase01()
        {
            int exp = 1;
            Assert.AreEqual(exp,nodlib.NodLib.NodEvk(2, 3, 4));

        }
        [Test]
        public void TestCase02()
        {
            int exp = 1;
            Assert.AreEqual(exp, nodlib.NodLib.NodBin(2, 3, 4));

        }
    }
}
