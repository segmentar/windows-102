using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        public partial class XSingle
        {
            public static ScopexportableijklmnScanX_pqrstY[] FunctionIjklmnSetSurface(String DirectoryFullName___VALUE)
            {
                ScopexportableijklmnScanX_pqrstY[] arrayResult = default;

                var list = FunctionIjklmnSet(DirectoryFullName___VALUE);

                var array = new ScopexportableijklmnScanX_pqrstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
