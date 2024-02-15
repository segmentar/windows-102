using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        [Scopexportableisc]
        public partial class XSextuple
        {
            public ScopexportableijklmnHeaderXopqrs_Y[] IjklmnArray;

            public XSextuple(ScopexportableijklmnHeaderXopqrs_Y[] ijklmnArray)
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
