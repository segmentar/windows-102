﻿using Core;

namespace Core
{
    using System;

    public partial struct Expressionxportableconfigure
    {
        [Expressionxportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Expressionxportableconfigure) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(WriterEncodingObject) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ReaderEncodingObject) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(StartAddressObject) + ':' + ' ' + (Int32)StartAddressObject,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ChunkSizeObject) + ':' + ' ' + (Int32)ChunkSizeObject,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(WriterEncodingObject) + ':',
                String.Empty + WriterEncodingObject,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(ReaderEncodingObject) + ':',
                String.Empty + ReaderEncodingObject
            });
        }
    }
}
