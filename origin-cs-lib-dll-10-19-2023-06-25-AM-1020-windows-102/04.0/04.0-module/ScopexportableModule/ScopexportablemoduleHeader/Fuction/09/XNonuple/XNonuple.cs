using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        [Scopexportableisc]
        public partial class XNonuple
        {
            public ScopexportableijklmnHeaderUop_rstV[] IjklmnArray;

            public XNonuple(ScopexportableijklmnHeaderUop_rstV[] ijklmnArray)
            {
                this.IjklmnArray = ijklmnArray;

                return;
            }

            ~XNonuple()
            {
                return;
            }

            [Scopexportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(XNonuple) + ' ' + "::" + ' ' + '{',
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
