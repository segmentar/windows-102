﻿using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorquery
    {
        public static Scopexportablemonitorquery Export()
        {
            Scopexportablemonitorquery scopexportablemonitorqueryResult = default;

            Scopexportablemonitorquery scopexportablemonitorquery;

            scopexportablemonitorquery = new Scopexportablemonitorquery();

            scopexportablemonitorquery.IdleObject = Idle;

            scopexportablemonitorquery.LinkedListObject = LinkedList;

            scopexportablemonitorquery.ErrorObject = Error;

            scopexportablemonitorquery.ScopexportableformhierarchynumeratesolidObject = Scopexportableformhierarchynumeratesolid;

            scopexportablemonitorquery.LinkedListNodeObject = LinkedListNode;

            scopexportablemonitorqueryResult = scopexportablemonitorquery;

            return scopexportablemonitorqueryResult;
        }
    }
}
