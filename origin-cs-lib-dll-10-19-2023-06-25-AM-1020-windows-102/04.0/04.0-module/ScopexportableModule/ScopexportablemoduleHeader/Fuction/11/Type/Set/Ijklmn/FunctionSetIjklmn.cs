using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XUndecuple
        {
            public static IList<ScopexportableijklmnHeaderUopqr_tV> FunctionIjklmnSet(ScopexportableijklmnHeaderUopq_stV[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnHeaderUopqr_tV> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderUopqr_tV>();

                foreach (ScopexportableijklmnHeaderUopq_stV Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    var aoth = Ijklmn_VALUE.HeaderArray.Value.Length;

                    var roth = (aoth - 1);

                    var value = Ijklmn_VALUE.HeaderArray.Value[roth];

                    ScopexportableijklmnHeaderUopqr_tV ijklmn;

                    ijklmn = new ScopexportableijklmnHeaderUopqr_tV();

                    ijklmn.Object = Ijklmn_VALUE.Object;

                    ijklmn.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                    ijklmn.FileInfo = Ijklmn_VALUE.FileInfo;

                    ijklmn.Text = Ijklmn_VALUE.Text;

                    ijklmn.Start = Ijklmn_VALUE.Start;

                    ijklmn.End = Ijklmn_VALUE.End;

                    ijklmn.Mid = Ijklmn_VALUE.Mid;

                    ijklmn.Header = Ijklmn_VALUE.Header;

                    ijklmn.HeaderArray = Ijklmn_VALUE.HeaderArray;

                    ijklmn.Name = Ijklmn_VALUE.Name;

                    ijklmn.SummerLeft = Ijklmn_VALUE.SummerLeft;

                    ijklmn.SummerRight = Ijklmn_VALUE.SummerRight;

                    ijklmn.AutumnLeft = Ijklmn_VALUE.AutumnLeft;

                    ijklmn.AutumnRight = Ijklmn_VALUE.AutumnRight;

                    ijklmn.SpringLeft = Ijklmn_VALUE.SpringLeft;

                    ijklmn.SpringRight = Ijklmn_VALUE.SpringRight;

                    ijklmn.WinterLeft = Ijklmn_VALUE.WinterLeft;

                    ijklmn.WinterRight = Ijklmn_VALUE.WinterRight;

                    ijklmn.Escape = Ijklmn_VALUE.Escape;

                    ijklmn.Extension = Scopexportablestringsafe.ForgeDefault(value);

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnHeaderUopqr_tV>(collectionResult);
            }
        }
    }
}
