using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        [Scopexportableisc]
        public partial class XTriple
        {
            public ScopexportableijklmnBodyXop_rstY[] IjklmnArray;

            public XTriple(ScopexportableijklmnBodyXop_rstY[] ijklmnArray)
            {
                this.IjklmnArray = ijklmnArray;

                return;
            }

            ~XTriple()
            {
                return;
            }

            [Scopexportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
                
                    String.Empty + nameof(XTriple) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "level",
                    String.Empty + '\t' + '~' + "10" + ' ' + nameof(IjklmnArray) + ':' + ' ' + ". . ." + ' ' + $"<{IjklmnArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(IjklmnArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), IjklmnArray)
                });
            }
        }
    }
}
