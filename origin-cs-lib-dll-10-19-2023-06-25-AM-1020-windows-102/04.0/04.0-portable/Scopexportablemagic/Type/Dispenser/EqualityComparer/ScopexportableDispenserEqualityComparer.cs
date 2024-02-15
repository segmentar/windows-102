using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Scopexportablemagic
    {
        public static Boolean ScopexportableEqualityComparerDispenser<T>(T type_VALUE)
        {
            Boolean booleanResult = false;

            Boolean isEqualAbcdCheck;

            isEqualAbcdCheck = EqualityComparer<T>.Default.Equals(type_VALUE, default(T)) is true;

            if (isEqualAbcdCheck is true)
            {
                booleanResult = true;
            }
            else
                "false".ToString();

            return booleanResult;
        }
    }
}
