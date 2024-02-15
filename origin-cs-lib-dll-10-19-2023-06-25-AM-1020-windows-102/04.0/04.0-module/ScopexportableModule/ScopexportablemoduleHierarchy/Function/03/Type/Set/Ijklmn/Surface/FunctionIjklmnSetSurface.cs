using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XTriple
        {
            public static ScopexportableijklmnHierarchyXop_rstY[] FunctionIjklmnSetSurface(ScopexportableijklmnHierarchyXo_qrstY[] Ijklmn_ARRAY, Scopexportableformbodysolid[] array_SCOPEXPORTABLEFORMBODYSOLID)
            {
                ScopexportableijklmnHierarchyXop_rstY[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY, array_SCOPEXPORTABLEFORMBODYSOLID);

                var array = new ScopexportableijklmnHierarchyXop_rstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
