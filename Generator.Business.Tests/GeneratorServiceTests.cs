using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Generator.Business.Core;

namespace Generator.Business.Tests
{
    [TestClass]
    public class GeneratorServiceTests
    {
        [TestMethod]
        public void GeneratorServiceTest()
        {
            var expected = new Dictionary<string, List<string>>();

            expected.Add("Mock Generator", new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });

            Mock<IGenerator> mock = new Mock<IGenerator>();
            mock.Setup(i => i.Name).Returns("Mock Generator");
            mock.Setup(i => i.Execute(10)).Returns(new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });

            var generators = new List<IGenerator>();

            generators.Add(mock.Object);

            var service = new GeneratorService(generators);

            var actual = service.Execute(10);

            Assert.AreEqual(expected.Count, actual.Count);

            Assert.AreEqual(actual.Count, 1);

            var actualSequence = actual.GetEnumerator().Current;
            var expectedSequence = expected.GetEnumerator().Current;

            Assert.AreEqual(expectedSequence.Key, actualSequence.Key);

            CollectionAssert.AreEqual(expectedSequence.Value, actualSequence.Value);
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