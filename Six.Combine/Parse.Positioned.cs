
namespace Six.Combine
{
    partial class Parse
    {
        /// <summary>
        /// Construct a parser that will set the position to the position-aware
        /// T on succsessful match.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="parser"></param>
        /// <returns></returns>
        public static Parser<T> Positioned<T>(this Parser<T> parser) where T : IPositionAware<T>
        {
            return input =>
            {
                var parse = parser(input);

                if (parse.WasSuccessful)
                {
                    return Result.Success(parse.Value.SetPos(Position.From(input), parse.Remainder.Position - input.Position), parse.Remainder);
                }
                return parse;
            };
        }
    }
}
