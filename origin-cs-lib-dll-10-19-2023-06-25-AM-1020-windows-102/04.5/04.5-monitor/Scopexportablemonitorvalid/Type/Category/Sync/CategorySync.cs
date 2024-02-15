using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct Scopexportablemonitorvalid
    {
        public static void CategorySync()
        {
            Error = Error + 1;

            Boolean isEqualCheck, shouldReturnCheck;

            isEqualCheck = Object.Equals(ScopexportablevalidfileArray.Length, Error) is true;

            shouldReturnCheck = isEqualCheck is true;

            if (shouldReturnCheck is true)
            {
                Idle = true;

                Error = -1;

                Scopexportablemonitorstate.SkipShould = true;

                return;
            }
            else
                "false".ToString();

            Scopexportablevalidfile = ScopexportablevalidfileArray[Error];

            Text = Scopexportablestringsafe.ForgeDefault(File.ReadAllText(Scopexportablevalidfile.FileInfo.FullName));

            Idle = true;

            Scopexportablemonitorstate.SkipShould = true;
          
            Scopexportablemonitortext.CharacterArray = Scopexportablecharacterarraysafe.ForgeDefault(Text.Value.ToCharArray());

            Scopexportablemonitortext.Idle = false;

            return;
        }
    }
}
