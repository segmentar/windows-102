using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        public partial class XTriple
        {
            public static ScopexportableijklmnScanXop_rstY[] FunctionIjklmnSetSurface(ScopexportableijklmnScanXo_qrstY[] Ijklmn_ARRAY)
            {
                ScopexportableijklmnScanXop_rstY[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new ScopexportableijklmnScanXop_rstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
