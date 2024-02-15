using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial class XSingle
        {
            public static IList<ScopexportableijklmnHierarchyX_pqrstY> FunctionIjklmnSet(Scopexportableformcoordinate[] array_SCOPEXPORTABLEFORMCOORDINATE, Object[] array_OBJECT)
            {
                ICollection<ScopexportableijklmnHierarchyX_pqrstY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHierarchyX_pqrstY>();

                var indexer = 0;

                foreach (Scopexportableformcoordinate value_SCOPEXPORTABLEFORMCOORDINATE in array_SCOPEXPORTABLEFORMCOORDINATE)
                {
                    var value = array_OBJECT[indexer];

                    ScopexportableijklmnHierarchyX_pqrstY ijklmn;

                    ijklmn = new ScopexportableijklmnHierarchyX_pqrstY();

                    ijklmn.Object = value;

                    ijklmn.DirectoryInfo = value_SCOPEXPORTABLEFORMCOORDINATE.DirectoryInfo;

                    ijklmn.FileInfo = value_SCOPEXPORTABLEFORMCOORDINATE.FileInfo;

                    ijklmn.Text = value_SCOPEXPORTABLEFORMCOORDINATE.Text;

                    ijklmn.Start = value_SCOPEXPORTABLEFORMCOORDINATE.Start;

                    ijklmn.End = value_SCOPEXPORTABLEFORMCOORDINATE.End;

                    collectionResult.Add(ijklmn);

                    indexer = indexer + 1;

                    continue;
                }

                return new List<ScopexportableijklmnHierarchyX_pqrstY>(collectionResult);
            }
        }
    }
}
