using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorquery
    {
        public static void Import(Scopexportablemonitorquery value_SCOPEXPORTABLEMONITORQUERY)
        {
            Idle = (Boolean)value_SCOPEXPORTABLEMONITORQUERY.IdleObject;

            LinkedList = Scopexportablemagic.ScopexportablemagicLinkedListCastDispenser<Scopexportableformhierarchynumeratesolid>(value_SCOPEXPORTABLEMONITORQUERY.LinkedListObject);

            Error = (Int32)value_SCOPEXPORTABLEMONITORQUERY.ErrorObject;

            Scopexportableformhierarchynumeratesolid = (Scopexportableformhierarchynumeratesolid)value_SCOPEXPORTABLEMONITORQUERY.ScopexportableformhierarchynumeratesolidObject;

            LinkedListNode = Scopexportablemagic.ScopexportablemagicLinkedListNodeCastDispenser<Scopexportableformhierarchynumeratesolid>(value_SCOPEXPORTABLEMONITORQUERY.LinkedListNodeObject);

            return;
        }
    }
}
