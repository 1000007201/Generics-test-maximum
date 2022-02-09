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
            double data = max.Max(1.1, 3.1, 2.1);
            Assert.AreEqual(3.1,data);
        }
    }
}