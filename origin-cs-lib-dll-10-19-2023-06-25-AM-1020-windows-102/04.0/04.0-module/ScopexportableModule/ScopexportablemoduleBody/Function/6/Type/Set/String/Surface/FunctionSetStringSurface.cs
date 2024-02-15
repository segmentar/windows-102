using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XSextuple
        {
            public static String[] FunctionStringSetSurface(ScopexportableijklmnBodyXopqr_tY Ijklmn_VALUE, Scopexportableformheadersolid value_SCOPEXPORTABLEFORMHEADER)
            {
                String[] arrayResult = default;

                var list = FunctionStringSet(Ijklmn_VALUE, value_SCOPEXPORTABLEFORMHEADER);

                var array = new String[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}