﻿using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XFirst
        {
            public XSingle XSingle;

            public XFirst(XSingle xsingle)
            {
                this.XSingle = xsingle;

                return;
            }

            ~XFirst()
            {
                return;
            }
        }
    }
}
