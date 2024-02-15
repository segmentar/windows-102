using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleUnite
    {
        public static ScopexportablemoduleUnite Default(Scopexportableformcoordinate[] array_SCOPEXPORTABLEFORMCOORDINATE, Object[] array_OBJECT, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEFORMBODYSOLID, Scopexportableformhierarchysolid[] array_SCOPEXPORTABLEFORMHIERARCHYSOLID)
        {
            ScopexportablemoduleUnite moduleResult = default;

            var inflect = new Object[5];

            inflect[0] = array_SCOPEXPORTABLEFORMCOORDINATE;

            inflect[1] = array_OBJECT;

            inflect[2] = array_SCOPEXPORTABLEFORMHEADERSOLID;

            inflect[3] = array_SCOPEXPORTABLEFORMBODYSOLID;

            inflect[4] = array_SCOPEXPORTABLEFORMHIERARCHYSOLID;

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            ScopexportablemoduleUnitecycle.XZeroth = xzeroth;

            ScopexportablemoduleUnite module;

            module = new ScopexportablemoduleUnite();

            module.XOne();

            ScopexportableportUnite scopexportableportUnite;

            scopexportableportUnite = new ScopexportableportUnite();

            scopexportableportUnite.ScopexportableformbuildsolidArray = ScopexportablemoduleUnitecycle.XPrimary.XSingle.ScopexportableaccumulatesolidArray;

            module.ScopexportableportUnite = scopexportableportUnite;

            moduleResult = module;

            return moduleResult;
        }
    }
}
