﻿using Core;

namespace Core
{
    using System;

    public partial class ExpressionxportablereadbuildModule
    {
        [Expressionxportableisc]
        public partial class XTriple
        {
            public ExpressionxportablereadXop_rstY[] LevelArray;

            public XTriple(ExpressionxportablereadXop_rstY[] levelArray)
            {
                this.LevelArray = levelArray;

                return;
            }

            ~XTriple()
            {
                return;
            }

            [Expressionxportableism]
            public override String ToString()
            {
                return String.Join('\n'.ToString(), new String[] { 
                
                    String.Empty + nameof(XTriple) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "function",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(LevelArray) + ':' + ' ' + ". . ." + ' ' + $"<{LevelArray.Length}>",
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(LevelArray) + ':',
                    String.Empty + String.Join('\n'.ToString(), LevelArray)
                });
            }
        }
    }
}
