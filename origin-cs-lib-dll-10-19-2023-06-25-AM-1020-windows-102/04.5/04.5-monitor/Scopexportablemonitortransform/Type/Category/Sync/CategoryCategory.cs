using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitortransform
    {
        public static void CategorySync()
        {
            Enum = Scopexportablestringsafe.ForgeDefault(ScopexportablemonitortransformEnumCompound(ScopexportablemonitortransformEnumContainerSurface<Tuple<Int32, String, Boolean>>()));

            Numerate = Scopexportablestringsafe.ForgeDefault(ScopexportablemonitortransformNumerateCompound(ScopexportablemonitortransformNumerateContainerSurface<Tuple<Int32, String, Boolean>>()));

            Scopexportablequeryvalid.Valid();

            Scopexportablevalidtransform.Transform();

            Idle = true;

            Scopexportablemonitorquery.Idle = false;

            return;
        }
    }
}
