﻿using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class TextboxScopexportableA
    {
        public static void PropagateKeyPressRedirect(Object sender, KeyPressEventArgs e)
        {
            foreach (Char value_CHARACTER in ScopexportableradicalFunction.FunctionCharacterArray)
            {
                Boolean isEqualCheck, shouldContinueCheck;

                isEqualCheck = Object.Equals(value_CHARACTER, e.KeyChar) is true;

                shouldContinueCheck = isEqualCheck is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                e.Handled = true;

                continue;
            }

            return;
        }
    }
}
