using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitortransform
    {
        public static String ScopexportablemonitortransformNumerateCompound(Tuple<Int32, String, Boolean>[] array_TUPLE)
        {
            String stringResult = default;

            var result = String.Empty;

            foreach (Tuple<Int32, String, Boolean> value_TUPLE in array_TUPLE)
            {
                var format = String.Format("{0} {1} {2}", value_TUPLE.Item1, value_TUPLE.Item2, value_TUPLE.Item3);

                var concat = String.Concat(result, format, (Char)Scopexportableascii.EntityLineFeed);

                result = concat;

                continue;
            }

            stringResult = result;

            return stringResult;
        }
    }
}