using Core;

namespace Core
{
    using System;

    public partial class Scopexportablequeryrequire
    {
        public static void GroupRequire()
        {
            CategoryRequire(new Boolean[2], new Int32[5], new String[3]);

            return;
        }
    }
}

namespace Core
{
    using System;

    public partial class Scopexportablequeryrequire
    {
        public static void CategoryRequire(Boolean[] array_BOOLEAN, Int32[] array_INTEGER, String[] array_STRING)
        {
            array_STRING[0] = Scopexportablemonitorvalid.Text.Value;

            Boolean isEqualAbcdCheck, shouldReturnAbcdCheck;

            isEqualAbcdCheck = Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid.RequireShould is true;

            shouldReturnAbcdCheck = isEqualAbcdCheck is false;

            if (shouldReturnAbcdCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            Boolean isEqualEfghCheck;

            isEqualEfghCheck = Object.Equals(Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid.Identity.Value, String.Empty) is true;

            if (isEqualEfghCheck)
            {
                array_STRING[1] = Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid.Real.Value;
            }
            else
            {
                array_STRING[1] = Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid.Identity.Value;
            }

            array_INTEGER[0] = array_STRING[0].IndexOf(array_STRING[1], Scopexportablemonitortext.Error);

            Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidnumeratestart.Dictionary[Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid] = array_INTEGER[0];

            Boolean isEqualAbcdAbcdCheck, shouldReturnAbcdAbcdCheck;

            isEqualAbcdAbcdCheck = Object.Equals((Int32)array_INTEGER[0], -1) is true;

            shouldReturnAbcdAbcdCheck = isEqualAbcdAbcdCheck is true;

            if (shouldReturnAbcdAbcdCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            array_INTEGER[1] = (array_INTEGER[0] + Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid.Identity.Value.Length);

            array_INTEGER[2] = (Scopexportablemonitortext.CharacterArray.Value.Length - 1);

            array_INTEGER[3] = Math.Min(array_INTEGER[1], array_INTEGER[2]);

            Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidnumerateend.Dictionary[Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid] = array_INTEGER[3];

            Scopexportablemonitortext.Error = array_INTEGER[3];

            Boolean isEqualAbcdAbcdAbcdCheck;

            isEqualAbcdAbcdAbcdCheck = (Scopexportablemonitorquery.Error >= 1).Equals(true);

            if (isEqualAbcdAbcdAbcdCheck is true)
            {
                var previous = Scopexportablemonitorquery.LinkedListNode.Previous.Value;

                array_BOOLEAN[1] = true;

                array_BOOLEAN[1] = array_BOOLEAN[1] && Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid.StickLeft is true;

                array_BOOLEAN[1] = array_BOOLEAN[1] && previous.StickRight is true;

                array_BOOLEAN[1] = array_BOOLEAN[1] && Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidnumerate.Dictionary[previous] is true;

                Scopexportablealert.Alert($"llooking for [{Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid.Real.ValueSafe}]");

                Boolean isEqualAbcdAbcdAbcdAbcdCheck;

                isEqualAbcdAbcdAbcdAbcdCheck = array_BOOLEAN[1] is true;

                if (isEqualAbcdAbcdAbcdAbcdCheck is true)
                {
                    var start = Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidnumerateend.Dictionary[previous];

                    var end = Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidnumeratestart.Dictionary[Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid];

                    var difference = (end - start);

                    var sub = array_STRING[0].Substring(start, difference);

                    Boolean isEqualAbcdAbcdAbcdAbcdAbcdCheck;

                    isEqualAbcdAbcdAbcdAbcdAbcdCheck = sub.Contains(((Char)Scopexportableascii.EntityWhitespace).ToString()) is true;

                    if (isEqualAbcdAbcdAbcdAbcdAbcdCheck is true)
                    {
                        array_BOOLEAN[0] = true;
                    }
                    else
                        "false".ToString();
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            Boolean isEqualAbcdAbcdAbcdAbcdAbcdAbcdCheck, shouldReturnAbcdAbcdAbcdAbcdAbcdAbcdCheck;

            isEqualAbcdAbcdAbcdAbcdAbcdAbcdCheck = array_BOOLEAN[0] is true;

            shouldReturnAbcdAbcdAbcdAbcdAbcdAbcdCheck = isEqualAbcdAbcdAbcdAbcdAbcdAbcdCheck is true;

            if (shouldReturnAbcdAbcdAbcdAbcdAbcdAbcdCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidnumerate.Dictionary[Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid] = true;

            Scopexportablealert.Alert($"found [{array_STRING[1]}] at [{array_STRING[0]}] with [{Scopexportablemonitorvalid.Scopexportablevalid.Scopexportablevalidnumerate.Dictionary[Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid]}] [{Scopexportablemonitorquery.Scopexportableformhierarchynumeratesolid.Real.ValueSafe}]");

            return;
        }
    }
}
