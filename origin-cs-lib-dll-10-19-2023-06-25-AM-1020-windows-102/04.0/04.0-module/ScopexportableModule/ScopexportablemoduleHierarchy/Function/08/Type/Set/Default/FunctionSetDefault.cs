﻿using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XOctuple
        {
            public static IList<XOctuple> FunctionDefaultSet(ScopexportableijklmnHierarchyU_pqrstV Ijklmn_VALUE, Scopexportableformheadersolid value_SCOPEXPORTABLEFORMHEADERSOLID, Scopexportableformbodysolid value_SCOPEXPORTABLEFORMBODYSOLID)
            {
                ICollection<XOctuple> collectionResult = default;

                collectionResult = new Collection<XOctuple>();

                foreach (XSeptuple xseptuple in Ijklmn_VALUE.XSeptupleArray)
                {
                    var value = xseptuple.Value;

                    foreach (Char character in value_SCOPEXPORTABLEFORMHEADERSOLID.Escape.Value)
                    {
                        foreach (String stringItem in value_SCOPEXPORTABLEFORMBODYSOLID.PortalArray.Value)
                        {
                            foreach (String stringEntry in value_SCOPEXPORTABLEFORMBODYSOLID.BindArray.Value)
                            {
                                String[] trimArray;

                                trimArray = new String[2];

                                trimArray[0] = stringItem.TrimStart(character);

                                trimArray[1] = stringEntry.TrimStart(character);

                                Int32[] differenceArray;

                                differenceArray = new Int32[2];

                                differenceArray[0] = (stringItem.Length - trimArray[0].Length);

                                differenceArray[1] = (stringEntry.Length - trimArray[1].Length);

                                var boolean = true;

                                boolean = boolean && Object.Equals(differenceArray[0], 1) is true;

                                boolean = boolean && Object.Equals(differenceArray[1], 2) is true;

                                boolean = boolean && Object.Equals(trimArray[1], xseptuple.Value.Value) is true;

                                Boolean isEqualCheck, shouldContinueCheck;

                                isEqualCheck = boolean is true;

                                shouldContinueCheck = isEqualCheck is false;

                                if (shouldContinueCheck is true)
                                {
                                    continue;
                                }
                                else
                                    "false".ToString();

                                value = Scopexportablestringsafe.ForgeDefault(trimArray[0]);

                                break;
                            }

                            continue;
                        }

                        continue;
                    }

                    XOctuple xoctuple;

                    xoctuple = new XOctuple();

                    xoctuple.ObjectValue = xseptuple.ObjectValue;

                    xoctuple.PositionLeft = xseptuple.PositionLeft;

                    xoctuple.PositionRight = xseptuple.PositionRight;

                    xoctuple.CharacterLeft = xseptuple.CharacterLeft;

                    xoctuple.CharacterRight = xseptuple.CharacterRight;

                    xoctuple.StickLeft = xseptuple.StickLeft;

                    xoctuple.StickRight = xseptuple.StickRight;

                    xoctuple.Value = xseptuple.Value;

                    xoctuple.ObjectArray = xseptuple.ObjectArray;

                    xoctuple.ObjectValueParent = xseptuple.ObjectValueParent;

                    xoctuple.Scopexportableformseasonwrap = xseptuple.Scopexportableformseasonwrap;

                    xoctuple.Scopexportableformseasonunwrap = xseptuple.Scopexportableformseasonunwrap;

                    xoctuple.Real = value;

                    collectionResult.Add(xoctuple);

                    continue;
                }

                return new List<XOctuple>(collectionResult);
            }
        }
    }
}
