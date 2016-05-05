using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTestApp.Tests
{
    public class MultiplierMatrixGeneratorTests
    {
        MultiplierMatrixGenerator _multiplierMatrixGenerator;
        int[] _testArray;

        [SetUp]
        public void Setup()
        {
            _multiplierMatrixGenerator = new MultiplierMatrixGenerator();
            _testArray = new int[5] { 1, 2, 3, 4, 5 };
        }

        [Test]
        public void ResultHasSameSizeOnBothDimensionsTest()
        {
            var multiplierMatrix = _multiplierMatrixGenerator.GetMatrix(_testArray);

            Assert.AreEqual(36, multiplierMatrix.Length, "Dimension of the matrix must be n+1 x n + 1");
            Assert.AreEqual(2, multiplierMatrix.Rank, "Rank of the multidimensional array must be two");            
        }

        [Test]
        public void MatrixValueGenerateOutOfRangeTest()
        {
            Assert.Throws(typeof(ArgumentOutOfRangeException), () => { _multiplierMatrixGenerator.GetValueAtPosition(6, 6, _testArray); },"Check that the value required does not exceed the length of the array + 1");
        }

        [Test]
        public void MatrixValueGenerateOnXIndexZeroTest()
        {
            Assert.AreEqual(3, _multiplierMatrixGenerator.GetValueAtPosition(0, 3,_testArray),"Value must be the same as the Y - 1 index in the array");
        }

        [Test]
        public void MatrixValueGenerateOnYIndexZeroTest()
        {
            Assert.AreEqual(4, _multiplierMatrixGenerator.GetValueAtPosition(4, 0, _testArray), "Value must be the same as the Y - 1 index in the array");
        }

        [Test]
        public void MatrixValueGeneratorZeroIndexTest()
        {
            Assert.AreEqual(0, _multiplierMatrixGenerator.GetValueAtPosition(0, 0, _testArray),"Value for position [0][0] must always be zero so it can be ignored");
        }
        
        [Test]
        public void MatrixValueGenerateTest()
        {
            var matrixValue = _multiplierMatrixGenerator.GetValueAtPosition(2, 3, _testArray);
            Assert.AreEqual(_testArray[2 - 1] * _testArray[3 - 1], matrixValue, "Value for position x and y must be value of array[x-1] * value of array[y-1]");
        }
    }
}
