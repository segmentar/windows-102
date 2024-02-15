using Core;

namespace Core
{
    using System;

    public partial struct Scopexportableformbuildsolid
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Scopexportableformbuildsolid) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Scopexportableformheadersolid) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Scopexportableformbodysolid) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ScopexportableformhierarchynumeratesolidArray) + ':' + ' ' + ". . ." + ' ' + $"<{ScopexportableformhierarchynumeratesolidArray.Length}>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ScopexportableformhierarchynumeratesolidNonParentArray) + ':' + ' ' + ". . ." + ' ' + $"<{ScopexportableformhierarchynumeratesolidNonParentArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Scopexportableformheadersolid) + ':',
                String.Empty + Scopexportableformheadersolid,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Scopexportableformbodysolid) + ':',
                String.Empty + Scopexportableformbodysolid,
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(ScopexportableformhierarchynumeratesolidArray) + ':',
                String.Empty + String.Join('\n'.ToString(), ScopexportableformhierarchynumeratesolidArray),
                String.Empty,
                String.Empty + '~' + "40" + ' ' + nameof(ScopexportableformhierarchynumeratesolidNonParentArray) + ':',
                String.Empty+ String.Join('\n'.ToString(), ScopexportableformhierarchynumeratesolidNonParentArray)
            });
        }
    }
}
