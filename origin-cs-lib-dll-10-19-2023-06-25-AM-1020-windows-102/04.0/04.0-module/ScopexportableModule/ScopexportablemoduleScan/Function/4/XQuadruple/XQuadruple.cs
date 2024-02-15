using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleScan
    {
        [Scopexportableisc]
        public partial class XQuadruple
        {
            public Scopexportableformscansolid[] ScopexportableformscansolidArray;

            public XQuadruple(Scopexportableformscansolid[] scopexportableformscansolidArray)
            {
                this.ScopexportableformscansolidArray = scopexportableformscansolidArray;

                return;
            }

            ~XQuadruple()
            {
                return;
            }

            [Scopexportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {
                
                    String.Empty + nameof(XQuadruple) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(ScopexportableformscansolidArray) + ':' + ' ' + ". . ." + ' ' + $"<{ScopexportableformscansolidArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(ScopexportableformscansolidArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), ScopexportableformscansolidArray)
                });
            }
        }
    }
}
