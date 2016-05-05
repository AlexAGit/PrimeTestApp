using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                int input = 0;

                if(int.TryParse(args[0], out input))
                {
                    if(input < 1)
                    {
                        Console.Write("Input must be higher than 0");
                        return;
                    }

                    var primeNumberGenerator = new PrimeNumberGenerator();         
                    var primes = primeNumberGenerator.GeneratePrimeArray(1, input);

                    var multiplierMatrixGenerator = new MultiplierMatrixGenerator();
                    var matrix = multiplierMatrixGenerator.GetMatrix(primes.ToArray());

                    for (int i = 0; i < primes.Count; i++)
                    {
                        for (int j = 0; j < primes.Count; j++)
                        {
                            var value = matrix[i, j];
                            Console.Write(String.Format("| {0} ", value > 0 ? value.ToString() : " "));
                        }

                        Console.Write("|");
                        Console.WriteLine();
                    }
                }
            }
        }        
    }
}
