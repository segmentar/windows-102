using Core;

namespace Core
{
    using System;

    public partial class ScopexportablemoduleHierarchy
    {
        [Scopexportableisc]
        public partial struct XOctuple
        {
            public Object ObjectValue;

            public Int32 PositionLeft;

            public Int32 PositionRight;

            public Scopexportablecharactersafe CharacterLeft;

            public Scopexportablecharactersafe CharacterRight;

            public Boolean StickLeft;

            public Boolean StickRight;

            public Scopexportablestringsafe Value;

            public Object[] ObjectArray;

            public Object ObjectValueParent;

            public Scopexportableformseasonwrap Scopexportableformseasonwrap;

            public Scopexportableformseasonunwrap Scopexportableformseasonunwrap;

            public Scopexportablestringsafe Real;

            [Scopexportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] {

                    String.Empty + nameof(XOctuple) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
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
                    String.Empty + '\t' + '~' + "13" + ' ' + nameof(ObjectValueParent) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "14" + ' ' + nameof(Scopexportableformseasonwrap) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "15" + ' ' + nameof(Scopexportableformseasonunwrap) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "16" + ' ' + nameof(Real) + ':' + ' ' + "<hidden>",
                    String.Empty + '\t' + '~' + "17" + ' ' + nameof(Real) + ':' + ' ' + Real.ValueSafe,
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(ObjectValue) + ':',
                    String.Empty + ObjectValue,
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(ObjectArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), ObjectArray),
                    String.Empty,
                    String.Empty + '~' + "30" + ' ' + nameof(ObjectValueParent) + ':',
                    String.Empty + ObjectValueParent,
                    String.Empty,
                    String.Empty + '~' + "40" + ' ' + nameof(Scopexportableformseasonwrap) + ':',
                    String.Empty + Scopexportableformseasonwrap,
                    String.Empty,
                    String.Empty + '~' + "50" + ' ' + nameof(Scopexportableformseasonunwrap) + ':',
                    String.Empty + Scopexportableformseasonunwrap
                });
            }
        }
    }
}
