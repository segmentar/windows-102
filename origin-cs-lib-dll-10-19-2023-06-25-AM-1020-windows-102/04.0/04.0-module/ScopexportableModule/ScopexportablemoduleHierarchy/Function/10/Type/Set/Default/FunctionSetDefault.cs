using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial class XDecuple
        {
            public static IList<Scopexportableformhierarchysolid> FunctionDefaultSet(ScopexportableijklmnHierarchyUop_rstV[] Ijklmn_ARRAY)
            {
                ICollection<Scopexportableformhierarchysolid> collectionResult = default;

                collectionResult = new Collection<Scopexportableformhierarchysolid>();

                foreach (ScopexportableijklmnHierarchyUop_rstV Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    var array = FunctionNumerateSetSurface(Ijklmn_VALUE);

                    Scopexportableformhierarchysolid scopexportableformhierarchysolid;

                    scopexportableformhierarchysolid = new Scopexportableformhierarchysolid();

                    scopexportableformhierarchysolid.Object = Ijklmn_VALUE.Object;

                    scopexportableformhierarchysolid.ScopexportablehierarchynumeratesolidArray = array;

                    collectionResult.Add(scopexportableformhierarchysolid);

                    continue;
                }

                return new List<Scopexportableformhierarchysolid>(collectionResult);
            }
        }
    }
}
