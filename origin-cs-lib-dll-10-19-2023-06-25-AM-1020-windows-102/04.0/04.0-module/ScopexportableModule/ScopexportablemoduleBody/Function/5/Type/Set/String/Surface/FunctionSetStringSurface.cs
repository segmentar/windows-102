using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XQuintuple
        {
            public static String[] FunctionStringSetSurface(ScopexportableijklmnBodyXopq_stY Ijklmn_VALUE, Scopexportableformheadersolid value_SCOPEXPORTABLEFORMHEADERSOLID)
            {
                String[] arrayResult = default;

                var list = FunctionStringSet(Ijklmn_VALUE, value_SCOPEXPORTABLEFORMHEADERSOLID);

                var array = new String[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}