﻿using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Windows;
    using System.Windows.Forms;

    public partial class TextboxScopexportableA
    {
        public static void PropagateTextChangedRedirect(Object sender, EventArgs e)
        {
            var reflect = (TextboxScopexportableA)(sender as Object);

            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = ((FormScopexportableA)reflect.FindForm()).LocalTimer.Enabled is true;

            shouldReturnCheck = isEqualCheck is false;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            Boolean isDefaultCheck, isNotDefaultCheck;

            isDefaultCheck = (Form.ActiveForm == default).Equals(true);

            isNotDefaultCheck = isDefaultCheck is false;

            if (isNotDefaultCheck is true)
            {
                if (Form.ActiveForm is FormScopexportableA)
                {
                    if (Form.ActiveForm.Controls.OfType<PanelScopexportableA>().First<PanelScopexportableA>().Controls.OfType<RichtextboxScopexportableA>().First<RichtextboxScopexportableA>().Focused is true)
                    {
                        Form.ActiveForm.Controls.OfType<TextboxScopexportableA>().First<TextboxScopexportableA>().Focus();
                    }
                    else
                        "false".ToString();
                }
                else
                    "false".ToString();
            }
            else
                "false".ToString();

            var result = Scopexportablemonitormanage.Manage(reflect.Text);

            var value = reflect.FindForm().Controls.OfType<PanelScopexportableA>().First<PanelScopexportableA>().Controls.OfType<RichtextboxScopexportableA>().First<RichtextboxScopexportableA>();

            value.Text = result;

            return;
        }
    }
}
