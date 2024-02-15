using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        public static ScopexportablemoduleScan Default()
        {
            ScopexportablemoduleScan moduleResult = default;

            var inflect = new Object[0];

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            ScopexportablemoduleScancycle.XZeroth = xzeroth;

            ScopexportablemoduleScan module;

            module = new ScopexportablemoduleScan();

            module.XOne();

            module.XTwo();

            module.XThree();

            module.XFour();

            ScopexportableportScan scopexportableportScan;

            scopexportableportScan = new ScopexportableportScan();

            scopexportableportScan.Ijklmn = ScopexportablemoduleScancycle.XPrimary.XSingle.IjklmnArray;

            scopexportableportScan.IjklmnIjklmn = ScopexportablemoduleScancycle.XSecondary.XDouble.IjklmnArray;

            scopexportableportScan.IjklmnIjklmnIjklmn = ScopexportablemoduleScancycle.XTertiary.XTriple.IjklmnArray;

            scopexportableportScan.ScopexportableformscansolidArray = ScopexportablemoduleScancycle.XQuaternary.XQuadruple.ScopexportableformscansolidArray;

            module.ScopexportableportScan = scopexportableportScan;

            moduleResult = module;

            return moduleResult;
        }
    }
}
