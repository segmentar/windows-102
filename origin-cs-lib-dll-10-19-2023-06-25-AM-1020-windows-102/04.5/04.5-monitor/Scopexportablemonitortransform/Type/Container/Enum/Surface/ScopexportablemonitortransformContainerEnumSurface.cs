using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial struct Scopexportablemonitortransform
    {
        public static T[] ScopexportablemonitortransformEnumContainerSurface<T>()
        {
            T[] arrayResult = default;

            var list = ScopexportablemonitortransformEnumContainer();

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