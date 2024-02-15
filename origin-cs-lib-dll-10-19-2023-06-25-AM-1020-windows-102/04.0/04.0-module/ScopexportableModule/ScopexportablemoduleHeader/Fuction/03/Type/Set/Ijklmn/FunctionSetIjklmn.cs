using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XTriple
        {
            public static IList<ScopexportableijklmnHeaderXop_rstY> FunctionIjklmnSet(ScopexportableijklmnHeaderXo_qrstY[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnHeaderXop_rstY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderXop_rstY>();

                foreach (ScopexportableijklmnHeaderXo_qrstY Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    Boolean isEqualContagentCheck;

                    isEqualContagentCheck = Object.Equals(Ijklmn_VALUE.Mid, -1) is true;

                    String stringValue;

                    if (isEqualContagentCheck)
                    {
                        stringValue = String.Empty;
                    }
                    else
                    {
                        var difference = (Ijklmn_VALUE.Mid - Ijklmn_VALUE.Start);

                        var sub = Ijklmn_VALUE.Text.Value.Substring(Ijklmn_VALUE.Start, difference);

                        stringValue = sub;
                    }

                    ScopexportableijklmnHeaderXop_rstY ijklmn;

                    ijklmn = new ScopexportableijklmnHeaderXop_rstY();

                    ijklmn.Object = Ijklmn_VALUE.Object;

                    ijklmn.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                    ijklmn.FileInfo = Ijklmn_VALUE.FileInfo;

                    ijklmn.Text = Ijklmn_VALUE.Text;

                    ijklmn.Start = Ijklmn_VALUE.Start;

                    ijklmn.End = Ijklmn_VALUE.End;

                    ijklmn.Mid = Ijklmn_VALUE.Mid;

                    ijklmn.Header = Scopexportablestringsafe.ForgeDefault(stringValue);

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnHeaderXop_rstY>(collectionResult);
            }
        }
    }
}
