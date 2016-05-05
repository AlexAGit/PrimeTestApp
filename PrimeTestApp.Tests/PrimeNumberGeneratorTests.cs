using NUnit.Framework;
using System.Collections.Generic;

namespace PrimeTestApp.Tests
{
    [TestFixture]
    public class PrimeNumberGeneratorTests
    {
        private PrimeNumberGenerator _primeNumberGenerator;

        [SetUp]
        public void Setup()
        {
            _primeNumberGenerator = new PrimeNumberGenerator();
        }

        [TestCase(1, false, "1 or lower than one should always be non-prime")]
        [TestCase(3, true, "3 should always be a prime")]
        [TestCase(6, false, "any number that divides by 3 or 2 should not be prime")]
        public void CheckNumberIsPrimeTest(int numberToCheck, bool expected, string message)
        {
            var isPrime = _primeNumberGenerator.IsPrimeNumber(numberToCheck);
            Assert.AreEqual(expected, isPrime, message);
        }

        [Test]
        public void CheckListOfPrimesLowerThanValueTest()
        {
            var primesList = _primeNumberGenerator.GeneratePrimeArray(1, 9);
            Assert.AreEqual(4, primesList.Count);
            Assert.Contains(2, primesList, "prime number 2 should be contained in the collection");
            Assert.Contains(3, primesList, "prime number 3 should be contained in the collection");
            Assert.Contains(5, primesList, "prime number 5 should be contained in the collection");
            Assert.Contains(7, primesList, "prime number 7 should be contained in the collection");
        }
    }
}
