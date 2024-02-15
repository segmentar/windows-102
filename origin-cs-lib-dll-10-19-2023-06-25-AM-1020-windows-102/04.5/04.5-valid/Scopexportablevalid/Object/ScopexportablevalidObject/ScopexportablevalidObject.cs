using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablevalid
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Scopexportablevalid) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(ScopexportableformbuildsolidArray) + ':' + ' ' + ". . ." + ' ' + $"<{ScopexportableformbuildsolidArray.Length}>",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Scopexportablevalidenum) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Scopexportablevalidnumerate) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Scopexportablevalidnumeratestart) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(Scopexportablevalidnumerateend) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(Scopexportablevalidnumeratestring) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ScopexportableformbuildsolidArray) + ':',
                String.Empty + String.Join('\n'.ToString(), ScopexportableformbuildsolidArray),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Scopexportablevalidenum) + ':',
                String.Empty + Scopexportablevalidenum,
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(Scopexportablevalidnumerate) + ':',
                String.Empty + Scopexportablevalidnumerate,
                String.Empty,
                String.Empty + '~' + "40" + ' ' + nameof(Scopexportablevalidnumeratestart) + ':',
                String.Empty + Scopexportablevalidnumeratestart,
                String.Empty,
                String.Empty + '~' + "50" + ' ' + nameof(Scopexportablevalidnumerateend) + ':',
                String.Empty + Scopexportablevalidnumerateend,
                String.Empty,
                String.Empty + '~' + "60" + ' ' + nameof(Scopexportablevalidnumeratestring) + ':',
                String.Empty + Scopexportablevalidnumeratestring
            });
        }
    }
}
