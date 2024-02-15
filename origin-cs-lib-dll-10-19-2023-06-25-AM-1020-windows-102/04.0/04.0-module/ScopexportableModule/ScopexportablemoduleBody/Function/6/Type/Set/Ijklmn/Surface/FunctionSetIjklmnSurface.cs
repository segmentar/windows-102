using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XSextuple
        {
            public static ScopexportableijklmnBodyXopqrs_Y[] FunctionLevelSetSurface(ScopexportableijklmnBodyXopqr_tY[] Ijklmn_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADERSOLID)
            {
                ScopexportableijklmnBodyXopqrs_Y[] arrayResult = default;

                var list = FunctionLevelSet(Ijklmn_ARRAY, array_SCOPEXPORTABLEFORMHEADERSOLID);

                var array = new ScopexportableijklmnBodyXopqrs_Y[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
