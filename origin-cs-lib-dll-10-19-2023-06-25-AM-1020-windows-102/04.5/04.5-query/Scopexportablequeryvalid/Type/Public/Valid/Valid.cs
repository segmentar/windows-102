using Core;

namespace Core
{
    using System;

    public partial class Scopexportablequeryvalid
    {
        public static void Valid()
        {
            foreach (Scopexportableformbuildsolid scopexportableformbuildsolid in Scopexportablemonitorvalid.Scopexportablevalid.ScopexportableformbuildsolidArray)
            {
                var valid = true;

                foreach (Scopexportableformhierarchynumeratesolid scopexportableformhierarchynumeratesolid in scopexportableformbuildsolid.ScopexportableformhierarchynumeratesolidNonParentArray)
                {
                    valid = valid && Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidnumerate.Dictionary[scopexportableformhierarchynumeratesolid];

                    continue;
                }

                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = valid is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidenum.Dictionary[scopexportableformbuildsolid] = true;

                foreach (Scopexportableformhierarchynumeratesolid scopexportableformhierarchynumeratesolid in scopexportableformbuildsolid.ScopexportableformhierarchynumeratesolidNonParentArray)
                {
                    Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidnumerate.Dictionary[scopexportableformhierarchynumeratesolid] = false;

                    continue;
                }

                Scopexportablealert.Alert("resolved something");

                break;
            }

            return;
        }
    }
}
