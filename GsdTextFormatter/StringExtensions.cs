
namespace GsdTextFormatter
{
    static class StringExtensions
    {
        public static bool IsNullOrEmptyOrWhiteSpace(this string input)
        {
            return string.IsNullOrEmpty(input) || 
                string.IsNullOrWhiteSpace(input);
        }
    }
}
