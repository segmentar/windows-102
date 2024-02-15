using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Scopexportablealert
    {
        public static void Alert(Object value_OBJECT)
        {
            MessageBox.Show(value_OBJECT.ToString());

            Console.Out.WriteLine(value_OBJECT);

            return;
        }
    }
}
