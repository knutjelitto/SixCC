using System;

namespace Six.Combine
{
    partial class Parse
    {
        /// <summary>
        /// Construct a parser that indicates that the given parser
        /// is optional. The returned parser will succeed on
        /// any input no matter whether the given parser
        /// succeeds or not.
        /// </summary>
        /// <typeparam name="T">The result type of the given parser.</typeparam>
        /// <param name="parser">The parser to wrap.</param>
        /// <returns>An optional version of the given parser.</returns>
        public static Parser<IOption<T>> Optional<T>(this Parser<T> parser)
        {
            return input =>
            {
                var parse = parser(input);

                if (parse.WasSuccessful)
                {
                    return Result.Success(new Some<T>(parse.Value), parse.Remainder);
                }

                return Result.Success(new None<T>(), input);
            };
        }

        /// <summary>
        /// Constructs the eXclusive version of the Optional{T} parser.
        /// </summary>
        /// <typeparam name="T">The result type of the given parser</typeparam>
        /// <param name="parser">The parser to wrap</param>
        /// <returns>An eXclusive optional version of the given parser.</returns>
        /// <seealso cref="XOr"/>
        public static Parser<IOption<T>> XOptional<T>(this Parser<T> parser)
        {
            return input =>
            {
                var parse = parser(input);

                if (parse.WasSuccessful)
                {
                    return Result.Success(new Some<T>(parse.Value), parse.Remainder);
                }

                if (parse.Remainder.Equals(input))
                {
                    return Result.Success(new None<T>(), input);
                }

                return Result.Failure<T, IOption<T>>(parse);
            };
        }

        /// <summary>
        /// Construct a parser that indicates that the given parser is optional
        /// and non-consuming. The returned parser will succeed on
        /// any input no matter whether the given parser succeeds or not.
        /// In any case, it won't consume any input, like a positive look-ahead in regex.
        /// </summary>
        /// <typeparam name="T">The result type of the given parser.</typeparam>
        /// <param name="parser">The parser to wrap.</param>
        /// <returns>A non-consuming version of the given parser.</returns>
        public static Parser<IOption<T>> Preview<T>(this Parser<T> parser)
        {
            return input =>
            {
                var result = parser(input);

                if (result.WasSuccessful)
                    return Result.Success(new Some<T>(result.Value), input);

                return Result.Success(new None<T>(), input);
            };
        }
    }
}
