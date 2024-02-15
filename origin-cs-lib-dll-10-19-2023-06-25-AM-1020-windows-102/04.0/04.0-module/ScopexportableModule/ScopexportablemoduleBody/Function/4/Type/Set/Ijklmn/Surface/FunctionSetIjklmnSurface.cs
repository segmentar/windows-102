using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XQuadruple
        {
            public static ScopexportableijklmnBodyXopq_stY[] FunctionIjklmnSetSurface(ScopexportableijklmnBodyXop_rstY[] Ijklmn_ARRAY)
            {
                ScopexportableijklmnBodyXopq_stY[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new ScopexportableijklmnBodyXopq_stY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
