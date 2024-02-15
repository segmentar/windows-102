using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        public partial class XDouble
        {
            public static XDouble ForgeLevel(ScopexportableijklmnScanX_pqrstY[] Ijklmn_ARRAY)
            {
                XDouble xdoubleResult = default;

                var array = FunctionIjklmnSetSurface(Ijklmn_ARRAY);

                XDouble xdouble;

                xdouble = new XDouble(array);

                xdoubleResult = xdouble;

                return xdoubleResult;
            }
        }
    }
}
