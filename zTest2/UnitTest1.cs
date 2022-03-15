using NUnit.Framework;

using LAB_3_2.Services;
namespace zTest2
{
    public class Tests
    {
        
        [Test]
        public void Test1()
        {
            ScaryFunc el = new ScaryFunc();
            double expected = 1.2228160868536717;
            double actual = el.TheScaryFunc(5);
            Assert.AreEqual(expected, actual);
        }
    }
}