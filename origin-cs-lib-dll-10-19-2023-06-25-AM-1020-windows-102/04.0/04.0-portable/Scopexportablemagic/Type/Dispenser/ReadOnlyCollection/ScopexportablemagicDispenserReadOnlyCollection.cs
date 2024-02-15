using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Scopexportablemagic
    {
        public static ReadOnlyCollection<T> ScopexportablemagicReadOnlyCollectionDispenser<T>(IEnumerable<T> value_ENUMERABLE)
        {
            ReadOnlyCollection<T> readOnlyCollectionResult = default;

            var reflect = (IList<T>)(value_ENUMERABLE as IEnumerable<T>);

            ReadOnlyCollection<T> readOnlyCollection;

            readOnlyCollection = new ReadOnlyCollection<T>(reflect);

            readOnlyCollectionResult = readOnlyCollection;

            return readOnlyCollectionResult;
        }
    }
}
