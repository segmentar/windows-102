﻿using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XQuintuple
        {
            public static XQuintuple[] FunctionDefaultSetSurface(ScopexportableijklmnHierarchyXopq_stY Ijklmn_VALUE)
            {
                XQuintuple[] arrayResult = default;

                var list = FunctionDefaultSet(Ijklmn_VALUE);

                var array = new XQuintuple[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            } 
        }
    }
}
