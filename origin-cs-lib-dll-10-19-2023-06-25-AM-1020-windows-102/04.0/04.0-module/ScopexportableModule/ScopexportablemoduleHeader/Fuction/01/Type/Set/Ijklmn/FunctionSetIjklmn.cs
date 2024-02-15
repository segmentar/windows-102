using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XSingle
        {
            public static IList<ScopexportableijklmnHeaderX_pqrstY> FunctionIjklmnSet(Scopexportableformcoordinate[] array_SCOPEXPORTABLEFORMCOORDINATE, Object[] array_OBJECT)
            {
                ICollection<ScopexportableijklmnHeaderX_pqrstY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderX_pqrstY>();

                var indexer = 0;

                foreach (Scopexportableformcoordinate value_SCOPEXPORTABLEFORMCOORDINATE in array_SCOPEXPORTABLEFORMCOORDINATE)
                {
                    ScopexportableijklmnHeaderX_pqrstY ijklmn;

                    ijklmn = new ScopexportableijklmnHeaderX_pqrstY();

                    ijklmn.Object = array_OBJECT[indexer];

                    ijklmn.DirectoryInfo = value_SCOPEXPORTABLEFORMCOORDINATE.DirectoryInfo;

                    ijklmn.FileInfo = value_SCOPEXPORTABLEFORMCOORDINATE.FileInfo;

                    ijklmn.Text = value_SCOPEXPORTABLEFORMCOORDINATE.Text;

                    ijklmn.Start = value_SCOPEXPORTABLEFORMCOORDINATE.Start;

                    ijklmn.End = value_SCOPEXPORTABLEFORMCOORDINATE.End;

                    collectionResult.Add(ijklmn);

                    indexer = indexer + 1;

                    continue;
                }

                return new List<ScopexportableijklmnHeaderX_pqrstY>(collectionResult);
            }
        }
    }
}