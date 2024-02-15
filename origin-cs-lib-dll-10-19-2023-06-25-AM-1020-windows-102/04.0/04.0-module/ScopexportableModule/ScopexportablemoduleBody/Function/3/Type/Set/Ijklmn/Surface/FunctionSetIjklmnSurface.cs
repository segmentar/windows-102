using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XTriple
        {
            public static ScopexportableijklmnBodyXop_rstY[] FunctionIjklmnSetSurface(ScopexportableijklmnBodyXo_qrstY[] Ijklmn_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADERSOLID)
            {
                ScopexportableijklmnBodyXop_rstY[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY, array_SCOPEXPORTABLEFORMHEADERSOLID);

                var array = new ScopexportableijklmnBodyXop_rstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
