using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Scopexportablevalidtransform
    {
        [Scopexportableiem]
        public static void Transform()
        {
            var list = Scopexportablemagic.ScopexportablemagicArrayListDispenser(Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidenum.Dictionary);

            foreach (KeyValuePair<Scopexportableformbuildsolid, Boolean> keyValuePair in list)
            {
                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = keyValuePair.Value is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidenum.Dictionary[keyValuePair.Key] = false;

                Scopexportablealert.Alert($"found fully valid solid");

                Bootxportablemain.Main(keyValuePair.Key, true, false);

                continue;
            }

            return;
        }
    }
}
