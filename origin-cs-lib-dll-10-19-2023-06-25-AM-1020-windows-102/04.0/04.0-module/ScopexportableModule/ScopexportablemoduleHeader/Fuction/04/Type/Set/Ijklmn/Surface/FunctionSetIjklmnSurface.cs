﻿using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XQuadruple
        {
            public static ScopexportableijklmnHeaderXopq_stY[] FunctionIjklmnSetSurface(ScopexportableijklmnHeaderXop_rstY[] Ijklmn_ARRAY)
            {
                ScopexportableijklmnHeaderXopq_stY[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new ScopexportableijklmnHeaderXopq_stY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
