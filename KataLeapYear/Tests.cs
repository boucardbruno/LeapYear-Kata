using NUnit.Framework;

namespace KataLeapYear
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.IsTrue(Year.IsLeap(1996));
        }
        [Test]
        public void Test2()
        {
            Assert.IsFalse(Year.IsLeap(2001));
        }
        [Test]
        public void Test3()
        {
            Assert.IsFalse(Year.IsLeap(1900));
        }
        [Test]
        public void Test4()
        {
            Assert.IsTrue(Year.IsLeap(2000));
        }
    }
}
