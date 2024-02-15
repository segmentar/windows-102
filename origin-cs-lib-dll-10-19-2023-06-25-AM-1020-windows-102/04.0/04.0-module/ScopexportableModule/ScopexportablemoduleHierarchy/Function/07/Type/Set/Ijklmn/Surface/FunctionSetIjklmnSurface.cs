using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XSeptuple
        {
            public static ScopexportableijklmnHierarchyU_pqrstV[] FunctionIjklmnSetSurface(ScopexportableijklmnHierarchyXopqrs_Y[] Ijklmn_ARRAY)
            {
                ScopexportableijklmnHierarchyU_pqrstV[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new ScopexportableijklmnHierarchyU_pqrstV[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
