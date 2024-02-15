using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        public partial class XDouble
        {
            public static ScopexportableijklmnScanXo_qrstY[] FunctionIjklmnSetSurface(ScopexportableijklmnScanX_pqrstY[] Ijklmn_ARRAY)
            {
                ScopexportableijklmnScanXo_qrstY[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new ScopexportableijklmnScanXo_qrstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
