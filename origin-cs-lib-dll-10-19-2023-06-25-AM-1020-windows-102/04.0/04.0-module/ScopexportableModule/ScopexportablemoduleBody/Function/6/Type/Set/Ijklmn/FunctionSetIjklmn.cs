using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleBody
    {
        public partial class XSextuple
        {
            public static IList<ScopexportableijklmnBodyXopqrs_Y> FunctionLevelSet(ScopexportableijklmnBodyXopqr_tY[] Ijklmn_ARRAY, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADERSOLID)
            {
                ICollection<ScopexportableijklmnBodyXopqrs_Y> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnBodyXopqrs_Y>();

                foreach (ScopexportableijklmnBodyXopqr_tY Ijklmn_VALUE in Ijklmn_ARRAY)
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

                        ScopexportableijklmnBodyXopqrs_Y ijklmn;

                        ijklmn = new ScopexportableijklmnBodyXopqrs_Y();

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

                        ijklmn.BindArray = Scopexportablestringarraysafe.ForgeDefault(array);

                        collectionResult.Add(ijklmn);

                        continue;
                    }

                    continue;
                }

                return new List<ScopexportableijklmnBodyXopqrs_Y>(collectionResult);
            }
        }
    }
}
