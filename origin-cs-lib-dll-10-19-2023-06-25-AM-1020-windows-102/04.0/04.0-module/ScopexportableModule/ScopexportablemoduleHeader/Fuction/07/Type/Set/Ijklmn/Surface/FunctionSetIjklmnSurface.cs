﻿using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XSeptuple
        {
            public static ScopexportableijklmnHeaderU_pqrstV[] FunctionIjklmnSetSurface(ScopexportableijklmnHeaderXopqrs_Y[] Ijklmn_ARRAY)
            {
                ScopexportableijklmnHeaderU_pqrstV[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new ScopexportableijklmnHeaderU_pqrstV[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
