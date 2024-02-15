using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorstate
    {
        public static Scopexportablemonitorstate Data()
        {
            Scopexportablemonitorstate scopexportablemonitorstateResult = default;

            Scopexportablemonitorstate scopexportablemonitorstate;

            scopexportablemonitorstate = new Scopexportablemonitorstate();

            scopexportablemonitorstate.IsRunObject = true;

            scopexportablemonitorstate.IsPauseObject = true;

            scopexportablemonitorstate.SkipShouldObject = false;

            scopexportablemonitorstate.RestartShouldObject = false;

            scopexportablemonitorstate.AddressObject = 0;

            scopexportablemonitorstate.FramerateObject = 50;

            scopexportablemonitorstate.IntervalObject = 250;

            scopexportablemonitorstateResult = scopexportablemonitorstate;

            return scopexportablemonitorstateResult;
        }
    }
}
