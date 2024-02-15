using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        [Scopexportableisc]
        public partial class XSeptuple
        {
            public ScopexportableijklmnBodyU_pqrstV[] IjklmnArray;

            public XSeptuple(ScopexportableijklmnBodyU_pqrstV[] ijklmnArray)
            {
                this.IjklmnArray = ijklmnArray;

                return;
            }

            ~XSeptuple()
            {
                return;
            }

            [Scopexportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(XSextuple) + ' ' + "::" + ' ' + '{',
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
