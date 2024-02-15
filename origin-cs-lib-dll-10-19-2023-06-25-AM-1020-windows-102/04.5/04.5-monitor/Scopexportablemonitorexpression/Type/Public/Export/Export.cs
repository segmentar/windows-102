using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorexpression
    {
        public static Scopexportablemonitorexpression Export()
        {
            Scopexportablemonitorexpression scopexportablemonitorexpressionResult = default;

            Scopexportablemonitorexpression scopexportablemonitorexpression;

            scopexportablemonitorexpression = new Scopexportablemonitorexpression();

            scopexportablemonitorexpression.IdleObject = Idle;

            scopexportablemonitorexpression.ExpressionObject = Expression;

            scopexportablemonitorexpressionResult = scopexportablemonitorexpression;

            return scopexportablemonitorexpressionResult;
        }
    }
}
