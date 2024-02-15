using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XOctuple
        {
            public static IList<ScopexportableijklmnHeaderUo_qrstV> FunctionIjklmnSet(ScopexportableijklmnHeaderU_pqrstV[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnHeaderUo_qrstV> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderUo_qrstV>();

                foreach (ScopexportableijklmnHeaderU_pqrstV Level_VALUE in Ijklmn_ARRAY)
                {
                    Char springLeft, springRight;

                    springLeft = '\0';

                    springRight = '\0';

                    foreach (String stringValue in Level_VALUE.HeaderArray.Value)
                    {
                        var trim = stringValue.TrimStart((Char)Scopexportableascii.EntityPeriod);

                        var difference = (stringValue.Length - trim.Length);

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = Object.Equals(difference, Scopexportablestoreheader.EntitySpring) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var first = trim[0];

                        var second = trim[1];

                        springLeft = first;

                        springRight = second;

                        continue;
                    }

                    ScopexportableijklmnHeaderUo_qrstV ijklmn;

                    ijklmn = new ScopexportableijklmnHeaderUo_qrstV();

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

                    ijklmn.SpringLeft = Scopexportablecharactersafe.ForgeDefault(springLeft);

                    ijklmn.SpringRight = Scopexportablecharactersafe.ForgeDefault(springRight);

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnHeaderUo_qrstV>(collectionResult);
            }
        }
    }
}
