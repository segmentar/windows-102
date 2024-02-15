using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        public partial class XSingle
        {
            public static ScopexportableijklmnBodyX_pqrstY[] FunctionIjklmnSetSurface(Scopexportableformcoordinate[] array_SCOPEXPORTABLEFORMCOORDINATE, Object[] array_OBJECT)
            {
                ScopexportableijklmnBodyX_pqrstY[] arrayResult = default;

                var list = FunctionIjklmnSet(array_SCOPEXPORTABLEFORMCOORDINATE, array_OBJECT);

                var array = new ScopexportableijklmnBodyX_pqrstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
