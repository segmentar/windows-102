using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorexpression
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Scopexportablemonitorexpression) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IdleObject) + ':' + ' ' + (Boolean)IdleObject,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ExpressionObject) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(ExpressionObject) + ':' + ' ' + ExpressionObject.ValueSafe,
                String.Empty + '}'
            });
        }
    }
}
