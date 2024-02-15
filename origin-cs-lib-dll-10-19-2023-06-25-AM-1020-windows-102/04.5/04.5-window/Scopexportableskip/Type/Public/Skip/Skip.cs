using Core;

namespace Core
{
    using System;

    public partial class Scopexportableskip
    {
        public static void Skip()
        {
            Switch();

            Scopexportablealert.Alert(nameof(Skip));

            return;
        }
    }
}
