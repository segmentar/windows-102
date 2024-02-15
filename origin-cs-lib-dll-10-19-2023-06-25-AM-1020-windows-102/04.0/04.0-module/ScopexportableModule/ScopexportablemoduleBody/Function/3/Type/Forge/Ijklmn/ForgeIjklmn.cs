using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XTriple
        {
            public static XTriple ForgeIjklmn(ScopexportableijklmnBodyXo_qrstY[] Ijklmn_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADERSOLID)
            {
                XTriple xtripleResult = default;

                var array = FunctionIjklmnSetSurface(Ijklmn_ARRAY, array_SCOPEXPORTABLEFORMHEADERSOLID);

                XTriple xtriple;

                xtriple = new XTriple(array);

                xtripleResult = xtriple;

                return xtripleResult;
            }
        }
    }
}
