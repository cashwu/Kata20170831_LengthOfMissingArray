using System;
using System.Linq;
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

        [TestMethod]
        public void input_1_and_3_array_should_return_2()
        {
            LengthOfMissingArrayShouldBe(2, new[] { new object[] { 1 }, new object[] { 1, 2, 3 } });
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
            if (arrayOfArrays.Length == 0)
            {
                return 0;
            }

            return arrayOfArrays[1].Length - arrayOfArrays[0].Length;
        }
    }
}
