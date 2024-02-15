using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XNonuple
        {
            public static IList<ScopexportableijklmnHierarchyUop_rstV> FunctionIjklmnSet(ScopexportableijklmnHierarchyUo_qrstV[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnHierarchyUop_rstV> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHierarchyUop_rstV>();

                foreach (ScopexportableijklmnHierarchyUo_qrstV Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    var array = FunctionDefaultSetSurface(Ijklmn_VALUE);

                    ScopexportableijklmnHierarchyUop_rstV ijklmn;

                    ijklmn = new ScopexportableijklmnHierarchyUop_rstV();

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

                    ijklmn.XSeptupleArray = Ijklmn_VALUE.XSeptupleArray;

                    ijklmn.XOctupleArray = Ijklmn_VALUE.XOctupleArray;

                    ijklmn.XNonupleArray = array;

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnHierarchyUop_rstV>(collectionResult);
            }
        }
    }
}
