using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XSeptuple
        {
            public static IList<ScopexportableijklmnHierarchyU_pqrstV> FunctionIjklmnSet(ScopexportableijklmnHierarchyXopqrs_Y[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnHierarchyU_pqrstV> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHierarchyU_pqrstV>();

                foreach (ScopexportableijklmnHierarchyXopqrs_Y Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    var array = FunctionDefaultSetSurface(Ijklmn_VALUE);

                    ScopexportableijklmnHierarchyU_pqrstV ijklmn;

                    ijklmn = new ScopexportableijklmnHierarchyU_pqrstV();

                    ijklmn.Object = Ijklmn_VALUE.Object;

                    ijklmn.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                    ijklmn.FileInfo = Ijklmn_VALUE.FileInfo;

                    ijklmn.Text = Ijklmn_VALUE.Text;

                    ijklmn.Start = Ijklmn_VALUE.Start;

                    ijklmn.End = Ijklmn_VALUE.End;

                    ijklmn.XDoubleArray = Ijklmn_VALUE.XDoubleArray;

                    ijklmn.XTripleArray = Ijklmn_VALUE.XTripleArray;

                    ijklmn.XQuadrupleArray = Ijklmn_VALUE.XQuadrupleArray;

                    ijklmn.XQuintupleArray = Ijklmn_VALUE.XQuintupleArray;

                    ijklmn.XSextupleArray = Ijklmn_VALUE.XSextupleArray;

                    ijklmn.XSeptupleArray = array;

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnHierarchyU_pqrstV>(collectionResult);
            }
        }
    }
}
