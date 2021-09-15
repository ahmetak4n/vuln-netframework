using System.Text.RegularExpressions;

namespace DI.Services
{
    public class RegularExpressionService : IRegularExpressionService
    {
        public string CheckPattern(string query)
        {
            var pattern = @"^A(B|C+)+D";
            var result = Regex.Match(query, pattern);

            return result.Value;
        }

        public string CheckPattern2(string query)
        {
            Regex rgx = new Regex("^A(B|C+)+D");
            var result = rgx.Match(query);

            return result.Value;
        }
    }
}
