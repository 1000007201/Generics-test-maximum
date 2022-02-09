using NUnit.Framework;
using GenericsMax;

namespace GenericMaxTest
{
    public class Tests
    {

        [Test]
        public void GivenIntegerValue_WhenChech_ReturnMaximum()
        {
            MaximumOfThese max = new MaximumOfThese();
            int data = max.Max(1, 2, 3);
            Assert.AreEqual(3,data);
        }
    }
}