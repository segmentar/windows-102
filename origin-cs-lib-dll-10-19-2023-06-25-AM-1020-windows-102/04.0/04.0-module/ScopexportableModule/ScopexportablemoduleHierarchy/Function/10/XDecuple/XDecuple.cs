using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        [Scopexportableisc]
        public partial class XDecuple
        {
            public Scopexportableformhierarchysolid[] ScopexportableformhierarchysolidArray;

            public XDecuple(Scopexportableformhierarchysolid[] scopexportableformhierarchysolidArray)
            {
                this.ScopexportableformhierarchysolidArray = scopexportableformhierarchysolidArray;

                return;
            }

            ~XDecuple()
            {
                return;
            }

            [Scopexportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(XDecuple) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(ScopexportableformhierarchysolidArray) + ':' + ' ' + ". . ." + ' ' + $"<{ScopexportableformhierarchysolidArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(ScopexportableformhierarchysolidArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), ScopexportableformhierarchysolidArray)
                });
            }
        }
    }
}
