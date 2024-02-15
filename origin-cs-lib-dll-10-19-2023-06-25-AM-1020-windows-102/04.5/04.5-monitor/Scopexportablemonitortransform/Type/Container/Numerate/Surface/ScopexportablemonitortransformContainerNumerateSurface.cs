using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;
    using System.Collections.Generic;

    public partial struct Scopexportablemonitortransform
    {
        public static T[] ScopexportablemonitortransformNumerateContainerSurface<T>()
        {
            T[] arrayResult = default;

            var list = ScopexportablemonitortransformNumerateContainer();

            IEnumerable item;

            item = list;

            item = item.OfType<T>();

            IEnumerable<T> entry;

            entry = item.Cast<T>();

            entry = entry.ToArray<T>();

            var reflect = (T[])(entry as Array);

            var result = reflect;

            arrayResult = result;

            return arrayResult;
        }
    }
}