using Core;

namespace Core
{
    using System;

    using System.Collections;
    using System.Collections.Generic;

    public partial struct Scopexportablemonitortransform
    {
        public static ICollection ScopexportablemonitortransformEnumContainer()
        {
            IList listResult = default;

            listResult = new ArrayList();

            var ordinal = 1;

            foreach (KeyValuePair<Scopexportableformbuildsolid, Boolean> keyValuePair in Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidenum.Dictionary)
            {
                Tuple<Int32, String, Boolean> tuple;

                tuple = new Tuple<Int32, String, Boolean>(ordinal, keyValuePair.Key.Scopexportableformheadersolid.Name.Value, keyValuePair.Value);

                listResult.Add(tuple);

                ordinal = ordinal + 1;

                continue;
            }

            return listResult;
        }
    }
}