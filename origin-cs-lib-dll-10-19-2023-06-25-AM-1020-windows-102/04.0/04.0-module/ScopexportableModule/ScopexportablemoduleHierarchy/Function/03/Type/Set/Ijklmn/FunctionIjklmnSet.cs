using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XTriple
        {
            public static IList<ScopexportableijklmnHierarchyXop_rstY> FunctionIjklmnSet(ScopexportableijklmnHierarchyXo_qrstY[] Ijklmn_ARRAY, Scopexportableformbodysolid[] array_SCOPEXPORTABLEFORMBODYSOLID)
            {
                ICollection<ScopexportableijklmnHierarchyXop_rstY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHierarchyXop_rstY>();

                foreach (ScopexportableijklmnHierarchyXo_qrstY Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    foreach (Scopexportableformbodysolid value_SCOPEXPORTABLEBODYSOLID in array_SCOPEXPORTABLEFORMBODYSOLID)
                    {
                        Boolean isReferenceCheck, shouldContinueCheck;

                        isReferenceCheck = Object.ReferenceEquals(value_SCOPEXPORTABLEBODYSOLID.Object, Ijklmn_VALUE.Object) is true;

                        shouldContinueCheck = isReferenceCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var array = FunctionDefaultSetSurface(Ijklmn_VALUE, value_SCOPEXPORTABLEBODYSOLID);

                        ScopexportableijklmnHierarchyXop_rstY ijklmn;

                        ijklmn = new ScopexportableijklmnHierarchyXop_rstY();

                        ijklmn.Object = Ijklmn_VALUE.Object;

                        ijklmn.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                        ijklmn.FileInfo = Ijklmn_VALUE.FileInfo;

                        ijklmn.Text = Ijklmn_VALUE.Text;

                        ijklmn.Start = Ijklmn_VALUE.Start;

                        ijklmn.End = Ijklmn_VALUE.End;

                        ijklmn.XDoubleArray = Ijklmn_VALUE.XDoubleArray;

                        ijklmn.XTripleArray = array;

                        collectionResult.Add(ijklmn);

                        continue;
                    }

                    continue;
                }

                return new List<ScopexportableijklmnHierarchyXop_rstY>(collectionResult);
            }
        }
    }
}
