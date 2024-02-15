using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XDouble
        {
            public static XDouble[] FunctionDefaultSetSurface(ScopexportableijklmnHierarchyX_pqrstY Ijklmn_VALUE, Scopexportableformheadersolid value_SCOPEXPORTABLEFORMHEADERSOLID, Scopexportableformbodysolid value_SCOPEXPORTABLEFORMBODYSOLID)
            {
                XDouble[] arrayResult = default;

                var list = FunctionDefaultSet(Ijklmn_VALUE, value_SCOPEXPORTABLEFORMHEADERSOLID, value_SCOPEXPORTABLEFORMBODYSOLID);

                var array = new XDouble[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
