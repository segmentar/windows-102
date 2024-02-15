using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleHierarchy
    {
        public partial struct XQuintuple
        {
            public static IList<XQuintuple> FunctionDefaultSet(ScopexportableijklmnHierarchyXopq_stY Ijklmn_VALUE)
            {
                ICollection<XQuintuple> collectionResult = default;

                collectionResult = new Collection<XQuintuple>();

                foreach (XQuadruple xquadrupleItem in Ijklmn_VALUE.XQuadrupleArray)
                {
                    var value = default(Object);

                    foreach (XQuadruple xquadrupleEntry in Ijklmn_VALUE.XQuadrupleArray)
                    {
                        var array = xquadrupleEntry.ObjectArray;

                        foreach (Object objectValue in array)
                        {
                            Boolean isReferenceCheck, shouldContinueCheck;

                            isReferenceCheck = Object.ReferenceEquals(xquadrupleItem.ObjectValue, objectValue) is true;

                            shouldContinueCheck = isReferenceCheck is false;

                            if (shouldContinueCheck is true)
                            {
                                continue;
                            }
                            else
                                "false".ToString();

                            value = xquadrupleEntry.ObjectValue;

                            break;
                        }

                        continue;
                    }

                    XQuintuple xquintuple;

                    xquintuple = new XQuintuple();

                    xquintuple.ObjectValue = xquadrupleItem.ObjectValue;

                    xquintuple.PositionLeft = xquadrupleItem.PositionLeft;

                    xquintuple.PositionRight = xquadrupleItem.PositionRight;

                    xquintuple.CharacterLeft = xquadrupleItem.CharacterLeft;

                    xquintuple.CharacterRight = xquadrupleItem.CharacterRight;

                    xquintuple.StickLeft = xquadrupleItem.StickLeft;

                    xquintuple.StickRight = xquadrupleItem.StickRight;

                    xquintuple.Value = xquadrupleItem.Value;

                    xquintuple.ObjectArray = xquadrupleItem.ObjectArray;

                    xquintuple.ObjectValueParent = value;

                    collectionResult.Add(xquintuple);

                    continue;
                }

                return new List<XQuintuple>(collectionResult);
            } 
        }
    }
}
