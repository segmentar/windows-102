using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public static ScopexportablemoduleHierarchy Action(Scopexportableformcoordinate[] array_SCOPEXPORTABLEFORMCOORDINATE, Object[] array_OBJECT, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADER, Scopexportableformbodysolid[] array_SCOPEXPORTABLEFORMBODY)
        {
            ScopexportablemoduleHierarchy moduleResult = default;

            try
            {
                moduleResult = Default(array_SCOPEXPORTABLEFORMCOORDINATE, array_OBJECT, array_SCOPEXPORTABLEFORMHEADER, array_SCOPEXPORTABLEFORMBODY);
            }
            catch (Exception exception)
            {
                Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Fatal}", exception);
            }

            if (ScopexportableModule.ScopexportablemoduleHierarchy is true)
            {
                try
                {
                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleHierarchy)}-00", ScopexportablemoduleHierarchycycle.XZeroth);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleHierarchy)}-01", String.Join('\n'.ToString(), ScopexportablemoduleHierarchycycle.XPrimary.IjklmnArray));

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleHierarchy)}-02", String.Join('\n'.ToString(), ScopexportablemoduleHierarchycycle.XSecondary.IjklmnArray));

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleHierarchy)}-03", String.Join('\n'.ToString(), ScopexportablemoduleHierarchycycle.XTertiary.IjklmnArray));

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleHierarchy)}-04", String.Join('\n'.ToString(), ScopexportablemoduleHierarchycycle.XQuaternary.IjklmnArray));

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleHierarchy)}-05", String.Join('\n'.ToString(), ScopexportablemoduleHierarchycycle.XQuinary.IjklmnArray));

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleHierarchy)}-06", String.Join('\n'.ToString(), ScopexportablemoduleHierarchycycle.XSenary.IjklmnArray));

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleHierarchy)}-07", String.Join('\n'.ToString(), ScopexportablemoduleHierarchycycle.XSeptenary.IjklmnArray));

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleHierarchy)}-08", String.Join('\n'.ToString(), ScopexportablemoduleHierarchycycle.XOctonary.IjklmnArray));
                    
                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleHierarchy)}-09", String.Join('\n'.ToString(), ScopexportablemoduleHierarchycycle.XNonary.IjklmnArray));

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleHierarchy)}-10", ScopexportablemoduleHierarchycycle.XDenary.XDecuple);
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
