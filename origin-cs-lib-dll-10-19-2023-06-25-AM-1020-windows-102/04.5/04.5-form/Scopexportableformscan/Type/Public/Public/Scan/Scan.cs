using Core;

namespace Core
{
    using System;

    public partial class Scopexportableformscan
    {
        public static Object[] Scan(Boolean answer_PERFORM_should)
        {
            Object[] arrayResult;

            if (answer_PERFORM_should is true)
            {
                ScopexportableModule.ScopexportablemoduleScan = false;
            }
            else
                "false".ToString();

            ScopexportablemoduleScan scopexportablemoduleScan = ScopexportablemoduleScan.Action();

            var inflect = new Object[1];

            inflect[0] = scopexportablemoduleScan;

            var result = inflect;

            arrayResult = result;

            return arrayResult;
        }
    }
}
