using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XDecuple
        {
            public static IList<ScopexportableijklmnHeaderUopq_stV> FunctionIjklmnSet(ScopexportableijklmnHeaderUop_rstV[] Ijklmn_ARRAY)
            {
                ICollection<ScopexportableijklmnHeaderUopq_stV> collectionResult = default;

                collectionResult = new Collection<ScopexportableijklmnHeaderUopq_stV>();

                foreach (ScopexportableijklmnHeaderUop_rstV Ijklmn_VALUE in Ijklmn_ARRAY)
                {
                    Char[] characterArray;

                    characterArray = new Char[0];

                    foreach (String stringValue in Ijklmn_VALUE.HeaderArray.Value)
                    {
                        var trim = stringValue.TrimStart((Char)Scopexportableascii.EntityPeriod);

                        var difference = (stringValue.Length - trim.Length);

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = Object.Equals(difference, Scopexportablestoreheader.EntityEscape) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var item = characterArray.Length;

                        var entry = trim.Length;

                        var zee = item + trim.Length;

                        Array.Resize<Char>(ref characterArray, zee);

                        trim.CopyTo(0, characterArray, item, entry);

                        continue;
                    }

                    ScopexportableijklmnHeaderUopq_stV ijklmn;

                    ijklmn = new ScopexportableijklmnHeaderUopq_stV();

                    ijklmn.Object = Ijklmn_VALUE.Object;

                    ijklmn.DirectoryInfo = Ijklmn_VALUE.DirectoryInfo;

                    ijklmn.FileInfo = Ijklmn_VALUE.FileInfo;

                    ijklmn.Text = Ijklmn_VALUE.Text;

                    ijklmn.Start = Ijklmn_VALUE.Start;

                    ijklmn.End = Ijklmn_VALUE.End;

                    ijklmn.Header = Ijklmn_VALUE.Header;

                    ijklmn.Mid = Ijklmn_VALUE.Mid;

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

                    ijklmn.Escape = Scopexportablecharacterarraysafe.ForgeDefault(characterArray);

                    collectionResult.Add(ijklmn);

                    continue;
                }

                return new List<ScopexportableijklmnHeaderUopq_stV>(collectionResult);
            }
        }
    }
}
