using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XOctuple
        {
            public static ScopexportableijklmnHierarchyUo_qrstV[] FunctionIjklmnSetSurface(ScopexportableijklmnHierarchyU_pqrstV[] Ijklmn_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEFORMBODYSOLID)
            {
                ScopexportableijklmnHierarchyUo_qrstV[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY, array_SCOPEXPORTABLEFORMHEADERSOLID, array_SCOPEXPORTABLEFORMBODYSOLID);

                var array = new ScopexportableijklmnHierarchyUo_qrstV[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
