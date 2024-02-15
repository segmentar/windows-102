using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        public static ScopexportablemoduleScan Action()
        {
            ScopexportablemoduleScan moduleResult = default;

            try
            {
                moduleResult = Default();
            }
            catch (Exception exception)
            {
                Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Fatal}", exception);
            }

            if (ScopexportableModule.ScopexportablemoduleScan is true)
            {
                try
                {
                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleScan)}-00", ScopexportablemoduleScancycle.XZeroth);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleScan)}-01", ScopexportablemoduleScancycle.XPrimary.XSingle);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleScan)}-02", ScopexportablemoduleScancycle.XSecondary.XDouble);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleScan)}-03", ScopexportablemoduleScancycle.XTertiary.XTriple);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleScan)}-04", ScopexportablemoduleScancycle.XQuaternary.XQuadruple);

                }
                catch (Exception exception)
                {
                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Fatal}", exception);
                }
            }
            else
                "false".ToString();

            return moduleResult;
        }
    }
}
