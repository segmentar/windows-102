﻿using Core;

namespace Core
{
    using System;

    public partial class Scopexportablerestart
    {
        public static void Restart()
        {
            Scopexportablemonitorstate.RestartShould = true;

            Scopexportablealert.Alert(nameof(Restart));

            return;
        }
    }
}
