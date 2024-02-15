using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Scopexportablemagic
    {
        public static ReadOnlyCollection<T> ScopexportablemagicReadOnlyCollectionCastDispenser<T>(Object reflect_OBJECT)
        {
            ReadOnlyCollection<T> readOnlyCollectionResult = default;

            var result = (ReadOnlyCollection<T>)(reflect_OBJECT as Object);

            readOnlyCollectionResult = result;

            return readOnlyCollectionResult;
        }
    }
}
