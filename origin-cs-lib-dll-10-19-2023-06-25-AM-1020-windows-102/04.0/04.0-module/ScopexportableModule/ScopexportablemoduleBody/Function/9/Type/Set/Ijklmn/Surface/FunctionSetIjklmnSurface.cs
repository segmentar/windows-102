using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XNonuple
        {
            public static Scopexportableformbodysolid[] FunctionIjklmnSetSurface(ScopexportableijklmnBodyUo_qrstV[] Ijklmn_ARRAY)
            {
                Scopexportableformbodysolid[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new Scopexportableformbodysolid[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
