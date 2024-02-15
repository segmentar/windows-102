using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XSeptuple
        {
            public static IList<ScopexportableijklmnBodyU_pqrstV> FunctionIjklmnSet(ScopexportableijklmnBodyXopqrs_Y[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnBodyU_pqrstV> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnBodyU_pqrstV>();

                foreach (ScopexportableijklmnBodyXopqrs_Y Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    var start = Ijklmn_VALUE.Mid + ScopexportableradicalBody.BodyIntegerArray.Length;

                    var difference = (Ijklmn_VALUE.End - start);

                    var sub = Ijklmn_VALUE.Text.Value.Substring(start, difference);

                    var trim = sub.Trim(ScopexportableradicalNormal.NormalCharacterArray);

                    ScopexportableijklmnBodyU_pqrstV ijklmn;

                    ijklmn = new ScopexportableijklmnBodyU_pqrstV();

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

                    ijklmn.Body = Scopexportablestringsafe.ForgeDefault(trim);

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnBodyU_pqrstV>(collectionResult);
            }
        }
    }
}
