namespace SumOfMultiplesLibrary
{
    public class SumOfMultiples
    {
        /// <summary>
        /// Method to calculate sum of all the multiples of 3 and 5
        /// with in the given limit
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        public static int CalculateMultiples(int limit)
        {
            int sum = 0;

            for (int i = 0; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
