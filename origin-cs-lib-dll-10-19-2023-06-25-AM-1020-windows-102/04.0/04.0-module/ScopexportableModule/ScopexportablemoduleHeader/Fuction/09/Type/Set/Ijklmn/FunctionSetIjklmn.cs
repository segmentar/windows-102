using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XNonuple
        {
            public static IList<ScopexportableijklmnHeaderUop_rstV> FunctionIjklmnSet(ScopexportableijklmnHeaderUo_qrstV[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnHeaderUop_rstV> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderUop_rstV>();

                foreach (ScopexportableijklmnHeaderUo_qrstV Level_VALUE in Ijklmn_ARRAY)
                {
                    Char winterLeft, winterRight;

                    winterLeft = '\0';

                    winterRight = '\0';

                    foreach (String stringValue in Level_VALUE.HeaderArray.Value)
                    {
                        var trim = stringValue.TrimStart((Char)Scopexportableascii.EntityPeriod);

                        var difference = (stringValue.Length - trim.Length);

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = Object.Equals(difference, Scopexportablestoreheader.EntityWinter) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var first = trim[0];

                        var second = trim[1];

                        winterLeft = first;

                        winterRight = second;

                        continue;
                    }

                    ScopexportableijklmnHeaderUop_rstV ijklmn;

                    ijklmn = new ScopexportableijklmnHeaderUop_rstV();

                    ijklmn.Object = Level_VALUE.Object;

                    ijklmn.DirectoryInfo = Level_VALUE.DirectoryInfo;

                    ijklmn.FileInfo = Level_VALUE.FileInfo;

                    ijklmn.Text = Level_VALUE.Text;

                    ijklmn.Start = Level_VALUE.Start;

                    ijklmn.End = Level_VALUE.End;

                    ijklmn.Mid = Level_VALUE.Mid;

                    ijklmn.Header = Level_VALUE.Header;

                    ijklmn.HeaderArray = Level_VALUE.HeaderArray;

                    ijklmn.Name = Level_VALUE.Name;

                    ijklmn.SummerLeft = Level_VALUE.SummerLeft;

                    ijklmn.SummerRight = Level_VALUE.SummerRight;

                    ijklmn.AutumnLeft = Level_VALUE.AutumnLeft;

                    ijklmn.AutumnRight = Level_VALUE.AutumnRight;

                    ijklmn.SpringLeft = Level_VALUE.SpringLeft;

                    ijklmn.SpringRight = Level_VALUE.SpringRight;

                    ijklmn.WinterLeft = Scopexportablecharactersafe.ForgeDefault(winterLeft);

                    ijklmn.WinterRight = Scopexportablecharactersafe.ForgeDefault(winterRight);

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnHeaderUop_rstV>(collectionResult);
            }
        }
    }
}
