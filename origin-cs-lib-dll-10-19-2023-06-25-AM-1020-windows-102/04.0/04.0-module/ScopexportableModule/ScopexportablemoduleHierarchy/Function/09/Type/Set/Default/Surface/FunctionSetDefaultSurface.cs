using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XNonuple
        {
            public static XNonuple[] FunctionDefaultSetSurface(ScopexportableijklmnHierarchyUo_qrstV Ijklmn_ARRAY)
            {
                XNonuple[] arrayResult = default;

                var list = FunctionDefaultSet(Ijklmn_ARRAY);

                var array = new XNonuple[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
