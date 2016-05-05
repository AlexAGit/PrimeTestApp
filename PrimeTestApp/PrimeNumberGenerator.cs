using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTestApp
{
    public class PrimeNumberGenerator
    {
        public bool IsPrimeNumber(int numberToCheck)
        {
            if ((numberToCheck & 1) == 0)
            {
                return numberToCheck == 2;
            }

            for (int i = 3; (i * i) <= numberToCheck; i += 2)
            {
                if ((numberToCheck % i) == 0)
                {
                    return false;
                }
            }

            return numberToCheck != 1;
        }

        public List<int> GeneratePrimeArray(int minValue, int maxValue)
        {
            var primeList = new List<int>();

            if (minValue > maxValue)
            {
                return primeList;
            }

            for(int i = minValue; i <= maxValue; i++)
            {
                if (IsPrimeNumber(i))
                {
                    primeList.Add(i);
                }                
            }

            return primeList;
        }
    }
}
