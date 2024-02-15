using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XDouble
        {
            public static IList<ScopexportableijklmnHierarchyXo_qrstY> FunctionIjklmnSet(ScopexportableijklmnHierarchyX_pqrstY[] Ijklmn_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFROMHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEFORMBODYSOLID)
            {
                ICollection<ScopexportableijklmnHierarchyXo_qrstY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHierarchyXo_qrstY>();

                foreach (ScopexportableijklmnHierarchyX_pqrstY Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    foreach (Scopexportableformheadersolid value_SCOPEXPORTABLEHEADERSOLID in array_SCOPEXPORTABLEFROMHEADERSOLID)
                    {
                        foreach (Scopexportableformbodysolid value_SCOPEXPORTABLEBODYSOLID in array_SCOPEXPORTABLEFORMBODYSOLID)
                        {
                            var boolean = true;

                            boolean = boolean && Object.ReferenceEquals(value_SCOPEXPORTABLEHEADERSOLID.Object, Ijklmn_VALUE.Object) is true;

                            boolean = boolean && Object.ReferenceEquals(value_SCOPEXPORTABLEBODYSOLID.Object, Ijklmn_VALUE.Object) is true;

                            Boolean isEqualCheck, shouldContinueCheck;

                            isEqualCheck = boolean is true;

                            shouldContinueCheck = isEqualCheck is false;

                            if (shouldContinueCheck is true)
                            {
                                continue;
                            }
                            else
                                "false".ToString();

                            var array = FunctionDefaultSetSurface(Ijklmn_VALUE, value_SCOPEXPORTABLEHEADERSOLID, value_SCOPEXPORTABLEBODYSOLID);

                            ScopexportableijklmnHierarchyXo_qrstY ijklmn;

                            ijklmn = new ScopexportableijklmnHierarchyXo_qrstY();

                            ijklmn.Object = Ijklmn_VALUE.Object;

                            ijklmn.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                            ijklmn.FileInfo = Ijklmn_VALUE.FileInfo;

                            ijklmn.Text = Ijklmn_VALUE.Text;

                            ijklmn.Start = Ijklmn_VALUE.Start;

                            ijklmn.End = Ijklmn_VALUE.End;

                            ijklmn.XDoubleArray = array;

                            collectionResult.Add(ijklmn);

                            continue;
                        }

                        continue;
                    }

                    continue;
                }

                return new List<ScopexportableijklmnHierarchyXo_qrstY>(collectionResult);
            }
        }
    }
}