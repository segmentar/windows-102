using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XTriple
        {
            public static IList<XTriple> FunctionDefaultSet(ScopexportableijklmnHierarchyXo_qrstY Ijklmn_VALUE, Scopexportableformbodysolid value_SCOPEXPORTABLEFORMBODYSOLID)
            {
                ICollection<XTriple> collectionResult = default;

                collectionResult = new Collection<XTriple>();

                var list = Scopexportablemagic.ScopexportablemagicArrayListDispenser(Ijklmn_VALUE.XDoubleArray);

                do
                {
                    Boolean isEqualCheck, shouldBreakCheck;

                    isEqualCheck = Object.Equals(list.Count, 0) is true;

                    shouldBreakCheck = isEqualCheck is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    XDouble left, right;

                    left = default;

                    right = default;

                    Int32 largestLeft, largestRight;

                    largestLeft = -1;

                    largestRight = -1;

                    foreach (XDouble xdouble in list)
                    {
                        var boolean = true;

                        boolean = boolean && xdouble.Opposite is false;

                        boolean = boolean && (xdouble.Position > largestLeft).Equals(true);

                        Boolean isEqualAnotherCheck, shouldContinueCheck;

                        isEqualAnotherCheck = boolean is true;

                        shouldContinueCheck = isEqualAnotherCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        largestLeft = xdouble.Position;

                        left = xdouble;

                        continue;
                    }

                    foreach (XDouble xdouble in list)
                    {
                        var boolean = true;

                        boolean = boolean && xdouble.Opposite is true;

                        boolean = boolean && (xdouble.Position > largestRight).Equals(true);

                        boolean = boolean && Object.Equals(left.CharacterOpposite.Value, xdouble.Character.Value) is true;

                        boolean = boolean && Object.Equals(xdouble.CharacterOpposite.Value, left.Character.Value) is true;

                        Boolean isEqualAnotherCheck, shouldContinueCheck;

                        isEqualAnotherCheck = boolean is true;

                        shouldContinueCheck = isEqualAnotherCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        largestRight = xdouble.Position;

                        right = xdouble;

                        continue;
                    }

                    list.Remove(left);

                    list.Remove(right);

                    var start = (left.Position + 1);

                    var difference = (right.Position - start);

                    var sub = value_SCOPEXPORTABLEFORMBODYSOLID.Hierarchy.Value.Substring(start, difference);

                    Object objectValue;

                    objectValue = new Object();

                    Boolean[] booleanArray;

                    booleanArray = new Boolean[4];

                    booleanArray[0] = Object.Equals(left.Position, 0);

                    booleanArray[1] = Object.Equals(right.Position, (value_SCOPEXPORTABLEFORMBODYSOLID.Hierarchy.Value.Length - 1));

                    if (booleanArray[0] is false)
                    {
                        booleanArray[2] = Object.Equals(value_SCOPEXPORTABLEFORMBODYSOLID.Hierarchy.Value.ToCharArray()[(left.Position - 1)], (Char)Scopexportableascii.EntityPeriod);
                    }
                    else
                        "false".ToString();

                    if (booleanArray[1] is false)
                    {
                        booleanArray[3] = Object.Equals(value_SCOPEXPORTABLEFORMBODYSOLID.Hierarchy.Value.ToCharArray()[(right.Position + 1)], (Char)Scopexportableascii.EntityPeriod);
                    }
                    else
                        "false".ToString();

                    Scopexportablestringsafe value;
                    
                    value = Scopexportablestringsafe.ForgeDefault(sub);

                    XTriple xtriple;

                    xtriple = new XTriple();

                    xtriple.ObjectValue = objectValue;

                    xtriple.PositionLeft = left.Position;

                    xtriple.PositionRight = right.Position;

                    xtriple.CharacterLeft = left.Character;

                    xtriple.CharacterRight = right.Character;

                    xtriple.StickLeft = booleanArray[2];

                    xtriple.StickRight = booleanArray[3];

                    xtriple.Value = value;
                   
                    collectionResult.Add(xtriple);

                    continue;

                } while (true);

                return new List<XTriple>(collectionResult);
            }
        }
    }
}
