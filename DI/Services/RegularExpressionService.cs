using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DI.Services
{
    public class RegularExpressionService : IRegularExpressionService
    {
        public string SearchOne(string search)
        {
            var pattern = @"^A(B|C+)+D";
            var result = Regex.Match(search, pattern);

            return result.Value;
        }

        public string SearchTwo(string search)
        {
            Regex rgx = new Regex("^A(B|C+)+D");
            var result = rgx.Match(search);

            return result.Value;
        }
    }
}
