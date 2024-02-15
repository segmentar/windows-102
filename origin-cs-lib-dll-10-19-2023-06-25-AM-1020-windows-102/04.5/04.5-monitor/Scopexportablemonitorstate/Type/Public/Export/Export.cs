using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorstate
    {
        public static Scopexportablemonitorstate Export()
        {
            Scopexportablemonitorstate scopexportablemonitorstateResult = default;

            Scopexportablemonitorstate scopexportablemonitorstate;

            scopexportablemonitorstate = new Scopexportablemonitorstate();

            scopexportablemonitorstate.IsRunObject = IsRun;

            scopexportablemonitorstate.IsPauseObject = IsPause;

            scopexportablemonitorstate.SkipShouldObject = SkipShould;

            scopexportablemonitorstate.RestartShouldObject = RestartShould;

            scopexportablemonitorstate.AddressObject = Address;

            scopexportablemonitorstate.FramerateObject = Framerate;

            scopexportablemonitorstate.IntervalObject = Interval;

            scopexportablemonitorstateResult = scopexportablemonitorstate;

            return scopexportablemonitorstateResult;
        }
    }
}
