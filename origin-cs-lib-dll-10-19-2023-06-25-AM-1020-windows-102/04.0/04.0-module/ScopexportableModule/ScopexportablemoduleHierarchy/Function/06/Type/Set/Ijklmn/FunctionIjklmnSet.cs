using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XSextuple
        {
            public static IList<ScopexportableijklmnHierarchyXopqrs_Y> FunctionIjklmnSet(ScopexportableijklmnHierarchyXopqr_tY[] Ijklmn_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADERSOLID)
            {
                ICollection<ScopexportableijklmnHierarchyXopqrs_Y> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHierarchyXopqrs_Y>();

                foreach (ScopexportableijklmnHierarchyXopqr_tY Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    foreach (Scopexportableformheadersolid value_SCOPEXPORTABLEHEADERSOLID in array_SCOPEXPORTABLEFORMHEADERSOLID)
                    {
                        Boolean isReferenceCheck, shouldContinueCheck;

                        isReferenceCheck = Object.ReferenceEquals(value_SCOPEXPORTABLEHEADERSOLID.Object, Ijklmn_VALUE.Object) is true;

                        shouldContinueCheck = isReferenceCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var array = FunctionDefaultSetSurface(Ijklmn_VALUE, value_SCOPEXPORTABLEHEADERSOLID);

                        ScopexportableijklmnHierarchyXopqrs_Y ijklmn;

                        ijklmn = new ScopexportableijklmnHierarchyXopqrs_Y();

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

                        ijklmn.XSextupleArray = array;

                        collectionResult.Add(ijklmn);

                        continue;
                    }

                    continue;
                }

                return new List<ScopexportableijklmnHierarchyXopqrs_Y>(collectionResult);
            }
        }
    }
}
