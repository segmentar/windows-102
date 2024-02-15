using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XQuadruple
        {
            public static IList<ScopexportableijklmnHierarchyXopq_stY> FunctionIjklmnSet(ScopexportableijklmnHierarchyXop_rstY[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnHierarchyXopq_stY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHierarchyXopq_stY>();

                foreach (ScopexportableijklmnHierarchyXop_rstY Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    var array = FunctionDefaultSetSurface(Ijklmn_VALUE);

                    ScopexportableijklmnHierarchyXopq_stY ijklmn;

                    ijklmn = new ScopexportableijklmnHierarchyXopq_stY();

                    ijklmn.Object = Ijklmn_VALUE.Object;

                    ijklmn.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                    ijklmn.FileInfo = Ijklmn_VALUE.FileInfo;

                    ijklmn.Text = Ijklmn_VALUE.Text;

                    ijklmn.Start = Ijklmn_VALUE.Start;

                    ijklmn.End = Ijklmn_VALUE.End;

                    ijklmn.XDoubleArray = Ijklmn_VALUE.XDoubleArray;

                    ijklmn.XTripleArray = Ijklmn_VALUE.XTripleArray;

                    ijklmn.XQuadrupleArray = array;

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnHierarchyXopq_stY>(collectionResult);
            }
        }
    }
}
