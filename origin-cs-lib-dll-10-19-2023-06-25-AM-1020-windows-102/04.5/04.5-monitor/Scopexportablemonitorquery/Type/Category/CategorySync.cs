using Core;

namespace Core
{
    using System;

    public partial struct Scopexportablemonitorquery
    {
        public static void CategorySync()
        {
            Error = Error + 1;

            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = Object.Equals(LinkedList.Count, Error) is true;

            shouldReturnCheck = isEqualCheck is true;

            if (shouldReturnCheck is true)
            {
                Idle = true;

                Error = -1;

                Scopexportablemonitorstate.SkipShould = true;

                Scopexportablemonitortext.Idle = false;

                return;
            }
            else
                "false".ToString();

            Scopexportableformhierarchynumeratesolid = (Scopexportableformhierarchynumeratesolid)Scopexportablemagic.ScopexportablemagicArrayListDispenser(LinkedList)[Error];

            LinkedListNode = LinkedList.Find(Scopexportableformhierarchynumeratesolid);

            Scopexportablequeryrequire.GroupRequire();

            Scopexportablequeryoption.GroupOption();

            Scopexportablequeryany.GroupAny();

            Scopexportablequerysome.Some();

            Scopexportablequerysegment.Segment();

            Scopexportablequerysequence.Sequence();

            Scopexportablequerysentence.Sentence();

            Scopexportablequeryparagraph.Paragraph();

            Idle = true;

            Scopexportablemonitorstate.SkipShould = true;

            Scopexportablemonitortransform.Idle = false;

            return;
        }
    }
}
