using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XDuodecuple
        {
            public static IList<Scopexportableformheadersolid> FunctionDefaultSet(ScopexportableijklmnHeaderUopqr_tV[] Ijklmn_ARRAY)
            {
                ICollection<Scopexportableformheadersolid> collectionResult = default;

                collectionResult = new Collection<Scopexportableformheadersolid>();

                foreach (ScopexportableijklmnHeaderUopqr_tV Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    Scopexportableformheadersolid scopexportableformheadersolid;

                    scopexportableformheadersolid = new Scopexportableformheadersolid();

                    scopexportableformheadersolid.Object = Ijklmn_VALUE.Object;

                    scopexportableformheadersolid.Mid = Ijklmn_VALUE.Mid;

                    scopexportableformheadersolid.Header = Ijklmn_VALUE.Header;

                    scopexportableformheadersolid.HeaderArray = Ijklmn_VALUE.HeaderArray;

                    scopexportableformheadersolid.Name = Ijklmn_VALUE.Name;

                    scopexportableformheadersolid.SummerLeft = Ijklmn_VALUE.SummerLeft;

                    scopexportableformheadersolid.SummerRight = Ijklmn_VALUE.SummerRight;

                    scopexportableformheadersolid.AutumnLeft = Ijklmn_VALUE.AutumnLeft;

                    scopexportableformheadersolid.AutumnRight = Ijklmn_VALUE.AutumnRight;

                    scopexportableformheadersolid.SpringLeft = Ijklmn_VALUE.SpringLeft;

                    scopexportableformheadersolid.SpringRight = Ijklmn_VALUE.SpringRight;

                    scopexportableformheadersolid.WinterLeft = Ijklmn_VALUE.WinterLeft;

                    scopexportableformheadersolid.WinterRight = Ijklmn_VALUE.WinterRight;

                    scopexportableformheadersolid.Escape = Ijklmn_VALUE.Escape;

                    scopexportableformheadersolid.Extension = Ijklmn_VALUE.Extension;

                    collectionResult.Add(scopexportableformheadersolid);

                    continue;
                }

                return new List<Scopexportableformheadersolid>(collectionResult);
            }
        }
    }
}
