using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleUnite
    {
        public static ScopexportablemoduleUnite Action(Scopexportableformcoordinate[] array_SCOPEXPORTABLEFORMCOORDINATE, Object[] array_OBJECT, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEFORMBODYSOLID, Scopexportableformhierarchysolid[] array_SCOPEXPORTABLEFORMHIERARCHYSOLID)
        {
            ScopexportablemoduleUnite moduleResult = default;

            try
            {
                moduleResult = Default(array_SCOPEXPORTABLEFORMCOORDINATE, array_OBJECT, array_SCOPEXPORTABLEFORMHEADERSOLID, array_SCOPEXPORTABLEFORMBODYSOLID, array_SCOPEXPORTABLEFORMHIERARCHYSOLID);

            } catch (Exception exception)
            {
                Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Fatal}", exception);
            }

            if (ScopexportableModule.ScopexportablemoduleUnite is true)
            {
                try
                {
                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleUnite)}-00", ScopexportablemoduleUnitecycle.XZeroth);

                    Scopexportablerender.GroupRender($"{ScopexportableCode.ProductPath.Core_Scopexportable_Render}-{ScopexportableIdentity.ScopexprotableOrdinalIdentity}x{ScopexportableIdentity.ScopexportableNameIdentity}-{nameof(ScopexportablemoduleUnite)}-01", ScopexportablemoduleUnitecycle.XPrimary.XSingle);
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
