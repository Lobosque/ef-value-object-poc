using System.Linq;

namespace ValueObjectPoc.OwnedEntities.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Convert a formatted number, such as a Ssn, to a string with just numbers
        /// </summary>
        /// <param name="formattedNumber"></param>
        /// <returns></returns>
        public static string OnlyNumbers(this string formattedNumber)
        {
            return string.IsNullOrEmpty(formattedNumber) ? string.Empty : new string(formattedNumber.Where(char.IsDigit).ToArray());
        }
    }
}