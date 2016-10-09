using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Generator.Business.Tests
{
    [TestClass]
    public class GeneratorTests
    {
        [TestMethod]
        public void AllNumbersTest()
        {
            var expected = new List<string>{"1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

            var generator = new GenerateAllNumbers();

            var actual = generator.Execute(10);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciNumbersTest()
        {
            var expected = new List<string> { "0", "1", "1", "2", "3", "5", "8", "10" };

            var generator = new GenerateFibonacciNumbers();

            var actual = generator.Execute(10);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EvenNumbersTest()
        {
            var expected = new List<string> { "2", "4", "6", "8", "10" };

            var generator = new GenerateEvenNumbers();

            var actual = generator.Execute(10);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddNumbersTest()
        {
            var expected = new List<string> { "1", "3", "5", "7", "9", "10" };

            var generator = new GenerateOddNumbers();

            var actual = generator.Execute(10);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpecialNumbersTest()
        {
            var expected = new List<string> { "1", "2", "C", "4", "E", "C", "7", "8", "C", "E" };

            var generator = new GenerateSpecialNumbers();

            var actual = generator.Execute(10);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}