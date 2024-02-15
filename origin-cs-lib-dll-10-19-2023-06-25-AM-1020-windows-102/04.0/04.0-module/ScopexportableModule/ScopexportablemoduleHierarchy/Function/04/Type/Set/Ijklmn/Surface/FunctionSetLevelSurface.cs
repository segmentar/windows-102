using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XQuadruple
        {
            public static ScopexportableijklmnHierarchyXopq_stY[] FunctionIjklmnSetSurface(ScopexportableijklmnHierarchyXop_rstY[] Ijklmn_ARRAY)
            {
                ScopexportableijklmnHierarchyXopq_stY[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new ScopexportableijklmnHierarchyXopq_stY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
