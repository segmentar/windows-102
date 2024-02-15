using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XSextuple
        {
            public static XSextuple[] FunctionDefaultSetSurface(ScopexportableijklmnHierarchyXopqr_tY Ijklmn_VALUE, Scopexportableformheadersolid value_SCOPEXPORTABLEFORMHEADERSOLID)
            {
                XSextuple[] arrayResult = default;

                var list = FunctionDefaultSet(Ijklmn_VALUE, value_SCOPEXPORTABLEFORMHEADERSOLID);

                var array = new XSextuple[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
