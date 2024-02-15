using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        [Scopexportableisc]
        public partial class XOctuple
        {
            public ScopexportableijklmnHeaderUo_qrstV[] IjklmnArray;
            
            public XOctuple(ScopexportableijklmnHeaderUo_qrstV[] ijklmnArray)
            {
                this.IjklmnArray = ijklmnArray;

                return;
            }

            ~XOctuple()
            {
                return;
            }

            [Scopexportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
                
                    String.Empty + nameof(XOctuple) + ' ' + "::" + ' ' + '{',
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