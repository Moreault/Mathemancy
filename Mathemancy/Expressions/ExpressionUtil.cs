/*
"Miscellaneous Utility Library" Software Licence

Version 1.0

Copyright (c) 2004-2008 Jon Skeet and Marc Gravell.
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions
are met:

1. Redistributions of source code must retain the above copyright
notice, this list of conditions and the following disclaimer.

2. Redistributions in binary form must reproduce the above copyright
notice, this list of conditions and the following disclaimer in the
documentation and/or other materials provided with the distribution.

3. The end-user documentation included with the redistribution, if
any, must include the following acknowledgment:

"This product includes software developed by Jon Skeet
and Marc Gravell. Contact skeet@pobox.com, or see 
http://www.pobox.com/~skeet/)."

Alternately, this acknowledgment may appear in the software itself,
if and wherever such third-party acknowledgments normally appear.

4. The name "Miscellaneous Utility Library" must not be used to endorse 
or promote products derived from this software without prior written 
permission. For written permission, please contact skeet@pobox.com.

5. Products derived from this software may not be called 
"Miscellaneous Utility Library", nor may "Miscellaneous Utility Library"
appear in their name, without prior written permission of Jon Skeet.

THIS SOFTWARE IS PROVIDED "AS IS" AND ANY EXPRESSED OR IMPLIED
WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
IN NO EVENT SHALL JON SKEET BE LIABLE FOR ANY DIRECT, INDIRECT,
INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING,
BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT
LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN
ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
POSSIBILITY OF SUCH DAMAGE. 
*/

//The following code was taken from Jon Skeet and Marc Gravell's MiscUtil library

using System.Linq.Expressions;

namespace ToolBX.Mathemancy.Expressions;

/// <summary>General purpose Expression utilities</summary>
internal static class ExpressionUtil
{
    /// <summary>
    /// Create a function delegate representing a unary operation
    /// </summary>
    /// <typeparam name="TArg1">The parameter type</typeparam>
    /// <typeparam name="TResult">The return type</typeparam>
    /// <param name="body">Body factory</param>
    /// <returns>Compiled function delegate</returns>
    internal static Func<TArg1, TResult> CreateExpression<TArg1, TResult>(Func<Expression, UnaryExpression> body)
    {
        var parameterExpression = Expression.Parameter(typeof(TArg1), "inp");
        try
        {
            return Expression.Lambda<Func<TArg1, TResult>>(body(parameterExpression), parameterExpression).Compile();
        }
        catch (Exception ex)
        {
            return param1 => throw new InvalidOperationException(ex.Message);
        }
    }

    /// <summary>
    /// Create a function delegate representing a binary operation
    /// </summary>
    /// <typeparam name="TArg1">The first parameter type</typeparam>
    /// <typeparam name="TArg2">The second parameter type</typeparam>
    /// <typeparam name="TResult">The return type</typeparam>
    /// <param name="body">Body factory</param>
    /// <returns>Compiled function delegate</returns>
    internal static Func<TArg1, TArg2, TResult> CreateExpression<TArg1, TArg2, TResult>(Func<Expression, Expression, BinaryExpression> body)
    {
        return CreateExpression<TArg1, TArg2, TResult>(body, false);
    }

    /// <summary>
    /// Create a function delegate representing a binary operation
    /// </summary>
    /// <param name="castArgsToResultOnFailure">
    /// If no matching operation is possible, attempt to convert
    /// TArg1 and TArg2 to TResult for a match? For example, there is no
    /// "decimal operator /(decimal, int)", but by converting TArg2 (int) to
    /// TResult (decimal) a match is found.
    /// </param>
    /// <typeparam name="TArg1">The first parameter type</typeparam>
    /// <typeparam name="TArg2">The second parameter type</typeparam>
    /// <typeparam name="TResult">The return type</typeparam>
    /// <param name="body">Body factory</param>
    /// <returns>Compiled function delegate</returns>
    internal static Func<TArg1, TArg2, TResult> CreateExpression<TArg1, TArg2, TResult>(Func<Expression, Expression, BinaryExpression> body, bool castArgsToResultOnFailure)
    {
        var parameterExpression1 = Expression.Parameter(typeof(TArg1), "lhs");
        var parameterExpression2 = Expression.Parameter(typeof(TArg2), "rhs");
        try
        {
            try
            {
                return Expression.Lambda<Func<TArg1, TArg2, TResult>>(body(parameterExpression1, parameterExpression2), parameterExpression1, parameterExpression2).Compile();
            }
            catch (InvalidOperationException)
            {
                if (castArgsToResultOnFailure && (typeof(TArg1) != typeof(TResult) || typeof(TArg2) != typeof(TResult)))
                {
                    var expression1 = typeof(TArg1) == typeof(TResult) ? parameterExpression1 : (Expression)Expression.Convert(parameterExpression1, typeof(TResult));
                    var expression2 = typeof(TArg2) == typeof(TResult) ? parameterExpression2 : (Expression)Expression.Convert(parameterExpression2, typeof(TResult));
                    return Expression.Lambda<Func<TArg1, TArg2, TResult>>(body(expression1, expression2), parameterExpression1, parameterExpression2).Compile();
                }
                throw;
            }
        }
        catch (Exception ex)
        {
            return (param1, param2) => throw new InvalidOperationException(ex.Message);
        }
    }
}