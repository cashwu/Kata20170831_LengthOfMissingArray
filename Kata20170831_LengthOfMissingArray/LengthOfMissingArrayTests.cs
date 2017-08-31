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

        [TestMethod]
        public void input_3_and_1_array_should_return_2()
        {
            LengthOfMissingArrayShouldBe(2, new[] { new object[] { 1, 2, 3 }, new object[] { 1 } });
        }

        [TestMethod]
        public void input_1_2_and_4_array_should_return_3()
        {
            LengthOfMissingArrayShouldBe(3, new[] { new object[] { 1, 2 }, new object[] { 1 }, new object[] { 1, 2, 3, 4 } });
        }

        [TestMethod]
        public void input_1_2_4_and_5_array_should_return_3()
        {
            LengthOfMissingArrayShouldBe(3, new[] { new object[] { 1, 2 }, new object[] { 4, 5, 1, 1 }, new object[] { 1 }, new object[] { 5, 6, 7, 8, 9 } });
        }

        [TestMethod]
        public void input_0_array_should_return_0()
        {
            LengthOfMissingArrayShouldBe(0, null);
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
            if (arrayOfArrays == null)
            {
                return 0;
            }

            for (int i = 0; i < arrayOfArrays.Length; i++)
            {
                Console.WriteLine(arrayOfArrays[i].Length);
            }
            var arrLength = arrayOfArrays.Select(arr => arr.Length).OrderBy(a => a).ToList();

            var result = 0;
            for (var i = 0; i < arrLength.Count; i++)
            {
                if (i + 1 < arrLength.Count && arrLength[i + 1] - arrLength[i] > 1)
                {
                    result = arrLength[i] + 1;
                    break;
                }
            }

            return result;
        }
    }
}
