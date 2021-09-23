using System;
using System.Text.RegularExpressions;

namespace Six.Combine
{
    partial class Parse
    {
        /// <summary>
        /// Construct a parser from the given regular expression.
        /// </summary>
        /// <param name="pattern">The regex expression.</param>
        /// <param name="description">Description of characters that don't match.</param>
        /// <returns>a parse of string</returns>
        public static Parser<string> Regex(string pattern, string description = "")
        {
            return Regex(new Regex(pattern), description);
        }

        /// <summary>
        /// Construct a parser from the given regular expression.
        /// </summary>
        /// <param name="regex">The regex expression.</param>
        /// <param name="description">Description of characters that don't match.</param>
        /// <returns>a parse of string</returns>
        public static Parser<string> Regex(Regex regex, string description = "")
        {
            return RegexMatch(regex, description).Then(match => Return(match.Value));
        }

        /// <summary>
        /// Construct a parser from the given regular expression, returning a parser of
        /// type <see cref="Match"/>.
        /// </summary>
        /// <param name="pattern">The regex expression.</param>
        /// <param name="description">Description of characters that don't match.</param>
        /// <returns>A parser of regex match objects.</returns>
        public static Parser<Match> RegexMatch(string pattern, string description = "")
        {
            return RegexMatch(new Regex(pattern), description);
        }

        /// <summary>
        /// Construct a parser from the given regular expression, returning a parser of
        /// type <see cref="Match"/>.
        /// </summary>
        /// <param name="regex">The regex expression.</param>
        /// <param name="description">Description of characters that don't match.</param>
        /// <returns>A parser of regex match objects.</returns>
        public static Parser<Match> RegexMatch(Regex regex, string description = "")
        {
            regex = OptimizeRegex(regex);

            var expectations = string.IsNullOrWhiteSpace(description)
                ? Array.Empty<string>()
                : new[] { description };

            return input =>
            {
                if (!input.AtEnd)
                {
                    var remainder = input;
                    var inputs = input.Source[input.Position..];
                    var match = regex.Match(inputs);

                    if (match.Success)
                    {
                        for (int j = 0; j < match.Length; j++)
                            remainder = remainder.Advance();

                        return Result.Success(match, remainder);
                    }

                    var found = match.Index == inputs.Length
                                ? "end of source"
                                : $"`{inputs[match.Index]}'";

                    return Result.Failure<Match>(
                        remainder,
                        $"string matching regex `{regex}' expected but {found} found",
                        expectations);
                }

                return Result.Failure<Match>(input, "Unexpected end of input", expectations);
            };
        }

        /// <summary>
        /// Optimize the regex by only matching successfully at the start of the input.
        /// Do this by wrapping the whole regex in non-capturing parentheses preceded by
        ///  a `^'.
        /// </summary>
        /// <remarks>
        /// This method is invoked via reflection in unit tests. If renamed, the tests
        /// will need to be modified or they will fail.
        /// </remarks>
        private static Regex OptimizeRegex(Regex regex)
        {
            return new Regex($"^(?:{regex})", regex.Options);
        }
    }
}
