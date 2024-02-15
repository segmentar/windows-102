using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        [Scopexportableisc]
        public partial class XQuintuple
        {
            public ScopexportableijklmnHeaderXopqr_tY[] IjklmnArray;

            public XQuintuple(ScopexportableijklmnHeaderXopqr_tY[] ijklmnArray)
            {
                this.IjklmnArray = ijklmnArray;

                return;
            }

            ~XQuintuple()
            {
                return;
            }

            [Scopexportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(XQuintuple) + ' ' + "::" + ' ' + '{',
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
