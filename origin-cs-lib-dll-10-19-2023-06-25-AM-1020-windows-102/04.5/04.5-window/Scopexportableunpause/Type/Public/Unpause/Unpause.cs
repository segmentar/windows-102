using Core;

namespace Core
{
    using System;

    public partial class Scopexportableunpause
    {
        public static void Unpause()
        {
            Scopexportablemonitorexpression.GroupSync();

            if (Scopexportablemonitorstate.SkipShould is true)
            {
                goto end;
            }
            else
                "false".ToString();

            Scopexportablemonitorvalid.GroupSync();

            if (Scopexportablemonitorstate.SkipShould is true)
            {
                goto end;
            }
            else
                "false".ToString();

            Scopexportablemonitortext.GroupSync();

            if (Scopexportablemonitorstate.SkipShould is true)
            {
                goto end;
            }
            else
                "false".ToString();
            
            Scopexportablemonitorquery.GroupSync();

            if (Scopexportablemonitorstate.SkipShould is true)
            {
                goto end;
            }
            else
                "false".ToString();

            Scopexportablemonitortransform.GroupSync();

            if (Scopexportablemonitorstate.SkipShould is true)
            {
                goto end;
            }
            else
                "false".ToString();

            end:
            {
                if (Scopexportablemonitorstate.SkipShould is true)
                {
                    Scopexportableskip.Switch();
                }
                else
                    "false".ToString();

                return;
            }
        }
    }
}
