using Core;

namespace Core
{
    using System;

    public partial class Scopexportablequeryany
    {
        public static void GroupAny()
        {
            CategoryAny(new Boolean[2], new Int32[1], new String[2]);

            return;
        }
    }
}

namespace Core
{
    using System;

    public partial class Scopexportablequeryany
    {
        public static void CategoryAny(Boolean[] array_BOOLEAN, Int32[] array_INTEGER, String[] array_STRING)
        {
            array_STRING[0] = Scopexportablemonitorvalid.Text.Value;

            Boolean isEqualAbcdCheck, shouldReturnAbcdCheck;

            isEqualAbcdCheck = Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid.AnyShould is true;

            shouldReturnAbcdCheck = isEqualAbcdCheck is false;

            if (shouldReturnAbcdCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            Boolean isEqualAbcdAbcdCheck, shouldReturnAbcdAbcdCheck;

            isEqualAbcdAbcdCheck = (Scopexportablemonitorquery.Error >= 1).Equals(true);

            shouldReturnAbcdAbcdCheck = isEqualAbcdAbcdCheck is false;

            if (shouldReturnAbcdAbcdCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var previous = Scopexportablemonitorquery.LinkedListNode.Previous.Value;

            Boolean isEqualAbcdAbcdAbcdCheck, shouldReturnAbcdAbcdAbcdCheck;

            isEqualAbcdAbcdAbcdCheck = Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidnumerate.Dictionary[previous] is true;

            shouldReturnAbcdAbcdAbcdCheck = isEqualAbcdAbcdAbcdCheck is false;

            if (shouldReturnAbcdAbcdAbcdCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var start = Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidnumerateend.Dictionary[previous];

            var difference = (array_STRING[0].Length - start);

            var sub = array_STRING[0].Substring(start, difference);

            var separator = new Char[1];

            separator[0] = (Char)Scopexportableascii.EntityWhitespace;

            var split = sub.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            var first = split[0];

            Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidnumeratestring.Dictionary[Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid] = first;

            if (Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid.StickRight is true)
            {
                var next = Scopexportablemonitorquery.LinkedListNode.Next.Value;

                Boolean isEqualEfghCheck;

                isEqualEfghCheck = Object.Equals(next.Identity.Value, String.Empty) is true;

                if (isEqualEfghCheck)
                {
                    array_STRING[1] = next.Real.Value;
                }
                else
                {
                    array_STRING[1] = next.Identity.Value;
                }

                var position = first.IndexOf(array_STRING[1]);

                var remove = first.Remove(position, (first.Length - position));

                Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidnumeratestring.Dictionary[Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid] = remove;
            }
            else
                "false".ToString();

            Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidnumerate.Dictionary[Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid] = true;

            Scopexportablealert.Alert($"found any [{Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidnumerate.Dictionary[Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid]}] [{Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid.Real.ValueSafe}]");

            return;
        }
    }
}
