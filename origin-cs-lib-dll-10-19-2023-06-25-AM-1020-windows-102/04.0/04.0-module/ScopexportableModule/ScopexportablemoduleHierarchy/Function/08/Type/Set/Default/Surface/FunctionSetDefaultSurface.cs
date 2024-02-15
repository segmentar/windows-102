using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XOctuple
        {
            public static XOctuple[] FunctionDefaultSetSurface(ScopexportableijklmnHierarchyU_pqrstV Ijklmn_VALUE, Scopexportableformheadersolid value_SCOPEXPORTABLEFORMHEADERSOLID, Scopexportableformbodysolid value_SCOPEXPORTABLEFORMBODYSOLID)
            {
                XOctuple[] arrayResult = default;

                var list = FunctionDefaultSet(Ijklmn_VALUE, value_SCOPEXPORTABLEFORMHEADERSOLID, value_SCOPEXPORTABLEFORMBODYSOLID);

                var array = new XOctuple[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
