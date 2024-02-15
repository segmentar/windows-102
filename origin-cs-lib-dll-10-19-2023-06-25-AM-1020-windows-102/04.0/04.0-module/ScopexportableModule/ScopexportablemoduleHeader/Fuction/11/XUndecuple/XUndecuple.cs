using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        public partial class XUndecuple
        {
            public ScopexportableijklmnHeaderUopqr_tV[] IjklmnArray;

            public XUndecuple(ScopexportableijklmnHeaderUopqr_tV[] ijklmnArray)
            {
                this.IjklmnArray = ijklmnArray;

                return;
            }

            ~XUndecuple()
            {
                return;
            }

            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(XDecuple) + ' ' + "::" + ' ' + '{',
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
