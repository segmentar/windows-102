using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XSeptuple
        {
            public static IList<ScopexportableijklmnHeaderU_pqrstV> FunctionIjklmnSet(ScopexportableijklmnHeaderXopqrs_Y[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnHeaderU_pqrstV> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderU_pqrstV>();

                foreach (ScopexportableijklmnHeaderXopqrs_Y Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    Char autumnLeft, autumnRight;

                    autumnLeft = '\0';

                    autumnRight = '\0';

                    foreach (String stringValue in Ijklmn_VALUE.HeaderArray.Value)
                    {
                        var trim = stringValue.TrimStart((Char)Scopexportableascii.EntityPeriod);

                        var difference = (stringValue.Length - trim.Length);

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = Object.Equals(difference, Scopexportablestoreheader.EntityAutumn) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var first = trim[0];

                        var second = trim[1];

                        autumnLeft = first;

                        autumnRight = second;

                        continue;
                    }

                    ScopexportableijklmnHeaderU_pqrstV ijklmn;

                    ijklmn = new ScopexportableijklmnHeaderU_pqrstV();

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

                    ijklmn.AutumnLeft = Scopexportablecharactersafe.ForgeDefault(autumnLeft);

                    ijklmn.AutumnRight = Scopexportablecharactersafe.ForgeDefault(autumnRight);

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnHeaderU_pqrstV>(collectionResult);
            }
        }
    }
}
