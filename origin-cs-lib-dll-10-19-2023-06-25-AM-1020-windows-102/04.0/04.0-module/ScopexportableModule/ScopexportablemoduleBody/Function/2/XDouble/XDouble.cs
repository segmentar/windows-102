using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        [Scopexportableisc]
        public partial class XDouble
        {
            public ScopexportableijklmnBodyXo_qrstY[] IjklmnArray;

            public XDouble(ScopexportableijklmnBodyXo_qrstY[] ijklmnArray)
            {
                this.IjklmnArray = ijklmnArray;

                return;
            }

            ~XDouble()
            {
                return;
            }

            [Scopexportableism]

            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
                
                    String.Empty + nameof(XDouble) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "level",
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
