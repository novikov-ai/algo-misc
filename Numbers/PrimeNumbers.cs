using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    public static class PrimeNumbers
    {
        public static IEnumerable<int> GetList(int maxNumber)
        {
            var primeNumbers = new List<int>();
            for (int i = 2; i <= maxNumber; i++)
            {
                if (primeNumbers.All(n => i % n != 0))
                    primeNumbers.Add(i);
            }

            return primeNumbers;
        }
    }
}