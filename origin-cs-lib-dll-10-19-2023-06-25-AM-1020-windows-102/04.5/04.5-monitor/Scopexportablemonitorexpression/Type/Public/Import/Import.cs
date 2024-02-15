using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorexpression
    {
        public static void Import(Scopexportablemonitorexpression value_SCOPEXPORTABLEMONITOREXPRESSION)
        {
            Idle = (Boolean)value_SCOPEXPORTABLEMONITOREXPRESSION.IdleObject;

            Expression = (Scopexportablestringsafe)value_SCOPEXPORTABLEMONITOREXPRESSION.ExpressionObject;

            return;
        }
    }
}
