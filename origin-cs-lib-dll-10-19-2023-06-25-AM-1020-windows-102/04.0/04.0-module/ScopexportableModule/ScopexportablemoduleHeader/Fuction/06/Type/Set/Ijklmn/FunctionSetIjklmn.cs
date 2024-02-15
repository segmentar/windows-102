using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XSextuple
        {
            public static IList<ScopexportableijklmnHeaderXopqrs_Y> FunctionIjklmnSet(ScopexportableijklmnHeaderXopqr_tY[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnHeaderXopqrs_Y> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderXopqrs_Y>();
                
                foreach (ScopexportableijklmnHeaderXopqr_tY Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    Char summerLeft, summerRight;

                    summerLeft = '\0';

                    summerRight = '\0';

                    foreach (String stringValue in Ijklmn_VALUE.HeaderArray.Value)
                    {
                        var trim = stringValue.TrimStart((Char)Scopexportableascii.EntityPeriod);

                        var difference = (stringValue.Length - trim.Length);

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = Object.Equals(difference, Scopexportablestoreheader.EntitySummer) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var first = trim[0];

                        var second = trim[1];

                        summerLeft = first;

                        summerRight = second;

                        continue;
                    }

                    ScopexportableijklmnHeaderXopqrs_Y ijklmn;

                    ijklmn = new ScopexportableijklmnHeaderXopqrs_Y();

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

                    ijklmn.SummerLeft = Scopexportablecharactersafe.ForgeDefault(summerLeft);

                    ijklmn.SummerRight = Scopexportablecharactersafe.ForgeDefault(summerRight);

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnHeaderXopqrs_Y>(collectionResult);
            }
        }
    }
}
