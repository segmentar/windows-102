using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XQuadruple
        {
            public static IList<ScopexportableijklmnHeaderXopq_stY> FunctionIjklmnSet(ScopexportableijklmnHeaderXop_rstY[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnHeaderXopq_stY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderXopq_stY>();

                foreach (ScopexportableijklmnHeaderXop_rstY Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    var separator = new Char[1];

                    separator[0] = (Char)Scopexportableascii.EntityWhitespace;

                    var split = Ijklmn_VALUE.Header.Value.Split(separator, StringSplitOptions.RemoveEmptyEntries);

                    ScopexportableijklmnHeaderXopq_stY ijklmn;

                    ijklmn = new ScopexportableijklmnHeaderXopq_stY();

                    ijklmn.Object = Ijklmn_VALUE.Object;

                    ijklmn.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                    ijklmn.FileInfo = Ijklmn_VALUE.FileInfo;

                    ijklmn.Text = Ijklmn_VALUE.Text;

                    ijklmn.Start = Ijklmn_VALUE.Start;

                    ijklmn.End = Ijklmn_VALUE.End;

                    ijklmn.Mid = Ijklmn_VALUE.Mid;

                    ijklmn.Header = Ijklmn_VALUE.Header;

                    ijklmn.HeaderArray = Scopexportablestringarraysafe.ForgeDefault(split);

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnHeaderXopq_stY>(collectionResult);
            }
        }
    }
}
