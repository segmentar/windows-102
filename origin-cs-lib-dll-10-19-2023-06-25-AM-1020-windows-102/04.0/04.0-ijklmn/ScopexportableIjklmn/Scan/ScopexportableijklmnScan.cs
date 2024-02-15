using Core;

namespace Core
{
    using System;

    using System.IO;

    [Scopexportableisc]
    public partial struct ScopexportableijklmnScanX_pqrstY
    {
        public DirectoryInfo DirectoryInfo;

        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(ScopexportableijklmnScanX_pqrstY) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "level",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(DirectoryInfo) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(DirectoryInfo) + ':',
                String.Empty + DirectoryInfo
            });
        }
    }
}

namespace Core
{
    using System;

    using System.IO;

    [Scopexportableisc]
    public partial struct ScopexportableijklmnScanXo_qrstY
    {
        public DirectoryInfo DirectoryInfo;

        public FileInfo FileInfo;

        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ScopexportableijklmnScanXo_qrstY) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "level",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(DirectoryInfo) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(FileInfo) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(DirectoryInfo) + ':',
                String.Empty + DirectoryInfo,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(FileInfo) + ':',
                String.Empty + FileInfo
            });
        }
    }
}

namespace Core
{
    using System;

    using System.IO;

    [Scopexportableisc]
    public partial struct ScopexportableijklmnScanXop_rstY
    {
        public DirectoryInfo DirectoryInfo;

        public FileInfo FileInfo;

        public Scopexportablestringsafe Text;

        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(ScopexportableijklmnScanXop_rstY) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "level",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(DirectoryInfo) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(FileInfo) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Text) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Text) + ':' + ' ' + Text.ValueSafe,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(DirectoryInfo) + ':',
                String.Empty + DirectoryInfo,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(FileInfo) + ':',
                String.Empty + FileInfo
            });
        }
    }
}