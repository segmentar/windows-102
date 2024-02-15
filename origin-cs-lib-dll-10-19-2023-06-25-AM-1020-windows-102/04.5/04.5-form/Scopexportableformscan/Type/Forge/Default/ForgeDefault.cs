using Core;

namespace Core
{
    using System;

    public partial class Scopexportableformscan
    {
        public static Scopexportableformscansolid[] ForgeDefault(Boolean answer_PERFORM_should)
        {
            Scopexportableformscansolid[] arrayResult = default;

            var array = Scan(answer_PERFORM_should);

            var reflect = (ScopexportablemoduleScan)(array[0] as Object);

            var result = reflect.ScopexportableportScan.ScopexportableformscansolidArray;

            arrayResult = result;

            return arrayResult;
        }
    }
}
