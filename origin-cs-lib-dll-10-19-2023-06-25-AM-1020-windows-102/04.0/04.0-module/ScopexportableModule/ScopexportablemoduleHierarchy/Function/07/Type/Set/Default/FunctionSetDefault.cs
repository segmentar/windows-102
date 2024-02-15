using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XSeptuple
        {
            public static IList<XSeptuple> FunctionDefaultSet(ScopexportableijklmnHierarchyXopqrs_Y Ijklmn_VALUE)
            {
                ICollection<XSeptuple> collectionResult = default;

                collectionResult = new Collection<XSeptuple>();

                foreach (XSextuple xsextuple in Ijklmn_VALUE.XSextupleArray)
                {
                    Scopexportableformseasonunwrap scopexportableformseasonunwrap;

                    scopexportableformseasonunwrap = new Scopexportableformseasonunwrap();

                    Boolean[] booleanArray;

                    booleanArray = new Boolean[8];

                    booleanArray[0] = true;

                    booleanArray[0] = booleanArray[0] && xsextuple.Scopexportableformseasonwrap.SummerIs is true;

                    booleanArray[1] = true;

                    booleanArray[1] = booleanArray[1] && xsextuple.Scopexportableformseasonwrap.AutumnIs is true;

                    booleanArray[2] = true;

                    booleanArray[2] = booleanArray[2] && xsextuple.Scopexportableformseasonwrap.SummerIs is true;

                    booleanArray[2] = booleanArray[2] && xsextuple.Scopexportableformseasonwrap.AutumnHas is true;

                    booleanArray[3] = true;

                    booleanArray[3] = booleanArray[3] && xsextuple.Scopexportableformseasonwrap.AutumnIs is true;

                    booleanArray[3] = booleanArray[3] && xsextuple.Scopexportableformseasonwrap.SummerHas is true;

                    booleanArray[4] = true;

                    booleanArray[4] = booleanArray[4] && xsextuple.Scopexportableformseasonwrap.SpringIs is true;

                    booleanArray[4] = booleanArray[4] && xsextuple.Scopexportableformseasonwrap.SpringHas is false;

                    booleanArray[5] = true;

                    booleanArray[5] = booleanArray[5] && xsextuple.Scopexportableformseasonwrap.SpringIs is true;

                    booleanArray[5] = booleanArray[5] && xsextuple.Scopexportableformseasonwrap.SpringHas is true;

                    booleanArray[6] = true;

                    booleanArray[7] = true;

                    if (booleanArray[0] is true)
                    {
                        scopexportableformseasonunwrap.RequireShould = true;
                    }
                    else
                        "false".ToString();

                    if (booleanArray[1] is true)
                    {
                        scopexportableformseasonunwrap.OptionShould = true;
                    }
                    else
                        "false".ToString();

                    if (booleanArray[2] is true)
                    {
                        scopexportableformseasonunwrap.AnyShould = true;
                    }
                    else
                        "false".ToString();

                    if (booleanArray[3] is true)
                    {
                        scopexportableformseasonunwrap.SomeShould = true;
                    }
                    else
                        "false".ToString();

                    if (booleanArray[4] is true)
                    {
                        scopexportableformseasonunwrap.SegmentShould = true;
                    }
                    else
                        "false".ToString();

                    if (booleanArray[5] is true)
                    {
                        scopexportableformseasonunwrap.SequenceShould = true;
                    }
                    else
                        "false".ToString();

                    if (booleanArray[6] is true)
                    {
                        scopexportableformseasonunwrap.SentenceShould = true;
                    }
                    else
                        "false".ToString();

                    if (booleanArray[7] is true)
                    {
                        scopexportableformseasonunwrap.ParagraphShould = true;
                    }
                    else
                        "false".ToString();

                    XSeptuple xseptuple;

                    xseptuple = new XSeptuple();

                    xseptuple.ObjectValue = xsextuple.ObjectValue;

                    xseptuple.PositionLeft = xsextuple.PositionLeft;

                    xseptuple.PositionRight = xsextuple.PositionRight;

                    xseptuple.CharacterLeft = xsextuple.CharacterLeft;

                    xseptuple.CharacterRight = xsextuple.CharacterRight;

                    xseptuple.StickLeft = xsextuple.StickLeft;

                    xseptuple.StickRight = xsextuple.StickRight;

                    xseptuple.Value = xsextuple.Value;

                    xseptuple.ObjectArray = xsextuple.ObjectArray;

                    xseptuple.ObjectValueParent = xsextuple.ObjectValueParent;

                    xseptuple.Scopexportableformseasonwrap = xsextuple.Scopexportableformseasonwrap;

                    xseptuple.Scopexportableformseasonunwrap = scopexportableformseasonunwrap;

                    collectionResult.Add(xseptuple);

                    continue;
                }

                return new List<XSeptuple>(collectionResult);
            }
        }
    }
}
