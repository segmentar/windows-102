using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHeader
    {
        [Scopexportableisc]
        public partial class XDuodecuple
        {
            public Scopexportableformheadersolid[] ScopexportableformheadersolidArray;

            public XDuodecuple(Scopexportableformheadersolid[] scopexportableformheadersolidArray)
            {
                this.ScopexportableformheadersolidArray = scopexportableformheadersolidArray;

                return;
            }

            ~XDuodecuple()
            {
                return;
            }

            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(XUndecuple) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(ScopexportableformheadersolidArray) + ':' + ' ' + ". . ." + ' ' + $"<{ScopexportableformheadersolidArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(ScopexportableformheadersolidArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), ScopexportableformheadersolidArray)
                });
            }
        }
    }
}
