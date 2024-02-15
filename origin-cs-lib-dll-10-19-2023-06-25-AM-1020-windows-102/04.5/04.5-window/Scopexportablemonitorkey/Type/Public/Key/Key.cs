using Core;

namespace Core
{
    using System;

    public partial class Scopexportablemonitorkey
    {
        public static void Key(Object reflect_OBJECT, Char value_CHARACTER)
        {
            var convert = Convert.ToInt32(value_CHARACTER);

            if (Object.Equals(Scopexportableascii.EntityZero, convert))
            {
                Scopexportableframerate.Framerate(reflect_OBJECT);
            }
            else if (Object.Equals(Scopexportableascii.EntityOne, convert))
            {
                Scopexportablefontdown.Fontdown();
            }
            else if (Object.Equals(Scopexportableascii.EntityTwo, convert))
            {
                Scopexportablefontup.Fontup();
            }
            else if (Object.Equals(Scopexportableascii.EntityThree, convert))
            {
                Scopexportableclip.Clip(reflect_OBJECT);
            }
            else if (Object.Equals(Scopexportableascii.EntityFour, convert))
            {
                Scopexportablespeed.Speed(reflect_OBJECT);
            }
            else if (Object.Equals(Scopexportableascii.EntityFive, convert))
            {
                Scopexportablepause.Pause();
            }
            else if (Object.Equals(Scopexportableascii.EntitySix, convert))
            {
                Scopexportableskip.Skip();
            }
            else if (Object.Equals(Scopexportableascii.EntitySeven, convert))
            {
                Scopexportablebackward.Backward();
            }
            else if (Object.Equals(Scopexportableascii.EntityEight, convert))
            {
                Scopexportableforward.Forward();
            }
            else if (Object.Equals(Scopexportableascii.EntityNine, convert))
            {
                Scopexportablerestart.Restart();
            }

            return;
        }
    }
}
