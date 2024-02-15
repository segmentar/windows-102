using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XSingle
        {
            public static IList<ScopexportableijklmnBodyX_pqrstY> FunctionIjklmnSet(Scopexportableformcoordinate[] array_SCOPEXPORTABLEFORMCOORDINATE, Object[] array_OBJECT)
            {
                ICollection<ScopexportableijklmnBodyX_pqrstY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnBodyX_pqrstY>();

                var indexer = 0;

                foreach (Scopexportableformcoordinate scopexportableformcoordinate in array_SCOPEXPORTABLEFORMCOORDINATE)
                {
                    var value = array_OBJECT[indexer];

                    ScopexportableijklmnBodyX_pqrstY ijklmn;

                    ijklmn = new ScopexportableijklmnBodyX_pqrstY();

                    ijklmn.Object = value;

                    ijklmn.DirectoryInfo = scopexportableformcoordinate.DirectoryInfo;

                    ijklmn.FileInfo = scopexportableformcoordinate.FileInfo;

                    ijklmn.Text = scopexportableformcoordinate.Text;

                    ijklmn.Start = scopexportableformcoordinate.Start;

                    ijklmn.End = scopexportableformcoordinate.End;

                    collectionResult.Add(ijklmn);

                    indexer = indexer + 1;

                    continue;
                }

                return new List<ScopexportableijklmnBodyX_pqrstY>(collectionResult);
            }
        }
    }
}
