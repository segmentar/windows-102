using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class ScopexportablemoduleUnite
    {
        public partial class XSingle
        {
            public static IList<Scopexportableformbuildsolid> FunctionIjklmnSet(Object[] array_OBJECT, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEFORMBODYSOLID, Scopexportableformhierarchysolid[] array_SCOPEXPORTABLEFORMHIERARCHYSOLID)
            {
                ICollection<Scopexportableformbuildsolid> collectionResult = default;

                collectionResult = new Collection<Scopexportableformbuildsolid>();

                foreach (Object value_OBJECT in array_OBJECT)
                {
                    foreach (Scopexportableformheadersolid value_SCOPEXPORTABLEFORMHEADERSOLID in array_SCOPEXPORTABLEFORMHEADERSOLID)
                    {
                        foreach (Scopexportableformbodysolid value_SCOPEXPORTABLEFORMBODYSOLID in array_SCOPEXPORTABLEFORMBODYSOLID)
                        {
                            foreach (Scopexportableformhierarchysolid value_SCOPEXPORTABLEFORMHIERARCHYSOLID in array_SCOPEXPORTABLEFORMHIERARCHYSOLID)
                            {
                                var boolean = true;

                                boolean = boolean && Object.ReferenceEquals(value_SCOPEXPORTABLEFORMHEADERSOLID.Object, value_OBJECT) is true;

                                boolean = boolean && Object.ReferenceEquals(value_SCOPEXPORTABLEFORMBODYSOLID.Object, value_OBJECT) is true;

                                boolean = boolean && Object.ReferenceEquals(value_SCOPEXPORTABLEFORMHIERARCHYSOLID.Object, value_OBJECT) is true;
                                
                                Boolean isEqualCheck, shouldContinueCheck;

                                isEqualCheck = boolean is true;

                                shouldContinueCheck = isEqualCheck is false;

                                if (shouldContinueCheck is true)
                                {
                                    continue;
                                }
                                else
                                    "false".ToString();

                                Scopexportableformbuildsolid scopexportableformbuildsolid;

                                scopexportableformbuildsolid = new Scopexportableformbuildsolid();

                                scopexportableformbuildsolid.Scopexportableformheadersolid = value_SCOPEXPORTABLEFORMHEADERSOLID;

                                scopexportableformbuildsolid.Scopexportableformbodysolid = value_SCOPEXPORTABLEFORMBODYSOLID;

                                scopexportableformbuildsolid.ScopexportableformhierarchynumeratesolidArray = value_SCOPEXPORTABLEFORMHIERARCHYSOLID.ScopexportablehierarchynumeratesolidArray;

                                var list = Scopexportablemagic.ScopexportablemagicArrayListDispenser(new Object[0]);

                                foreach (Scopexportableformhierarchynumeratesolid scopexportableformhierarchynumeratesolid in value_SCOPEXPORTABLEFORMHIERARCHYSOLID.ScopexportablehierarchynumeratesolidArray)
                                {
                                    Boolean isDefaulAbcdCheck, shouldContinueAbcdCheck;

                                    isDefaulAbcdCheck = (scopexportableformhierarchynumeratesolid.ObjectValueParent == default).Equals(true);

                                    shouldContinueAbcdCheck = isDefaulAbcdCheck is false;

                                    if (shouldContinueAbcdCheck is true)
                                    {
                                        continue;
                                    }
                                    else
                                        "false".ToString();

                                    list.Add(scopexportableformhierarchynumeratesolid);

                                    continue;
                                }

                                var reflect = (Scopexportableformhierarchynumeratesolid[])(list.ToArray(typeof(Scopexportableformhierarchynumeratesolid)) as Array);

                                scopexportableformbuildsolid.ScopexportableformhierarchynumeratesolidNonParentArray = reflect;

                                collectionResult.Add(scopexportableformbuildsolid);

                                continue;
                            }

                            continue;
                        }

                        continue;
                    }

                    continue;
                }

                return new List<Scopexportableformbuildsolid>(collectionResult);
            }
        }
    }
}
