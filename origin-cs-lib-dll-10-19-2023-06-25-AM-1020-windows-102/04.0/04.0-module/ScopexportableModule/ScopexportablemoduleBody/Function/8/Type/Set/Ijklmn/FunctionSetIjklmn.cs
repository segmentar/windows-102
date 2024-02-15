using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XOctuple
        {
            public static IList<ScopexportableijklmnBodyUo_qrstV> FunctionIjklmnSet(ScopexportableijklmnBodyU_pqrstV[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnBodyUo_qrstV> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnBodyUo_qrstV>();

                foreach (ScopexportableijklmnBodyU_pqrstV Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    var split = Ijklmn_VALUE.Body.Value.Split(ScopexportableradicalNewLine.NewLineStringArray, StringSplitOptions.None);

                    ScopexportableijklmnBodyUo_qrstV ijklmn;

                    ijklmn = new ScopexportableijklmnBodyUo_qrstV();

                    ijklmn.Object = Ijklmn_VALUE.Object;

                    ijklmn.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                    ijklmn.FileInfo = Ijklmn_VALUE.FileInfo;

                    ijklmn.Text = Ijklmn_VALUE.Text;

                    ijklmn.Start = Ijklmn_VALUE.Start;

                    ijklmn.End = Ijklmn_VALUE.End;

                    ijklmn.Mid = Ijklmn_VALUE.Mid;

                    ijklmn.Form = Ijklmn_VALUE.Form;

                    ijklmn.Hierarchy = Ijklmn_VALUE.Hierarchy;

                    ijklmn.PortalArray = Ijklmn_VALUE.PortalArray;

                    ijklmn.BindArray = Ijklmn_VALUE.BindArray;

                    ijklmn.Body = Ijklmn_VALUE.Body;

                    ijklmn.BodyArray = Scopexportablestringarraysafe.ForgeDefault(split);

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnBodyUo_qrstV>(collectionResult);
            }
        }
    }
}
