using Core;

namespace Core
{
    using System;

    public partial struct Scopexportableformhierarchynumeratesolid
    {
        [Scopexportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Scopexportableformhierarchynumeratesolid) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(ObjectValue) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(PositionLeft) + ':' + ' ' + PositionLeft,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(PositionRight) + ':' + ' ' + PositionRight,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(CharacterLeft) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(CharacterLeft) + ':' + ' ' + CharacterLeft.ValueSafe,
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(CharacterRight) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(CharacterRight) + ':' + ' ' + CharacterRight.ValueSafe,
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(StickLeft) + ':' + ' ' + StickLeft,
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(StickRight) + ':' + ' ' + StickRight,
                String.Empty + '\t' + '~' + "10" + ' ' + nameof(Value) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "11" + ' ' + nameof(Value) + ':' + ' ' + Value.ValueSafe,
                String.Empty + '\t' + '~' + "12" + ' ' + nameof(ObjectArray) + ':' + ' ' + ". . ." + ' ' + $"<{ObjectArray.Length}>",
                String.Empty + '\t' + '~' + "13" + ' ' + nameof(Real) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "14" + ' ' + nameof(Real) + ':' + ' ' + Real.ValueSafe,
                String.Empty + '\t' + '~' + "15" + ' ' + nameof(Identity) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "16" + ' ' + nameof(Identity) + ':' + ' ' + Identity.ValueSafe,
                String.Empty + '\t' + '~' + "17" + ' ' + nameof(Link) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "18" + ' ' + nameof(Link) + ':' + ' ' + Link.ValueSafe,
                String.Empty + '\t' + '~' + "19" + ' ' + nameof(RequireShould) + ':' + ' ' + RequireShould,
                String.Empty + '\t' + '~' + "20" + ' ' + nameof(OptionShould) + ':' + ' ' + OptionShould,
                String.Empty + '\t' + '~' + "21" + ' ' + nameof(AnyShould) + ':' + ' ' + AnyShould,
                String.Empty + '\t' + '~' + "22" + ' ' + nameof(SomeShould) + ':' + ' ' + SomeShould,
                String.Empty + '\t' + '~' + "23" + ' ' + nameof(DivideShould) + ':' + ' ' + DivideShould,
                String.Empty + '\t' + '~' + "24" + ' ' + nameof(SequenceShould) + ':' + ' ' + SequenceShould,
                String.Empty + '\t' + '~' + "25" + ' ' + nameof(SentenceShould) + ':' + ' ' + SentenceShould,
                String.Empty + '\t' + "~" + "26" + ' ' + nameof(ParagraphShould) + ':' + ' ' + ParagraphShould,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(ObjectValue) + ':',
                String.Empty + ObjectValue,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ObjectArray) + ':',
                String.Empty + String.Join('\n'.ToString(), ObjectArray)
            });
        }
    }
}
