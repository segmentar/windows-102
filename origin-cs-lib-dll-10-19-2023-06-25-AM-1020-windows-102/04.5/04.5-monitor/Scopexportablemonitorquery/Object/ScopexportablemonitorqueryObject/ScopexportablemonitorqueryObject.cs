﻿using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorquery
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Scopexportablemonitorquery) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IdleObject) + ':' + ' ' + (Boolean)IdleObject,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(LinkedListObject) + ':' + ' ' + ". . ." + ' ' + $"<{Scopexportablemagic.ScopexportablemagicLinkedListCastDispenser<Scopexportableformhierarchynumeratesolid>(LinkedListObject).Count}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ErrorObject) + ':' + ' ' + (Int32)ErrorObject,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ScopexportableformhierarchynumeratesolidObject) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(LinkedListNodeObject) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(LinkedListObject) + ':',
                String.Empty + String.Join('\n'.ToString(), Scopexportablemagic.ScopexportablemagicLinkedListCastDispenser<Scopexportableformhierarchynumeratesolid>(LinkedListObject)),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ScopexportableformhierarchynumeratesolidObject) + ':',
                String.Empty + (Scopexportablemagic.ScopexportableEqualityComparerDispenser<Scopexportableformhierarchynumeratesolid>((Scopexportableformhierarchynumeratesolid)ScopexportableformhierarchynumeratesolidObject) ? String.Empty : ((Scopexportableformhierarchynumeratesolid)ScopexportableformhierarchynumeratesolidObject).ToString()),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(LinkedListNodeObject) + ':',
                String.Empty + Scopexportablemagic.ScopexportablemagicLinkedListNodeCastDispenser<Scopexportableformhierarchynumeratesolid>(LinkedListNodeObject),
            });
        }
    }
}
