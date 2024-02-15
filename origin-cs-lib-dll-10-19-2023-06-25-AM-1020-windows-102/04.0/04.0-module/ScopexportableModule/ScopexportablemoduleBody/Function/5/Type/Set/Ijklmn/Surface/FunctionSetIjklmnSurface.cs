using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XQuintuple
        {
            public static ScopexportableijklmnBodyXopqr_tY[] FunctionIjklmnSetSurface(ScopexportableijklmnBodyXopq_stY[] Ijklmn_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADERSOLID)
            {
                ScopexportableijklmnBodyXopqr_tY[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY, array_SCOPEXPORTABLEFORMHEADERSOLID);

                var array = new ScopexportableijklmnBodyXopqr_tY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
