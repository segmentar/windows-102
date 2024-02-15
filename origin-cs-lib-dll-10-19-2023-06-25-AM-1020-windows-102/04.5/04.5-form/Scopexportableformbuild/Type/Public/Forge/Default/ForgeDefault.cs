using Core;

namespace Core
{
    using System;

    public partial class Scopexportableaccumulate
    {
        public static Scopexportableformbuildsolid[] ForgeDefault(Scopexportableformcoordinate[] array_SCOPEXPORTABLEEXTRACTFORM, Boolean answer_PERFORM_should)
        {
            Scopexportableformbuildsolid[] arrayResult = default;

            var array = Accumulate(array_SCOPEXPORTABLEEXTRACTFORM, answer_PERFORM_should);

            var reflect = (ScopexportablemoduleUnite)(array[3] as Object);

            var result = reflect.ScopexportableportUnite.ScopexportableformbuildsolidArray;

            arrayResult = result;

            return arrayResult;
        }
    }
}
