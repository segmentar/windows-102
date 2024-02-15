using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitortransform
    {
        public static Scopexportablemonitortransform Export()
        {
            Scopexportablemonitortransform scopexportablemonitortransformResult = default;

            Scopexportablemonitortransform scopexportablemonitortransform;

            scopexportablemonitortransform = new Scopexportablemonitortransform();

            scopexportablemonitortransform.IdleObject = Idle;

            scopexportablemonitortransform.EnumObject = Enum;

            scopexportablemonitortransform.NumerateObject = Numerate;

            scopexportablemonitortransformResult = scopexportablemonitortransform;

            return scopexportablemonitortransformResult;
        }
    }
}
