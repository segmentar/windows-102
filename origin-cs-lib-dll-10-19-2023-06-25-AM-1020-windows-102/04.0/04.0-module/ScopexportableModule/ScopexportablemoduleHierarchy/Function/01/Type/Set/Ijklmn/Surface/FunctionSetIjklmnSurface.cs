using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial class XSingle
        {
            public static ScopexportableijklmnHierarchyX_pqrstY[] FunctionIjklmnSetSurface(Scopexportableformcoordinate[] array_SCOPEXPORTABLEFORMCOORDINATE, Object[] array_OBJECT)
            {
                ScopexportableijklmnHierarchyX_pqrstY[] arrayResult = default;

                var list = FunctionIjklmnSet(array_SCOPEXPORTABLEFORMCOORDINATE, array_OBJECT);

                var array = new ScopexportableijklmnHierarchyX_pqrstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
