using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleScan
    {
        public partial class XQuadruple
        {
            public static IList<Scopexportableformscansolid> FunctionIjklmnSet(ScopexportableijklmnScanXop_rstY[] Ijklmn_ARRAY)
            {
                ICollection<Scopexportableformscansolid> collectionResult = default;

                collectionResult = new Collection<Scopexportableformscansolid>();

                foreach (ScopexportableijklmnScanXop_rstY Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    Scopexportableformscansolid scopexportableformscansolid;

                    scopexportableformscansolid = new Scopexportableformscansolid();

                    scopexportableformscansolid.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                    scopexportableformscansolid.FileInfo = Ijklmn_VALUE.FileInfo;

                    scopexportableformscansolid.Text = Ijklmn_VALUE.Text;

                    collectionResult.Add(scopexportableformscansolid);

                    continue;
                }

                return new List<Scopexportableformscansolid>(collectionResult);
            }
        }
    }
}
