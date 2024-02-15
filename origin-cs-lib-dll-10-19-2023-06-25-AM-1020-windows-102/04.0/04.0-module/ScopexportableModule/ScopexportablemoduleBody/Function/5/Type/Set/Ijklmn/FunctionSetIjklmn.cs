using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XQuintuple
        {
            public static IList<ScopexportableijklmnBodyXopqr_tY> FunctionIjklmnSet(ScopexportableijklmnBodyXopq_stY[] Ijklmn_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADERSOLID)
            {
                ICollection<ScopexportableijklmnBodyXopqr_tY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnBodyXopqr_tY>();

                foreach (ScopexportableijklmnBodyXopq_stY Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    foreach (Scopexportableformheadersolid value_SCOPEXPORTABLEFORMHEADERSOLID in array_SCOPEXPORTABLEFORMHEADERSOLID)
                    {
                        Boolean isReferenceCheck, shouldContinueCheck;

                        isReferenceCheck = Object.ReferenceEquals(value_SCOPEXPORTABLEFORMHEADERSOLID.Object, Ijklmn_VALUE.Object) is true;

                        shouldContinueCheck = isReferenceCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var array = FunctionStringSetSurface(Ijklmn_VALUE, value_SCOPEXPORTABLEFORMHEADERSOLID);

                        ScopexportableijklmnBodyXopqr_tY ijklmn;

                        ijklmn = new ScopexportableijklmnBodyXopqr_tY();

                        ijklmn.Object = Ijklmn_VALUE.Object;

                        ijklmn.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                        ijklmn.FileInfo = Ijklmn_VALUE.FileInfo;

                        ijklmn.Text = Ijklmn_VALUE.Text;

                        ijklmn.Start = Ijklmn_VALUE.Start;

                        ijklmn.End = Ijklmn_VALUE.End;

                        ijklmn.Mid = Ijklmn_VALUE.Mid;

                        ijklmn.Form = Ijklmn_VALUE.Form;

                        ijklmn.Hierarchy = Ijklmn_VALUE.Hierarchy;

                        ijklmn.PortalArray = Scopexportablestringarraysafe.ForgeDefault(array);

                        collectionResult.Add(ijklmn);

                        continue;
                    }

                    continue;
                }

                return new List<ScopexportableijklmnBodyXopqr_tY>(collectionResult);
            }
        }
    }
}
