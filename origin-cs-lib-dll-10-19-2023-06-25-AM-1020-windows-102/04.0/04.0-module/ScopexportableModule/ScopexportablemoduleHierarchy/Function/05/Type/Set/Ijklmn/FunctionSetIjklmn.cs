using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XQuintuple
        {
            public static IList<ScopexportableijklmnHierarchyXopqr_tY> FunctionIjklmnSet(ScopexportableijklmnHierarchyXopq_stY[] Level_ARRAY)
            {
                ICollection<ScopexportableijklmnHierarchyXopqr_tY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHierarchyXopqr_tY>();

                foreach (ScopexportableijklmnHierarchyXopq_stY Ijklmn_VALUE in Level_ARRAY)
                {
                    var array = FunctionDefaultSetSurface(Ijklmn_VALUE);

                    ScopexportableijklmnHierarchyXopqr_tY ijklmn;

                    ijklmn = new ScopexportableijklmnHierarchyXopqr_tY();

                    ijklmn.Object = Ijklmn_VALUE.Object;

                    ijklmn.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                    ijklmn.FileInfo = Ijklmn_VALUE.FileInfo;

                    ijklmn.Text = Ijklmn_VALUE.Text;

                    ijklmn.Start = Ijklmn_VALUE.Start;

                    ijklmn.End = Ijklmn_VALUE.End;

                    ijklmn.XDoubleArray = Ijklmn_VALUE.XDoubleArray;

                    ijklmn.XTripleArray = Ijklmn_VALUE.XTripleArray;

                    ijklmn.XQuadrupleArray = Ijklmn_VALUE.XQuadrupleArray;

                    ijklmn.XQuintupleArray = array;

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnHierarchyXopqr_tY>(collectionResult);
            }
        }
    }
}
