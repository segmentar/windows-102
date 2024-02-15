using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitortransform
    {
        public static void Import(Scopexportablemonitortransform value_SCOPEXPORTABLEMONITORTRANSFORM)
        {
            Idle = (Boolean)value_SCOPEXPORTABLEMONITORTRANSFORM.IdleObject;

            Enum = (Scopexportablestringsafe)value_SCOPEXPORTABLEMONITORTRANSFORM.EnumObject;

            Numerate = (Scopexportablestringsafe)value_SCOPEXPORTABLEMONITORTRANSFORM.NumerateObject;

            return;
        }
    }
}
