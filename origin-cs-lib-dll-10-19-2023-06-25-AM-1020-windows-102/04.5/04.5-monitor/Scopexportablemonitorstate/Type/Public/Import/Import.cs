﻿using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorstate
    {
        public static void Import(Scopexportablemonitorstate value_SCOPEXPORTABLEMONITORSTATE)
        {
            IsRun = (Boolean)value_SCOPEXPORTABLEMONITORSTATE.IsRunObject;

            IsPause = (Boolean)value_SCOPEXPORTABLEMONITORSTATE.IsPauseObject;

            SkipShould = (Boolean)value_SCOPEXPORTABLEMONITORSTATE.SkipShouldObject;

            RestartShould = (Boolean)value_SCOPEXPORTABLEMONITORSTATE.RestartShouldObject;

            Address = (Int32)value_SCOPEXPORTABLEMONITORSTATE.AddressObject;

            Framerate = (Int32)value_SCOPEXPORTABLEMONITORSTATE.FramerateObject;

            Interval = (Int32)value_SCOPEXPORTABLEMONITORSTATE.IntervalObject;

            return;
        }
    }
}
