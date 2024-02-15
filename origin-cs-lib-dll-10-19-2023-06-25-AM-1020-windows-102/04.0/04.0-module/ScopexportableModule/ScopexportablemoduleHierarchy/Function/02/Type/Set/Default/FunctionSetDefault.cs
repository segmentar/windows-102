using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XDouble
        {
            public static IList<XDouble> FunctionDefaultSet(ScopexportableijklmnHierarchyX_pqrstY Ijklmn_VALUE, Scopexportableformheadersolid value_SCOPEXPORTABLEFORMHEADERSOLID, Scopexportableformbodysolid value_SCOPEXPORTABLEFORMBODYSOLID)
            {
                ICollection<XDouble> collectionResult = default;

                collectionResult = new Collection<XDouble>();

                var deflect = new IEnumerable[3];

                deflect[0] = new Char[8] {

                    value_SCOPEXPORTABLEFORMHEADERSOLID.SummerLeft.Value,
                    value_SCOPEXPORTABLEFORMHEADERSOLID.AutumnLeft.Value,
                    value_SCOPEXPORTABLEFORMHEADERSOLID.SpringLeft.Value,
                    value_SCOPEXPORTABLEFORMHEADERSOLID.WinterLeft.Value,
                    value_SCOPEXPORTABLEFORMHEADERSOLID.SummerRight.Value,
                    value_SCOPEXPORTABLEFORMHEADERSOLID.AutumnRight.Value,
                    value_SCOPEXPORTABLEFORMHEADERSOLID.SpringRight.Value,
                    value_SCOPEXPORTABLEFORMHEADERSOLID.WinterRight.Value,
                };

                deflect[1] = new Char[4] {

                    value_SCOPEXPORTABLEFORMHEADERSOLID.SummerLeft.Value,
                    value_SCOPEXPORTABLEFORMHEADERSOLID.AutumnLeft.Value,
                    value_SCOPEXPORTABLEFORMHEADERSOLID.SpringLeft.Value,
                    value_SCOPEXPORTABLEFORMHEADERSOLID.WinterLeft.Value
                };

                deflect[2] = new Char[4] {

                    value_SCOPEXPORTABLEFORMHEADERSOLID.SummerRight.Value,
                    value_SCOPEXPORTABLEFORMHEADERSOLID.AutumnRight.Value,
                    value_SCOPEXPORTABLEFORMHEADERSOLID.SpringRight.Value,
                    value_SCOPEXPORTABLEFORMHEADERSOLID.WinterRight.Value
                };

                var indexer = 0;

                foreach (Char character in value_SCOPEXPORTABLEFORMBODYSOLID.Hierarchy.Value)
                {
                    var error = -1;

                    foreach (Char item in deflect[0])
                    {
                        error = error + 1;

                        Boolean isEqualCheck, shouldContinueCheck;

                        isEqualCheck = Object.Equals(character, item) is true;

                        shouldContinueCheck = isEqualCheck is false;

                        if (shouldContinueCheck is true)
                        {
                            continue;
                        }
                        else
                            "false".ToString();

                        var symmetry = 0;

                        symmetry = symmetry + (Int32)character;

                        symmetry = symmetry + (Int32)item;

                        var symmetryf = ((Single)symmetry / 2.00F);

                        var convert = Convert.ToInt32(symmetryf);

                        var value = Scopexportablecharactersafe.ForgeDefault((Char)convert);

                        var opposite = (error >= 4).Equals(true);

                        Scopexportablecharactersafe characterOpposite;

                        if (opposite)
                        {
                            var offset = (error - 4);

                            characterOpposite = Scopexportablecharactersafe.ForgeDefault(((Char[])deflect[1])[offset]);
                        }
                        else
                        {
                            characterOpposite = Scopexportablecharactersafe.ForgeDefault(((Char[])deflect[2])[error]);
                        }

                        XDouble xdouble;

                        xdouble = new XDouble();

                        xdouble.Position = indexer;

                        xdouble.Character = value;

                        xdouble.Opposite = opposite;

                        xdouble.CharacterOpposite = characterOpposite;

                        collectionResult.Add(xdouble);

                        continue;
                    }

                    indexer = indexer + 1;

                    continue;
                }

                return new List<XDouble>(collectionResult);
            }
        }
    }
}
