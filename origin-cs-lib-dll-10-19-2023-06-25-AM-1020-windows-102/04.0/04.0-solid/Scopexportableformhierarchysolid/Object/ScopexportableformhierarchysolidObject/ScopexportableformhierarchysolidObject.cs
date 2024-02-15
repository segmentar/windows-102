using Core;

namespace Core
{
    using System;

    public partial struct Scopexportableformhierarchysolid
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Scopexportableformhierarchysolid) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Object) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ScopexportablehierarchynumeratesolidArray) + ':' + ". . ." + ' ' + $"<{ScopexportablehierarchynumeratesolidArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ScopexportablehierarchynumeratesolidArray) + ':',
                String.Empty + String.Join('\n'.ToString(), ScopexportablehierarchynumeratesolidArray)
            });
        }
    }
}
