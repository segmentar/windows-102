using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XNonuple
        {
            public static ScopexportableijklmnHeaderUop_rstV[] FunctionIjklmnSetSurface(ScopexportableijklmnHeaderUo_qrstV[] Ijklmn_ARRAY)
            {
                ScopexportableijklmnHeaderUop_rstV[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new ScopexportableijklmnHeaderUop_rstV[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
