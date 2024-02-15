using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial class XDecuple
        {
            public static Scopexportableformhierarchynumeratesolid[] FunctionNumerateSetSurface(ScopexportableijklmnHierarchyUop_rstV Ijklmn_VALUE)
            {
                Scopexportableformhierarchynumeratesolid[] arrayResult = default;

                var list = FunctionNumerateSet(Ijklmn_VALUE);

                var array = new Scopexportableformhierarchynumeratesolid[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
