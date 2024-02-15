using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitortransform
    {
        public static Scopexportablemonitortransform Data()
        {
            Scopexportablemonitortransform scopexportablemonitortransformResult = default;

            Scopexportablemonitortransform scopexportablemonitortransform;

            scopexportablemonitortransform = new Scopexportablemonitortransform();

            scopexportablemonitortransform.IdleObject = true;

            scopexportablemonitortransform.EnumObject = Scopexportablestringsafe.ForgeDefault(String.Empty);

            scopexportablemonitortransform.NumerateObject = Scopexportablestringsafe.ForgeDefault(String.Empty);

            scopexportablemonitortransformResult = scopexportablemonitortransform;

            return scopexportablemonitortransformResult;
        }
    }
}
