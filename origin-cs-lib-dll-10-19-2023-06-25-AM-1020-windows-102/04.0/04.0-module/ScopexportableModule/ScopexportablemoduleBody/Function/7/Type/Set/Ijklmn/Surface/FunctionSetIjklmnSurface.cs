using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XSeptuple
        {
            public static ScopexportableijklmnBodyU_pqrstV[] FunctionIjklmnSetSurface(ScopexportableijklmnBodyXopqrs_Y[] Ijklmn_ARRAY)
            {
                ScopexportableijklmnBodyU_pqrstV[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new ScopexportableijklmnBodyU_pqrstV[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
