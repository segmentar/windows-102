﻿using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XQuintuple
        {
            public static ScopexportableijklmnHeaderXopqr_tY[] FunctionIjklmnSetSurface(ScopexportableijklmnHeaderXopq_stY[] Ijklmn_ARRAY)
            {
                ScopexportableijklmnHeaderXopqr_tY[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new ScopexportableijklmnHeaderXopqr_tY[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
