using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XOctuple
        {
            public static IList<ScopexportableijklmnHierarchyUo_qrstV> FunctionIjklmnSet(ScopexportableijklmnHierarchyU_pqrstV[] Ijklmn_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEFORMBODYSOLID)
            {
                ICollection<ScopexportableijklmnHierarchyUo_qrstV> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHierarchyUo_qrstV>();

                foreach (ScopexportableijklmnHierarchyU_pqrstV Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    foreach (Scopexportableformheadersolid value_SCOPEXPORTABLEHEADERSOLID in array_SCOPEXPORTABLEFORMHEADERSOLID)
                    {
                        foreach (Scopexportableformbodysolid value_SCOPEXPORTABLEBODYSOLID in array_SCOPEXPORTABLEFORMBODYSOLID)
                        {
                            var boolean = true;

                            boolean = boolean && Object.ReferenceEquals(value_SCOPEXPORTABLEHEADERSOLID.Object, Ijklmn_VALUE.Object) is true;

                            boolean = boolean && Object.ReferenceEquals(value_SCOPEXPORTABLEBODYSOLID.Object, Ijklmn_VALUE.Object) is true;

                            Boolean isReferenceCheck, shouldContinueCheck;

                            isReferenceCheck = boolean is true;

                            shouldContinueCheck = isReferenceCheck is false;

                            if (shouldContinueCheck is true)
                            {
                                continue;
                            }
                            else
                                "false".ToString();

                            var array = FunctionDefaultSetSurface(Ijklmn_VALUE, value_SCOPEXPORTABLEHEADERSOLID, value_SCOPEXPORTABLEBODYSOLID);

                            ScopexportableijklmnHierarchyUo_qrstV ijklmn;

                            ijklmn = new ScopexportableijklmnHierarchyUo_qrstV();

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

                            ijklmn.XOctupleArray = array;

                            collectionResult.Add(ijklmn);

                            continue;
                        }

                        continue;
                    }

                    continue;
                }

                return new List<ScopexportableijklmnHierarchyUo_qrstV>(collectionResult);
            }
        }
    }
}
