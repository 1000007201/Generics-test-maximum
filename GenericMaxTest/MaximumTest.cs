using NUnit.Framework;
using GenericsMax;

namespace GenericMaxTest
{
    public class Tests
    {
        MaximumOfThese<string> maxstring = new MaximumOfThese<string>();
        MaximumOfThese<int> maxint = new MaximumOfThese<int>();
        MaximumOfThese<double> maxdouble = new MaximumOfThese<double>();

        [Test]
        public void GivenSecondPlaceStringValue_WhenChech_ReturnMaximum()
        {
            
            string data = maxstring.Max("Apple","Peach","Banana");
            Assert.AreEqual("Peach",data);
        }
        [Test]
        public void GivenFirstPlaceStringValue_WhenChech_ReturnMaximum()
        {
            
            string data = maxstring.Max("Peach","Apple","Banana");
            Assert.AreEqual("Peach",data);
        }
        [Test]
        public void GivenThirdPlaceStringValue_WhenChech_ReturnMaximum()
        {
            
            string data = maxstring.Max("Apple","Banana", "Peach");
            Assert.AreEqual("Peach",data);
        }
    }
}