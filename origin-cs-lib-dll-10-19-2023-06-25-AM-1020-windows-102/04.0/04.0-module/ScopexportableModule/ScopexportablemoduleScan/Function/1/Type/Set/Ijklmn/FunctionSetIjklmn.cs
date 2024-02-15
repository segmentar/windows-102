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
        public partial class XSingle
        {
            public static IList<ScopexportableijklmnScanX_pqrstY> FunctionIjklmnSet(String DirectoryFullName___VALUE)
            {
                ICollection<ScopexportableijklmnScanX_pqrstY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnScanX_pqrstY>();

                var array = Scopexportableio.ScopexportableioFolderSetSurface(DirectoryFullName___VALUE, true);

                foreach (DirectoryInfo directoryInfo in array)
                {
                    ScopexportableijklmnScanX_pqrstY ijklmn;

                    ijklmn = new ScopexportableijklmnScanX_pqrstY();

                    ijklmn.DirectoryInfo = directoryInfo;

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnScanX_pqrstY>(collectionResult);
            }
        }
    }
}
