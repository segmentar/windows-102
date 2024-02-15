using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial class XDecuple
        {
            public static Scopexportableformhierarchysolid[] FunctionDefaultSetSurface(ScopexportableijklmnHierarchyUop_rstV[] Ijklmn_ARRAY)
            {
                Scopexportableformhierarchysolid[] arrayResult = default;

                var list = FunctionDefaultSet(Ijklmn_ARRAY);

                var array = new Scopexportableformhierarchysolid[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
