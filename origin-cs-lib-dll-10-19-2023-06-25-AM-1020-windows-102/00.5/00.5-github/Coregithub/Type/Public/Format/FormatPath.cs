﻿using Core;

namespace Core
{
    using System;

    public partial class Studioxportablegithub
    {
        public static String FormatPath(String Filesystem_VALUE)
        {
            String stringResult = default;

            var separator = new Char[1];

            separator[0] = (Char)Studioxportableascii.EntityBackslash;

            var split = Filesystem_VALUE.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            var error = -1;

            foreach (String stringValue in split)
            {
                error = error + 1;

                var boolean = true;

                boolean = boolean && stringValue.Contains(StudioxportablenameKeyname.EntityMonthDay) is true;

                boolean = boolean && stringValue.StartsWith(StudioxportablenameKeyname.EntityOrigin) is true;

                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = boolean is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                var item = split[error];

                var value = split[error - 1];

                var entry = FormatName(item, value);

                split[error] = entry;

                continue;
            }

            var join = String.Join(((Char)Studioxportableascii.EntityBackslash).ToString(), split);

            var result = join;

            stringResult = result;

            return stringResult;
        }
    }
}
