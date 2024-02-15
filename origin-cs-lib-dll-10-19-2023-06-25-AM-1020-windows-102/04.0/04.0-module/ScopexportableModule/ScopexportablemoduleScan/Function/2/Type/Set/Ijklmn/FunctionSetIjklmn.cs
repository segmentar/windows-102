using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleScan
    {
        public partial class XDouble
        {
            public static IList<ScopexportableijklmnScanXo_qrstY> FunctionIjklmnSet(ScopexportableijklmnScanX_pqrstY[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnScanXo_qrstY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnScanXo_qrstY>();

                foreach (ScopexportableijklmnScanX_pqrstY Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    var array = Directory.GetFiles(Ijklmn_VALUE.DirectoryInfo.FullName);

                    foreach (String stringValue in array)
                    {
                        FileInfo fileInfo;

                        fileInfo = new FileInfo(stringValue);

                        ScopexportableijklmnScanXo_qrstY ijklmn;

                        ijklmn = new ScopexportableijklmnScanXo_qrstY();

                        ijklmn.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                        ijklmn.FileInfo = fileInfo;

                        collectionResult.Add(ijklmn);

                        continue;
                    }

                    continue;
                }

                return new List<ScopexportableijklmnScanXo_qrstY>(collectionResult);
            }
        }
    }
}
