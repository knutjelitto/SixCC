using System;

namespace Six.Combine
{
    internal static class ResultHelper
    {
        public static IResult<U> IfSuccess<T, U>(this IResult<T> result, Func<IResult<T>, IResult<U>> next)
        {
            if (result.WasSuccessful)
            {
                return next(result);
            }

            return Result.Failure<T, U>(result);
        }

        public static IResult<T> IfFailure<T>(this IResult<T> result, Func<IResult<T>, IResult<T>> next)
        {
            return result.WasSuccessful 
                ? result 
                : next(result);
        }
    }
}