using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        [Scopexportableisc]
        public partial class XSingle
        {
            public ScopexportableijklmnScanX_pqrstY[] IjklmnArray;

            public XSingle(ScopexportableijklmnScanX_pqrstY[] ijklmnArray)
            {
                this.IjklmnArray = ijklmnArray;

                return;
            }

            ~XSingle()
            {
                return;
            }

            [Scopexportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(ScopexportablemoduleScan) + ' ' + "::" + ' ' + '{',
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
