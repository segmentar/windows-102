using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Scopexportablemagic
    {
        public static T[] ScopexportablemagicStackReverseDispenser<T>(IEnumerable value_ENUMERABLE)
        {
            T[] arrayResult = default;

            var reflect = (ICollection)(value_ENUMERABLE as IEnumerable);

            var stack = new Stack(reflect);

            var array = new T[stack.Count];

            stack.CopyTo(array, ScopexportablePolicy.ScopexportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
