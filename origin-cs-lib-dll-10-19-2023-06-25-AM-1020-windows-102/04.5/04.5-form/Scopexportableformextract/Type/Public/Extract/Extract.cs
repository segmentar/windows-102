using Core;

namespace Core
{
    using System;

    public partial class Scopexportableformextract
    {
        public static ScopexportableextractUnit Extract(Scopexportableformscansolid[] array_SCOPEXPORTABLEFORMSCANSOLID, Boolean answer_PERFORM_should)
        {
            ScopexportableextractUnit unitResult = default;

            if (answer_PERFORM_should is true)
            {
                ScopexportableSeal.ScopexportablesealExtract = false;
            }
            else
                "false".ToString();

            var result = ScopexportablesealExtract.ZeroZeroth(array_SCOPEXPORTABLEFORMSCANSOLID);

            unitResult = result;

            return unitResult;
        }
    }
}
