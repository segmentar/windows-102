using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XQuintuple
        {
            public static IList<ScopexportableijklmnHeaderXopqr_tY> FunctionIjklmnSet(ScopexportableijklmnHeaderXopq_stY[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnHeaderXopqr_tY> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderXopqr_tY>();
                
                foreach (ScopexportableijklmnHeaderXopq_stY Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    String name;

                    name = String.Empty;

                    foreach (String stringValue in Ijklmn_VALUE.HeaderArray.Value)
                    {
                        var trim = stringValue.TrimStart((Char)Scopexportableascii.EntityPeriod);

                        var difference = (stringValue.Length - trim.Length);

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = Object.Equals(difference, Scopexportablestoreheader.EntityName) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        name = trim;

                        continue;
                    }

                    ScopexportableijklmnHeaderXopqr_tY ijklmn;

                    ijklmn = new ScopexportableijklmnHeaderXopqr_tY();

                    ijklmn.Object = Ijklmn_VALUE.Object;

                    ijklmn.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                    ijklmn.FileInfo = Ijklmn_VALUE.FileInfo;

                    ijklmn.Text = Ijklmn_VALUE.Text;

                    ijklmn.Start = Ijklmn_VALUE.Start;

                    ijklmn.End = Ijklmn_VALUE.End;

                    ijklmn.Mid = Ijklmn_VALUE.Mid;

                    ijklmn.Header = Ijklmn_VALUE.Header;

                    ijklmn.HeaderArray = Ijklmn_VALUE.HeaderArray;

                    ijklmn.Name = Scopexportablestringsafe.ForgeDefault(name);

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnHeaderXopqr_tY>(collectionResult);
            }
        }
    }
}
