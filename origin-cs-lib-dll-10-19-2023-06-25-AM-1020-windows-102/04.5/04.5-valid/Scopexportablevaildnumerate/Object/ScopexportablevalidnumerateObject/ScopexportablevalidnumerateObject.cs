using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablevalidnumerate
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Scopexportablevalidnumerate) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + nameof(Dictionary) + ':' + ' ' + ". . ." + ' ' + $"<{Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportableformhierarchynumeratesolid, Boolean>(Dictionary).Count}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Dictionary) + ':',
                String.Empty + String.Join('\n'.ToString(), Scopexportabledictionary.ScopexportabledictionaryDictionaryCastDispenser<Scopexportableformhierarchynumeratesolid, Boolean>(Dictionary))
            });
        }
    }
}
