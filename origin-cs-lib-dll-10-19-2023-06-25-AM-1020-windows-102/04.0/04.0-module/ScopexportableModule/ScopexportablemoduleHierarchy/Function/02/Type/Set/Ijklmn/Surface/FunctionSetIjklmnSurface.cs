using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XDouble
        {
            public static ScopexportableijklmnHierarchyXo_qrstY[] FunctionIjklmnSetSurface(ScopexportableijklmnHierarchyX_pqrstY[] Ijklmn_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFROMHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEFORMBODYSOLID)
            {
                ScopexportableijklmnHierarchyXo_qrstY[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY, array_SCOPEXPORTABLEFROMHEADERSOLID, array_SCOPEXPORTABLEFORMBODYSOLID);

                var array = new ScopexportableijklmnHierarchyXo_qrstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}