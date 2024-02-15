using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public static ScopexportablemoduleBody Default(Scopexportableformcoordinate[] array_SCOPEXPORTABLEFORMCOORDINATE, Object[] array_OBJECT, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADERSOLID)
        {
            ScopexportablemoduleBody moduleResult = default;

            var inflect = new Object[3];

            inflect[0] = array_SCOPEXPORTABLEFORMCOORDINATE;

            inflect[1] = array_OBJECT;

            inflect[2] = array_SCOPEXPORTABLEFORMHEADERSOLID;

            XZeroth xzeroth;

            xzeroth = new XZeroth(inflect);

            ScopexportablemoduleBodycycle.XZeroth = xzeroth;

            ScopexportablemoduleBody module;

            module = new ScopexportablemoduleBody();

            module.XOne();

            module.XTwo();

            module.XThree();

            module.XFour();

            module.XFive();

            module.XSix();

            module.XSeven();

            module.XEight();

            module.XNine();

            ScopexportableportBody scopexportableportBody;

            scopexportableportBody = new ScopexportableportBody();

            scopexportableportBody.Ijklmn = ScopexportablemoduleBodycycle.XPrimary.XSingle.IjklmnArray;

            scopexportableportBody.IjklmnIjklmn = ScopexportablemoduleBodycycle.XSecondary.XDouble.IjklmnArray;

            scopexportableportBody.IjklmnIjklmnIjklmn = ScopexportablemoduleBodycycle.XTertiary.XTriple.IjklmnArray;

            scopexportableportBody.IjklmnIjklmnIjklmnIjklmn = ScopexportablemoduleBodycycle.XQuaternary.XQuadruple.IjklmnArray;

            scopexportableportBody.IjklmnIjklmnIjklmnIjklmnIjklmn = ScopexportablemoduleBodycycle.XQuinary.XQuintuple.IjklmnArray;

            scopexportableportBody.IjklmnIjklmnIjklmnIjklmnIjklmnIjklmn = ScopexportablemoduleBodycycle.XSenary.XSextuple.IjklmnArray;

            scopexportableportBody.IjklmnIjklmnIjklmnIjklmnIjklmnIjklmnIjklmn = ScopexportablemoduleBodycycle.XSeptenary.XSeptuple.IjklmnArray;

            scopexportableportBody.IjklmnIjklmnIjklmnIjklmnIjklmnIjklmnIjklmnIjklmn = ScopexportablemoduleBodycycle.XOctonary.XOctuple.IjklmnArray;

            scopexportableportBody.ScopexportableformbodysolidArray = ScopexportablemoduleBodycycle.XNonary.XNonuple.ScopexportableformbodysolidArray;

            module.ScopexportableportBody = scopexportableportBody;

            moduleResult = module;
            
            return moduleResult;
        }
    }
}
