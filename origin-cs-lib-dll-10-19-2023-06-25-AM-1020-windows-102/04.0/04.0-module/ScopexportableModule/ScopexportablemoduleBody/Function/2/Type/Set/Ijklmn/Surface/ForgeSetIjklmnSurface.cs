using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XDouble
        {
            public static ScopexportableijklmnBodyXo_qrstY[] FunctionIjklmnSetSurface(ScopexportableijklmnBodyX_pqrstY[] Ijklmn_ARRAY)
            {
                ScopexportableijklmnBodyXo_qrstY[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new ScopexportableijklmnBodyXo_qrstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
