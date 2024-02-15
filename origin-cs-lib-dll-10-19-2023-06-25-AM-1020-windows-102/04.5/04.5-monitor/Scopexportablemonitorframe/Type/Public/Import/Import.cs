using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorframe
    {
        public static void Import(Scopexportablemonitorframe value_SCOPEXPORTABLEMONITORFRAME)
        {
            Idle = (Boolean)value_SCOPEXPORTABLEMONITORFRAME.IdleObject;

            LinkedList = Scopexportablemagic.ScopexportablemagicLinkedListDispenser<Scopexportablemonitortransaction>(Scopexportablemagic.ScopexportablemagicLinkedListCastDispenser<Scopexportablemonitortransaction>(value_SCOPEXPORTABLEMONITORFRAME.LinkedListObject));

            ScopexportablemonitortransactionArray = (Scopexportablemonitortransaction[])value_SCOPEXPORTABLEMONITORFRAME.ScopexportablemonitortransactionArrayObject;

            ReadOnlyCollection = Scopexportablemagic.ScopexportablemagicReadOnlyCollectionDispenser<Scopexportablemonitortransaction>(Scopexportablemagic.ScopexportablemagicReadOnlyCollectionCastDispenser<Scopexportablemonitortransaction>(value_SCOPEXPORTABLEMONITORFRAME.ReadOnlyCollectionObject));

            Pointer = (Int32)value_SCOPEXPORTABLEMONITORFRAME.PointerObject;
            
            return;
        }
    }
}
