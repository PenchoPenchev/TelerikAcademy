using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace _4.UnitTestFoundNumber
namespace _4.FoundNumberInArray
{
    [TestClass]
    public class UnitTestFoundNumber
    {
        static double minValue = double.MinValue;
        static double maxValue = double.MaxValue;
        
        [TestMethod]
        public void DoCountMinValue()
        {
            double[] array = { minValue, maxValue, minValue, 7.0, 5.5, 10, minValue };

            //check test data
            FoundNumberInArray.numberToBeChecked = minValue;
            FoundNumberInArray.DoCountArrayNumbers(array);

            Assert.AreEqual(3, FoundNumberInArray.counter);

            FoundNumberInArray.counter = 0;
        }

        [TestMethod]
        public void DoCountMaxValue()
        {
            double[] array = { minValue, maxValue, 7.0, maxValue, 5.5, 10, minValue };

            //check test data
            FoundNumberInArray.numberToBeChecked = maxValue;
            FoundNumberInArray.DoCountArrayNumbers(array);

            Assert.AreEqual(2, FoundNumberInArray.counter);

            FoundNumberInArray.counter = 0;
        }

        [TestMethod]
        public void DoCountMissingValue()
        {
            double[] array = { minValue, maxValue, 7.0, maxValue, 5.5, 10, minValue };

            //check test data
            FoundNumberInArray.numberToBeChecked = 11;
            FoundNumberInArray.DoCountArrayNumbers(array);

            Assert.AreEqual(0, FoundNumberInArray.counter);
        }
    }
}
