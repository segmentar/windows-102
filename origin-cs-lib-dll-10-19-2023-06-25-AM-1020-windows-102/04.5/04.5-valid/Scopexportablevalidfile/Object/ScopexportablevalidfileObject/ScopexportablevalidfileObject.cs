﻿using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablevalidfile
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Scopexportablevalidfile) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(FileInfo) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Scopexportableformbuildsolid) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(FileInfo) + ':',
                String.Empty + FileInfo,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Scopexportableformbuildsolid) + ':',
                String.Empty + Scopexportableformbuildsolid
            });
        }
    }
}
