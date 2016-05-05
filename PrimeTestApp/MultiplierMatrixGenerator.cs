using System;
using System.Collections.Generic;

namespace PrimeTestApp
{
    public class MultiplierMatrixGenerator
    {
        public MultiplierMatrixGenerator()
        {

        }

        public int[,] GetMatrix(int[] testArray)
        {
            var matrix = new int[testArray.Length + 1, testArray.Length + 1];

            for (int i = 0; i < testArray.Length + 1; i++)
                for (int j = 0; j < testArray.Length + 1; j++)
                    matrix[i, j] = GetValueAtPosition(i, j, testArray);

            return matrix;
        }

        public int GetValueAtPosition(int positionX, int positionY, int[] values)
        {
            if(positionX == 0 && positionY == 0)
            {
                return 0;
            }

            if(positionX < 0 || positionX > values.Length || positionY <0 || positionY > values.Length)
            {
                throw new ArgumentOutOfRangeException("Position out of range.");
            }

            if(positionX == 0)
            {
                return values[positionY - 1];
            }

            if(positionY == 0)
            {
                return values[positionX - 1];
            }

            return values[positionX - 1] * values[positionY - 1];
        }
    }
}