using Core;

namespace Core
{
    using System;

    public partial class Scopexportableformextract
    {
        public static Scopexportableformcoordinate[] ForgeDefault(Scopexportableformscansolid[] array_SCOPEXPORTABLEFORMSCANSOLID, Boolean answer_PERFORM_should)
        {
            Scopexportableformcoordinate[] arrayResult = default;

            var value = Extract(array_SCOPEXPORTABLEFORMSCANSOLID, answer_PERFORM_should);

            var result = value.ScopexportableformcoordinateArray;

            arrayResult = result;

            return arrayResult;
        }
    }
}
