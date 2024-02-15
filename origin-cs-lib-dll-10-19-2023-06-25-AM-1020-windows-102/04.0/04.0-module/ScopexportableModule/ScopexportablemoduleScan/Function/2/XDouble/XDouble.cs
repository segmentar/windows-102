using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        [Scopexportableisc]
        public partial class XDouble
        {
            public ScopexportableijklmnScanXo_qrstY[] IjklmnArray;

            public XDouble(ScopexportableijklmnScanXo_qrstY[] ijklmnArray)
            {
                this.IjklmnArray = ijklmnArray;

                return;
            }

            ~XDouble()
            {
                return;
            }

            [Scopexportableism]
            public override string ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(XDouble) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "function",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IjklmnArray) + ':' + ' ' + ". . ." + ' ' + $"<{IjklmnArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(IjklmnArray) + ':',
                String.Empty + String.Join('\n'.ToString(), IjklmnArray)
            });
            }
        }
    }
}
