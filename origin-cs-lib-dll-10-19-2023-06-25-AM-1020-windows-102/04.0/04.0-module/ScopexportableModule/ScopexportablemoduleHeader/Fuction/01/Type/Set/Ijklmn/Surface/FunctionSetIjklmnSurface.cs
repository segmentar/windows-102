using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XSingle
        {
            public static ScopexportableijklmnHeaderX_pqrstY[] FunctionIjklmnSetSurface(Scopexportableformcoordinate[] array_SCOPEXPORTABLEFORMCOORDINATE, Object[] array_OBJECT)
            {
                ScopexportableijklmnHeaderX_pqrstY[] arrayResult = default;

                var list = FunctionIjklmnSet(array_SCOPEXPORTABLEFORMCOORDINATE, array_OBJECT);

                var array = new ScopexportableijklmnHeaderX_pqrstY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}