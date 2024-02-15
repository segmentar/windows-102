using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public static ScopexportablemoduleBody Action(Scopexportableformcoordinate[] array_SCOPEXPORTABLEFORMCOORDINATE, Object[] array_OBJECT, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADERSOLID)
        {
            ScopexportablemoduleBody moduleResult = default;

            try
            {
                moduleResult = Default(array_SCOPEXPORTABLEFORMCOORDINATE, array_OBJECT, array_SCOPEXPORTABLEFORMHEADERSOLID);
            }
            catch (Exception exception)
            {
                Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Fatal}", exception);
            }

            if (ScopexportableModule.ScopexportablemoduleBody)
            {
                try
                {
                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-00", ScopexportablemoduleBodycycle.XZeroth);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-01", ScopexportablemoduleBodycycle.XPrimary.XSingle);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-02", ScopexportablemoduleBodycycle.XSecondary.XDouble);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-03", ScopexportablemoduleBodycycle.XTertiary.XTriple);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-04", ScopexportablemoduleBodycycle.XQuaternary.XQuadruple);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-05", ScopexportablemoduleBodycycle.XQuinary.XQuintuple);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-06", ScopexportablemoduleBodycycle.XSenary.XSextuple);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-07", ScopexportablemoduleBodycycle.XSeptenary.XSeptuple);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-08", ScopexportablemoduleBodycycle.XOctonary.XOctuple);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleBody)}-09", ScopexportablemoduleBodycycle.XNonary.XNonuple);
                }
                catch (Exception exception)
                {
                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Fatal}", exception);
                }
            }
            else
            {
                moduleResult = Default(array_SCOPEXPORTABLEFORMCOORDINATE, array_OBJECT, array_SCOPEXPORTABLEFORMHEADERSOLID);
            }

            return moduleResult;
        }
    }
}
