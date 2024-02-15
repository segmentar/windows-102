using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleUnite
    {
        public partial class XSingle
        {
            public static Scopexportableformbuildsolid[] FunctionIjklmnSetSurface(Object[] array_OBJECT, Scopexportableformheadersolid[] array_SCOPEXPORTABLEFORMHEADERSOLID, Scopexportableformbodysolid[] array_SCOPEXPORTABLEFORMBODYSOLID, Scopexportableformhierarchysolid[] array_SCOPEXPORTABLEFORMHIERARCHYSOLID)
            {
                Scopexportableformbuildsolid[] arrayResult = default;

                var list = FunctionIjklmnSet(array_OBJECT, array_SCOPEXPORTABLEFORMHEADERSOLID, array_SCOPEXPORTABLEFORMBODYSOLID, array_SCOPEXPORTABLEFORMHIERARCHYSOLID);

                var array = new Scopexportableformbuildsolid[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
