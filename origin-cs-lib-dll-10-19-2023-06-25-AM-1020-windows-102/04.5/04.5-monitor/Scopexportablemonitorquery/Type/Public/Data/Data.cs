using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct Scopexportablemonitorquery
    {
        public static Scopexportablemonitorquery Data()
        {
            Scopexportablemonitorquery scopexportablemonitorqueryResult = default;

            Scopexportablemonitorquery scopexportablemonitorquery;

            scopexportablemonitorquery = new Scopexportablemonitorquery();

            scopexportablemonitorquery.IdleObject = true;

            scopexportablemonitorquery.LinkedListObject = Scopexportablemagic.ScopexportablemagicLinkedListDispenser<Scopexportableformhierarchynumeratesolid>(new Scopexportableformhierarchynumeratesolid[0]);

            scopexportablemonitorquery.ErrorObject = -1;

            scopexportablemonitorquery.ScopexportableformhierarchynumeratesolidObject = default(Scopexportableformhierarchynumeratesolid);

            scopexportablemonitorquery.LinkedListNodeObject = default(LinkedListNode<Scopexportableformhierarchysolid>);

            scopexportablemonitorqueryResult = scopexportablemonitorquery;

            return scopexportablemonitorqueryResult;
        }
    }
}
