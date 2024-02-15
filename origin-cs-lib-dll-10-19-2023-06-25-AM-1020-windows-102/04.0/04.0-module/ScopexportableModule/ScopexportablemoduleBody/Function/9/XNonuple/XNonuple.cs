using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleBody
    {
        [Scopexportableisc]
        public partial class XNonuple
        {
            public Scopexportableformbodysolid[] ScopexportableformbodysolidArray;

            public XNonuple(Scopexportableformbodysolid[] scopexportableformbodysolidArray)
            {
                this.ScopexportableformbodysolidArray = scopexportableformbodysolidArray;

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
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(ScopexportableformbodysolidArray) + ':' + ' ' + ". . ." + ' ' + $"<{ScopexportableformbodysolidArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(ScopexportableformbodysolidArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), ScopexportableformbodysolidArray)
                });
            }
        }
    }
}
