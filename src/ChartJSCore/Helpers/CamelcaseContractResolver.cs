using Newtonsoft.Json.Serialization;
using System;
using System.Linq;

namespace ChartJSCore.Helpers
{
    public class CamelcaseContractResolver : DefaultContractResolver
    {
        protected override string ResolvePropertyName(string key)
        {
            return FirstCharToLower(key);
        }

        private static string FirstCharToLower(string input)
        {
            if (String.IsNullOrEmpty(input))
            {
                throw new ArgumentException("Input string is empty!");
            }

            return input.First().ToString().ToLower() + input.Substring(1);
        }
    }
}
