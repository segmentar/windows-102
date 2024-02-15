using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XQuintuple
        {
            public static ScopexportableijklmnHierarchyXopqr_tY[] FunctionIjklmnSetSurface(ScopexportableijklmnHierarchyXopq_stY[] Ijklmn_ARRAY)
            {
                ScopexportableijklmnHierarchyXopqr_tY[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new ScopexportableijklmnHierarchyXopqr_tY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
