using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitortransform
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Scopexportablemonitortransform) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IdleObject) + ':' + ' ' + (Boolean)IdleObject,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(EnumObject) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(EnumObject) + ':' + ' ' + ((Scopexportablestringsafe)EnumObject).ValueSafe,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(EnumObject) + ':' + ' ' + ". . . . .",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(NumerateObject) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(NumerateObject) + ':' + ' ' + ((Scopexportablestringsafe)NumerateObject).ValueSafe,
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(NumerateObject) + ':' + ' ' + ". . . . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(EnumObject) + ':',
                String.Empty + ((Scopexportablestringsafe)EnumObject).Value,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(NumerateObject) + ':',
                String.Empty + ((Scopexportablestringsafe)NumerateObject).Value
            });
        }
    }
}
