using Core;

namespace Core
{
    using System;

    using System.Windows;
    using System.Windows.Forms;

    public partial class Scopexportableframerate
    {
        public static void Framerate(Object reflect_OBJECT)
        {
            var reflect = (FormScopexportableA)(reflect_OBJECT as Object);

            reflect.Hide();

            TextBox textBox;

            textBox = new TextBox();

            textBox.Dock = DockStyle.Fill;

            Form form;

            form = new Form();

            form.Text = "Framerate";

            form.Controls.Add(textBox);

            form.Show();

            form.FormClosed += new FormClosedEventHandler((Object sender, FormClosedEventArgs e) => {

                var parse = Int32.Parse(textBox.Text);

                Scopexportablemonitorstate.Framerate = parse;

                Scopexportablemonitorframe.CategorySync(false, true);

                reflect.Show();
            });

            Scopexportablealert.Alert(nameof(Framerate));

            return;
        }
    }
}
