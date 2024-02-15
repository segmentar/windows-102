using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorframe
    {
        public static Scopexportablemonitorframe Data()
        {
            Scopexportablemonitorframe scopexportablemonitorframeResult;

            Scopexportablemonitorframe scopexportablemonitorframe;

            scopexportablemonitorframe = new Scopexportablemonitorframe();

            scopexportablemonitorframe.IdleObject = true;

            scopexportablemonitorframe.LinkedListObject = Scopexportablemagic.ScopexportablemagicLinkedListDispenser<Scopexportablemonitortransaction>(new Scopexportablemonitortransaction[0]);

            scopexportablemonitorframe.ScopexportablemonitortransactionArrayObject = new Scopexportablemonitortransaction[0];

            scopexportablemonitorframe.ReadOnlyCollectionObject = Scopexportablemagic.ScopexportablemagicReadOnlyCollectionDispenser<Scopexportablemonitortransaction>(new Scopexportablemonitortransaction[0]);

            scopexportablemonitorframe.PointerObject = 0;

            scopexportablemonitorframeResult = scopexportablemonitorframe;

            return scopexportablemonitorframeResult;
        }
    }
}
