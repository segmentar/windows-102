using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XDouble
        {
            public static IList<ScopexportableijklmnBodyXo_qrstY> FunctionIjklmnSet(ScopexportableijklmnBodyX_pqrstY[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnBodyXo_qrstY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnBodyXo_qrstY>();

                foreach (ScopexportableijklmnBodyX_pqrstY Ijklmn_LEVEL in Ijklmn_ARRAY)
                {
                    var position = Ijklmn_LEVEL.Text.Value.IndexOf(ScopexportableradicalBody.BodyCharacterConcatenate, Ijklmn_LEVEL.Start);

                    ScopexportableijklmnBodyXo_qrstY ijklmn;

                    ijklmn = new ScopexportableijklmnBodyXo_qrstY();

                    ijklmn.Object = Ijklmn_LEVEL.Object;

                    ijklmn.DirectoryInfo = Ijklmn_LEVEL.DirectoryInfo;

                    ijklmn.FileInfo = Ijklmn_LEVEL.FileInfo;

                    ijklmn.Text = Ijklmn_LEVEL.Text;

                    ijklmn.Start = Ijklmn_LEVEL.Start;

                    ijklmn.End = Ijklmn_LEVEL.End;

                    ijklmn.Mid = position;

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnBodyXo_qrstY>(collectionResult);
            }
        }
    }
}
