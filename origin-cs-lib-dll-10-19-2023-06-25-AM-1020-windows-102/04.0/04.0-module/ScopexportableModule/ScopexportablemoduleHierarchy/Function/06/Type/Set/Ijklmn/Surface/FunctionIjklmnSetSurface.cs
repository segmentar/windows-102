using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XSextuple
        {
            public static ScopexportableijklmnHierarchyXopqrs_Y[] FunctionIjklmnSetSurface(ScopexportableijklmnHierarchyXopqr_tY[] Ijklmn_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADERSOLID)
            {
                ScopexportableijklmnHierarchyXopqrs_Y[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY, array_SCOPEXPORTABLEFORMHEADERSOLID);

                var array = new ScopexportableijklmnHierarchyXopqrs_Y[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
