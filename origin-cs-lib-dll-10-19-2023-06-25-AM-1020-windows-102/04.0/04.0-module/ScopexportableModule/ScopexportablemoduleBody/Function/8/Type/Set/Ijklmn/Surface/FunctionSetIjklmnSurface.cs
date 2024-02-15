using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XOctuple
        {
            public static ScopexportableijklmnBodyUo_qrstV[] FunctionIjklmnSetSurface(ScopexportableijklmnBodyU_pqrstV[] Ijklmn_ARRAY)
            {
                ScopexportableijklmnBodyUo_qrstV[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new ScopexportableijklmnBodyUo_qrstV[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
