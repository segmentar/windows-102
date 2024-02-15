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
        public partial class XTriple
        {
            public static IList<ScopexportableijklmnScanXop_rstY> FunctionIjklmnSet(ScopexportableijklmnScanXo_qrstY[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnScanXop_rstY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnScanXop_rstY>();

                foreach (ScopexportableijklmnScanXo_qrstY Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    var value = File.ReadAllText(Ijklmn_VALUE.FileInfo.FullName);

                    var result = Scopexportablestringsafe.ForgeDefault(value);

                    ScopexportableijklmnScanXop_rstY ijklmn;

                    ijklmn = new ScopexportableijklmnScanXop_rstY();

                    ijklmn.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                    ijklmn.FileInfo = Ijklmn_VALUE.FileInfo;

                    ijklmn.Text = result;

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnScanXop_rstY>(collectionResult);
            }
        }
    }
}
