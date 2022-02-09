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
            string data = max.Max("Apple","Peach","Banana");
            Assert.AreEqual("Peach",data);
        }
    }
}