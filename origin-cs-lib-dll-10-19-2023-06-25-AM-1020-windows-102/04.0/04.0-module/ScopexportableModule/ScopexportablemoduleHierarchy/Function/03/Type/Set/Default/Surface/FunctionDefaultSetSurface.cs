using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XTriple
        {
            public static XTriple[] FunctionDefaultSetSurface(ScopexportableijklmnHierarchyXo_qrstY Ijklmn_VALUE, Scopexportableformbodysolid value_SCOPEXPORTABLEFORMBODY)
            {
                XTriple[] arrayResult = default;

                var list = FunctionDefaultSet(Ijklmn_VALUE, value_SCOPEXPORTABLEFORMBODY);

                var array = new XTriple[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
