using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XNonuple
        {
            public static ScopexportableijklmnHierarchyUop_rstV[] FunctionIjklmnSetSurface(ScopexportableijklmnHierarchyUo_qrstV[] Ijklmn_ARRAY)
            {
                ScopexportableijklmnHierarchyUop_rstV[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new ScopexportableijklmnHierarchyUop_rstV[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
