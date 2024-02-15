using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorframe
    {
        [Scopexportableiem]
        public static Scopexportablemonitorframe Export()
        {
            Scopexportablemonitorframe scopexportablemonitorframeResult;

            Scopexportablemonitorframe scopexportablemonitorframe;

            scopexportablemonitorframe = new Scopexportablemonitorframe();

            scopexportablemonitorframe.IdleObject = true;

            scopexportablemonitorframe.LinkedListObject = Expressionxportablemagic.ExpressionxportablemagicLinkedListDispenser<Scopexportablemonitortransaction>(LinkedList);

            scopexportablemonitorframe.ScopexportablemonitortransactionArrayObject = ScopexportablemonitortransactionArray;

            scopexportablemonitorframe.ReadOnlyCollectionObject = Scopexportablemagic.ScopexportablemagicReadOnlyCollectionDispenser<Scopexportablemonitortransaction>(ReadOnlyCollection);

            scopexportablemonitorframe.PointerObject = Pointer;

            scopexportablemonitorframeResult = scopexportablemonitorframe;

            return scopexportablemonitorframeResult;
        }
    }
}
