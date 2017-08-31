using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170831_LengthOfMissingArray
{
    [TestClass]
    public class LengthOfMissingArrayTests
    {
        [TestMethod]
        public void input_empty_array_should_return_0()
        {
            LengthOfMissingArrayShouldBe(0, new object[][] { });
        }

        private static void LengthOfMissingArrayShouldBe(int expected, object[][] arrayOfArrays)
        {
            var kata = new Kata();
            var actual = kata.GetLengthOfMissingArray(arrayOfArrays);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int GetLengthOfMissingArray(object[][] arrayOfArrays)
        {
            return 0;
        }
    }
}
