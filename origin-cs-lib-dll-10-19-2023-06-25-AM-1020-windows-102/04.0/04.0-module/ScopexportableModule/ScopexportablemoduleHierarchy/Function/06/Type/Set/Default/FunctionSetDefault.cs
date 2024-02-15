using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XSextuple
        {
            public static IList<XSextuple> FunctionDefaultSet(ScopexportableijklmnHierarchyXopqr_tY Ijklmn_VALUE, Scopexportableformheadersolid value_SCOPEXPORTABLEFORMHEADERSOLID)
            {
                ICollection<XSextuple> collectionResult = default;

                collectionResult = new Collection<XSextuple>();

                foreach (XQuintuple xquintupleItem in Ijklmn_VALUE.XQuintupleArray)
                {
                    Scopexportableformseasonwrap scopexportableformseasonwrap;

                    scopexportableformseasonwrap = new Scopexportableformseasonwrap();

                    Boolean[] booleanArray;

                    booleanArray = new Boolean[4];

                    booleanArray[0] = true;

                    booleanArray[0] = booleanArray[0] && Object.Equals(value_SCOPEXPORTABLEFORMHEADERSOLID.SummerLeft.Value, xquintupleItem.CharacterLeft.Value) is true;

                    booleanArray[0] = booleanArray[0] && Object.Equals(value_SCOPEXPORTABLEFORMHEADERSOLID.SummerRight.Value, xquintupleItem.CharacterRight.Value) is true;

                    booleanArray[1] = true;

                    booleanArray[1] = booleanArray[1] && Object.Equals(value_SCOPEXPORTABLEFORMHEADERSOLID.AutumnLeft.Value, xquintupleItem.CharacterLeft.Value) is true;

                    booleanArray[1] = booleanArray[1] && Object.Equals(value_SCOPEXPORTABLEFORMHEADERSOLID.AutumnRight.Value, xquintupleItem.CharacterRight.Value) is true;

                    booleanArray[2] = true;

                    booleanArray[2] = booleanArray[2] && Object.Equals(value_SCOPEXPORTABLEFORMHEADERSOLID.SpringLeft.Value, xquintupleItem.CharacterLeft.Value) is true;

                    booleanArray[2] = booleanArray[2] && Object.Equals(value_SCOPEXPORTABLEFORMHEADERSOLID.SpringRight.Value, xquintupleItem.CharacterRight.Value) is true;

                    booleanArray[3] = true;

                    booleanArray[3] = booleanArray[3] && Object.Equals(value_SCOPEXPORTABLEFORMHEADERSOLID.WinterLeft.Value, xquintupleItem.CharacterLeft.Value) is true;

                    booleanArray[3] = booleanArray[3] && Object.Equals(value_SCOPEXPORTABLEFORMHEADERSOLID.WinterRight.Value, xquintupleItem.CharacterRight.Value) is true;

                    if (booleanArray[0] is true)
                    {
                        scopexportableformseasonwrap.SummerIs = true;
                    }
                    else
                        "false".ToString();

                    if (booleanArray[1] is true)
                    {
                        scopexportableformseasonwrap.AutumnIs = true;
                    }
                    else
                        "false".ToString();

                    if (booleanArray[2] is true)
                    {
                        scopexportableformseasonwrap.SpringIs = true;
                    }
                    else
                        "false".ToString();

                    if (booleanArray[3] is true)
                    {
                        scopexportableformseasonwrap.WinterIs = true;
                    }
                    else
                        "false".ToString();

                    var array = xquintupleItem.ObjectArray;

                    Boolean isEqualCheck;

                    isEqualCheck = Object.Equals(array.Length, 1);

                    if (isEqualCheck is true)
                    {
                        foreach (XQuintuple xquintupleEntry in Ijklmn_VALUE.XQuintupleArray)
                        {
                            Boolean isReferenceCheck, shouldContinueCheck;

                            isReferenceCheck = Object.ReferenceEquals(xquintupleEntry.ObjectValue, array[0]) is true;

                            shouldContinueCheck = isReferenceCheck is false;

                            if (shouldContinueCheck is true)
                            {
                                continue;
                            }
                            else
                                "false".ToString();

                            Boolean[] booleanParentArray;

                            booleanParentArray = new Boolean[4];

                            booleanParentArray[0] = true;

                            booleanParentArray[0] = booleanParentArray[0] && Object.Equals(value_SCOPEXPORTABLEFORMHEADERSOLID.SummerLeft.Value, xquintupleEntry.CharacterLeft.Value) is true;

                            booleanParentArray[0] = booleanParentArray[0] && Object.Equals(value_SCOPEXPORTABLEFORMHEADERSOLID.SummerRight.Value, xquintupleEntry.CharacterRight.Value) is true;

                            booleanParentArray[1] = true;

                            booleanParentArray[1] = booleanParentArray[1] && Object.Equals(value_SCOPEXPORTABLEFORMHEADERSOLID.AutumnLeft.Value, xquintupleEntry.CharacterLeft.Value) is true;

                            booleanParentArray[1] = booleanParentArray[1] && Object.Equals(value_SCOPEXPORTABLEFORMHEADERSOLID.AutumnRight.Value, xquintupleEntry.CharacterRight.Value) is true;

                            booleanParentArray[2] = true;

                            booleanParentArray[2] = booleanParentArray[2] && Object.Equals(value_SCOPEXPORTABLEFORMHEADERSOLID.SpringLeft.Value, xquintupleEntry.CharacterLeft.Value) is true;

                            booleanParentArray[2] = booleanParentArray[2] && Object.Equals(value_SCOPEXPORTABLEFORMHEADERSOLID.SpringRight.Value, xquintupleEntry.CharacterRight.Value) is true;

                            booleanParentArray[3] = true;

                            booleanParentArray[3] = booleanParentArray[3] && Object.Equals(value_SCOPEXPORTABLEFORMHEADERSOLID.WinterLeft.Value, xquintupleEntry.CharacterLeft.Value) is true;

                            booleanParentArray[3] = booleanParentArray[3] && Object.Equals(value_SCOPEXPORTABLEFORMHEADERSOLID.WinterRight.Value, xquintupleEntry.CharacterRight.Value) is true;

                            if (booleanParentArray[0] is true)
                            {
                                scopexportableformseasonwrap.SummerHas = true;
                            }
                            else
                                "false".ToString();

                            if (booleanParentArray[1] is true)
                            {
                                scopexportableformseasonwrap.AutumnHas = true;
                            }
                            else
                                "false".ToString();

                            if (booleanParentArray[2] is true)
                            {
                                scopexportableformseasonwrap.SpringHas = true;
                            }
                            else
                                "false".ToString();

                            if (booleanParentArray[3] is true)
                            {
                                scopexportableformseasonwrap.WinterHas = true;
                            }
                            else
                                "false".ToString();

                            break;
                        }
                    }
                    else
                        "false".ToString();

                    XSextuple xsextuple;

                    xsextuple = new XSextuple();

                    xsextuple.ObjectValue = xquintupleItem.ObjectValue;

                    xsextuple.PositionLeft = xquintupleItem.PositionLeft;

                    xsextuple.PositionRight = xquintupleItem.PositionRight;

                    xsextuple.CharacterLeft = xquintupleItem.CharacterLeft;

                    xsextuple.CharacterRight = xquintupleItem.CharacterRight;

                    xsextuple.StickLeft = xquintupleItem.StickLeft;

                    xsextuple.StickRight = xquintupleItem.StickRight;

                    xsextuple.Value = xquintupleItem.Value;

                    xsextuple.ObjectArray = xquintupleItem.ObjectArray;

                    xsextuple.ObjectValueParent = xquintupleItem.ObjectValueParent;

                    xsextuple.Scopexportableformseasonwrap = scopexportableformseasonwrap;

                    collectionResult.Add(xsextuple);

                    continue;
                }

                return new List<XSextuple>(collectionResult);
            }
        }
    }
}
