using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleUnite
    {
        public partial class XSingle
        {
            public static XSingle ForgeIjklmn(Object[] array_OBJECT, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEFORMBODYSOLID, Scopexportableformhierarchysolid[] array_SCOPEXPORTABLEFORMHIERARCHYSOLID)
            {
                XSingle xsingleResult = default;

                var array = FunctionIjklmnSetSurface(array_OBJECT, array_SCOPEXPORTABLEFORMHEADERSOLID, array_SCOPEXPORTABLEFORMBODYSOLID, array_SCOPEXPORTABLEFORMHIERARCHYSOLID);

                XSingle xsingle;

                xsingle = new XSingle(array);

                xsingleResult = xsingle;

                return xsingleResult;
            }
        }
    }
}
