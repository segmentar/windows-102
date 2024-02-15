using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XQuadruple
        {
            public static IList<ScopexportableijklmnBodyXopq_stY> FunctionIjklmnSet(ScopexportableijklmnBodyXop_rstY[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnBodyXopq_stY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnBodyXopq_stY>();

                foreach (ScopexportableijklmnBodyXop_rstY Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    var split = Ijklmn_VALUE.Form.Value.Split(ScopexportableradicalNewLine.NewLineStringArray, StringSplitOptions.None);

                    var value = split[1];

                    var trim = value.Trim();

                    ScopexportableijklmnBodyXopq_stY ijklmn;

                    ijklmn = new ScopexportableijklmnBodyXopq_stY();

                    ijklmn.Object = Ijklmn_VALUE.Object;

                    ijklmn.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                    ijklmn.FileInfo = Ijklmn_VALUE.FileInfo;

                    ijklmn.Text = Ijklmn_VALUE.Text;

                    ijklmn.Start = Ijklmn_VALUE.Start;

                    ijklmn.End = Ijklmn_VALUE.End;

                    ijklmn.Mid = Ijklmn_VALUE.Mid;

                    ijklmn.Form = Ijklmn_VALUE.Form;

                    ijklmn.Hierarchy = Scopexportablestringsafe.ForgeDefault(trim);

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnBodyXopq_stY>(collectionResult);
            }
        }
    }
}
