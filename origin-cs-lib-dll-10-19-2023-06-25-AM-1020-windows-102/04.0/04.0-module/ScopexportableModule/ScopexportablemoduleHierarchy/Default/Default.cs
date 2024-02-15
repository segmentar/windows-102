using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        public static ScopexportablemoduleHierarchy Default(Scopexportableformcoordinate[] array_SCOPEXPORTABLEFORMCOORDINATE, Object[] array_OBJECT, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADER, Scopexportableformbodysolid[] array_SCOPEXPORTABLEFORMBODY)
        {
            ScopexportablemoduleHierarchy moduleResult = default;

            var inflect = new Object[4];

            inflect[0] = array_SCOPEXPORTABLEFORMCOORDINATE;

            inflect[1] = array_OBJECT;

            inflect[2] = array_SCOPEXPORTABLEFORMHEADER;

            inflect[3] = array_SCOPEXPORTABLEFORMBODY;

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            ScopexportablemoduleHierarchycycle.XZeroth = xzeroth;

            ScopexportablemoduleHierarchy module;

            module = new ScopexportablemoduleHierarchy();

            module.XOne();

            module.XTwo();

            module.XThree();

            module.XFour();

            module.XFive();

            module.XSix();

            module.XSeven();

            module.XEight();
            
            module.XNine();
            
            module.XTen();

            module.XTen();

            ScopexportableportHierarchy scopexportableportHierarchy;

            scopexportableportHierarchy = new ScopexportableportHierarchy();

            scopexportableportHierarchy.Ijklmn = ScopexportablemoduleHierarchycycle.XPrimary.IjklmnArray;

            scopexportableportHierarchy.IjklmnIjklmn = ScopexportablemoduleHierarchycycle.XSecondary.IjklmnArray;

            scopexportableportHierarchy.IjklmnIjklmnIjklmn = ScopexportablemoduleHierarchycycle.XTertiary.IjklmnArray;

            scopexportableportHierarchy.IjklmnIjklmnIjklmnIjklmn = ScopexportablemoduleHierarchycycle.XQuaternary.IjklmnArray;

            scopexportableportHierarchy.IjklmnIjklmnIjklmnIjklmnIjklmn = ScopexportablemoduleHierarchycycle.XQuinary.IjklmnArray;

            scopexportableportHierarchy.IjklmnIjklmnIjklmnIjklmnIjklmnIjklmn = ScopexportablemoduleHierarchycycle.XSenary.IjklmnArray;

            scopexportableportHierarchy.IjklmnIjklmnIjklmnIjklmnIjklmnIjklmnIjklmn = ScopexportablemoduleHierarchycycle.XSeptenary.IjklmnArray;

            scopexportableportHierarchy.IjklmnIjklmnIjklmnIjklmnIjklmnIjklmnIjklmnIjklmn = ScopexportablemoduleHierarchycycle.XOctonary.IjklmnArray;

            scopexportableportHierarchy.IjklmnIjklmnIjklmnIjklmnIjklmnIjklmnIjklmnIjklmnIjklmn = ScopexportablemoduleHierarchycycle.XNonary.IjklmnArray;

            scopexportableportHierarchy.ScopexportablehierarchysolidArray = ScopexportablemoduleHierarchycycle.XDenary.XDecuple.ScopexportableformhierarchysolidArray;

            module.ScopexportableportHierarchy = scopexportableportHierarchy;

            moduleResult = module;

            return moduleResult;
        }
    }
}
