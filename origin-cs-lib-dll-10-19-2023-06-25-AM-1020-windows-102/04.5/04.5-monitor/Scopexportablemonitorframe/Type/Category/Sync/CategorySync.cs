using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorframe
    {
        public static void CategorySync(Boolean answer_FIRST_is, Boolean answer_LAST_is)
        {
            Scopexportablemonitorstate.Address = Scopexportablemonitorstate.Address + 1;

            if (answer_FIRST_is is true)
            {
                LinkedList.AddFirst(Scopexportablemonitortransaction.Data());

                ScopexportablemonitortransactionArray = new Scopexportablemonitortransaction[LinkedList.Count];

                LinkedList.CopyTo(ScopexportablemonitortransactionArray, ScopexportablePolicy.ScopexportableIndexPolicy);

                ReadOnlyCollection = Scopexportablemagic.ScopexportablemagicReadOnlyCollectionDispenser<Scopexportablemonitortransaction>(ScopexportablemonitortransactionArray);
            }
            else
                "false".ToString();

            if (answer_LAST_is is true)
            {
                LinkedList.AddLast(Scopexportablemonitortransaction.Data());

                ScopexportablemonitortransactionArray = new Scopexportablemonitortransaction[LinkedList.Count];

                LinkedList.CopyTo(ScopexportablemonitortransactionArray, ScopexportablePolicy.ScopexportableIndexPolicy);

                ReadOnlyCollection = Scopexportablemagic.ScopexportablemagicReadOnlyCollectionDispenser<Scopexportablemonitortransaction>(ScopexportablemonitortransactionArray);

                Pointer = Pointer + 1;
            }
            else
                "false".ToString();

            Boolean isEqualCheck;

            isEqualCheck = (LinkedList.Count > Scopexportablemonitorstate.Framerate).Equals(true);

            if (isEqualCheck is true)
            {
                LinkedList.RemoveFirst();

                Pointer = Pointer - 1;
            }
            else
                "false".ToString();

            return;
        }
    }
}
