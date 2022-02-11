using NUnit.Framework;
using GenericsMax;

namespace GenericMaxTest
{
    public class Tests
    {
        MaximumOfThese<string> maxstring = new MaximumOfThese<string>();
        MaximumOfThese<int> maxint = new MaximumOfThese<int>();
        MaximumOfThese<float> maxfloat = new MaximumOfThese<float>();
        
        //String
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
        //Integer
        [Test]
        public void GivenSecondPlaceIntegerValue_WhenChech_ReturnMaximum()
        {
            
            int data = maxint.Max(1,3,2);
            Assert.AreEqual(3,data);
        }
        [Test]
        public void GivenFirstPlaceIntegerValue_WhenChech_ReturnMaximum()
        {
            
            int data = maxint.Max(3,2,1);
            Assert.AreEqual(3,data);
        }
        [Test]
        public void GivenThirdPlaceIntegerValue_WhenChech_ReturnMaximum()
        {
            
            int data = maxint.Max(1,2,3);
            Assert.AreEqual(3,data);
        }
        //Float
        [Test]
        public void GivenSecondPlaceFloatValue_WhenChech_ReturnMaximum()
        {
            
            float data = maxfloat.Max(1.2f,5.4f,2.1f);
            Assert.AreEqual(5.4f,data);
        }
        [Test]
        public void GivenFirstPlaceFloatValue_WhenChech_ReturnMaximum()
        {
            
            float data = maxfloat.Max(5.4f,1.2f,2.1f);
            Assert.AreEqual(5.4f,data);
        }
        [Test]
        public void GivenThirdPlaceFloatValue_WhenChech_ReturnMaximum()
        {
            
            float data = maxfloat.Max(1.2f,2.1f,5.4f);
            Assert.AreEqual(5.4f,data);
        }
    }
}