using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XTriple
        {
            public static IList<ScopexportableijklmnBodyXop_rstY> FunctionIjklmnSet(ScopexportableijklmnBodyXo_qrstY[] Ijklmn_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADERSOLID)
            {
                ICollection<ScopexportableijklmnBodyXop_rstY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnBodyXop_rstY>();

                foreach (ScopexportableijklmnBodyXo_qrstY Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    foreach (Scopexportableformheadersolid value_SCOPEXPORTABLEHEADERSOLID in array_SCOPEXPORTABLEFORMHEADERSOLID)
                    {
                        Boolean isReferenceCheck, shouldContinueCheck;

                        isReferenceCheck = Object.ReferenceEquals(value_SCOPEXPORTABLEHEADERSOLID.Object, Ijklmn_VALUE.Object) is true;

                        shouldContinueCheck = isReferenceCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var difference = (Ijklmn_VALUE.Mid - value_SCOPEXPORTABLEHEADERSOLID.Mid);

                        var sub = Ijklmn_VALUE.Text.Value.Substring(value_SCOPEXPORTABLEHEADERSOLID.Mid, difference);

                        var trim = sub.Trim(ScopexportableradicalNormal.NormalCharacterArray);

                        ScopexportableijklmnBodyXop_rstY ijklmn;

                        ijklmn = new ScopexportableijklmnBodyXop_rstY();

                        ijklmn.Object = Ijklmn_VALUE.Object;

                        ijklmn.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                        ijklmn.FileInfo = Ijklmn_VALUE.FileInfo;

                        ijklmn.Text = Ijklmn_VALUE.Text;

                        ijklmn.Start = Ijklmn_VALUE.Start;

                        ijklmn.End = Ijklmn_VALUE.End;

                        ijklmn.Mid = Ijklmn_VALUE.Mid;

                        ijklmn.Form = Scopexportablestringsafe.ForgeDefault(trim);

                        collectionResult.Add(ijklmn);

                        continue;
                    }

                    continue;
                }

                return new List<ScopexportableijklmnBodyXop_rstY>(collectionResult);
            }
        }
    }
}
