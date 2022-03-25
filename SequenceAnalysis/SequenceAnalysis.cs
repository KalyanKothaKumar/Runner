using System.Linq;

namespace SequenceAnalysis
{
    public class SequenceAnalysis
    {
        /// <summary>
        /// Method to order all the uppercase characters
        /// in the input string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string OrderAlphabetically(string input)
        {
            string output = input.Where(char.IsUpper).Aggregate("", (current, c) => current + c);

            return string.Concat(output.OrderBy(c => c).ToArray());
        }
    }
}
