﻿using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XOctuple
        {
            public static ScopexportableijklmnHeaderUo_qrstV[] FunctionIjklmnSetSurface(ScopexportableijklmnHeaderU_pqrstV[] Ijklmn_ARRAY)
            {
                ScopexportableijklmnHeaderUo_qrstV[] arrayResult = default;

                var list = FunctionIjklmnSet(Ijklmn_ARRAY);

                var array = new ScopexportableijklmnHeaderUo_qrstV[list.Count];

                list.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

                arrayResult = array;

                return arrayResult;
            }
        }
    }
}
