using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorframe
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Scopexportablemonitorframe) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IdleObject) + ':' + ' ' + (Boolean)IdleObject,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(LinkedListObject) + ':' + ' ' + ". . ." + ' ' + $"<{Scopexportablemagic.ScopexportablemagicLinkedListCastDispenser<Scopexportablemonitortransaction>(LinkedListObject).Count}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ScopexportablemonitortransactionArrayObject) + ':' + ' ' + ". . ." + ' ' + $"<{((Scopexportablemonitortransaction[])ScopexportablemonitortransactionArrayObject).Length}>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ReadOnlyCollectionObject) + ':' + ' ' + ". . ." + ' ' + $"<{Scopexportablemagic.ScopexportablemagicReadOnlyCollectionCastDispenser<Scopexportablemonitortransaction>(ReadOnlyCollectionObject).Count}>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(PointerObject) + ':' + ' ' + (Int32)PointerObject,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(LinkedListObject) + ':',
                String.Empty + String.Join('\n'.ToString(), Scopexportablemagic.ScopexportablemagicLinkedListCastDispenser<Scopexportablemonitortransaction>(LinkedListObject)),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ScopexportablemonitortransactionArrayObject) + ':',
                String.Empty + String.Join('\n'.ToString(), (Scopexportablemonitortransaction[])ScopexportablemonitortransactionArrayObject),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(ReadOnlyCollectionObject) + ':',
                String.Empty + String.Join('\n'.ToString(), Scopexportablemagic.ScopexportablemagicReadOnlyCollectionCastDispenser<Scopexportablemonitortransaction>(ReadOnlyCollectionObject))
            });
        }
    }
}
