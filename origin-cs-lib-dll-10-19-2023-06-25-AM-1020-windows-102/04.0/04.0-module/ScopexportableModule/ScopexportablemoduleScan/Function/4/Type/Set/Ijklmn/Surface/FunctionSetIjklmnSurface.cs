using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        public partial class XQuadruple
        {
            public static Scopexportableformscansolid[] FunctionIjklmnSetSurface(ScopexportableijklmnScanXop_rstY[] Ijklmn_ARRAY)
            {
                Scopexportableformscansolid[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new Scopexportableformscansolid[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
