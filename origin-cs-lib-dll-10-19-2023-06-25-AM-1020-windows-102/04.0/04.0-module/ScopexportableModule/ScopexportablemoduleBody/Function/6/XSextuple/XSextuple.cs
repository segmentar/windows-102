using Core;

namespace Core
{
    using System;
    
    public partial class ScopexportablemoduleBody
    {
        [Scopexportableisc]
        public partial class XSextuple
        {
            public ScopexportableijklmnBodyXopqrs_Y[] IjklmnArray;

            public XSextuple(ScopexportableijklmnBodyXopqrs_Y[] ijklmnArray)
            {
                this.IjklmnArray = ijklmnArray;

                return;
            }

            ~XSextuple()
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
