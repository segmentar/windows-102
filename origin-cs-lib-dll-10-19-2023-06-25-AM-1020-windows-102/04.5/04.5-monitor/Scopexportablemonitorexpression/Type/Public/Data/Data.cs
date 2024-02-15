using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorexpression
    {
        public static Scopexportablemonitorexpression Data()
        {
            Scopexportablemonitorexpression scopexportablemonitorexpressionResult = default;

            Scopexportablemonitorexpression scopexportablemonitorexpression;

            scopexportablemonitorexpression = new Scopexportablemonitorexpression();

            scopexportablemonitorexpression.IdleObject = false;

            scopexportablemonitorexpression.ExpressionObject = Scopexportablestringsafe.ForgeDefault(String.Empty);

            scopexportablemonitorexpressionResult = scopexportablemonitorexpression;

            return scopexportablemonitorexpressionResult;
        }
    }
}
