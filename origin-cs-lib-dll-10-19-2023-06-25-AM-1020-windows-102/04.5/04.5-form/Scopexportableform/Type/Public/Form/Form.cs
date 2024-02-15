using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    public partial class Scopexportableform
    {
        public static void Form(Boolean answer_IDENTITY_should, Boolean answer_PERFORM_should, Boolean answer_PROCESS_should)
        {
            if (answer_IDENTITY_should is true)
            {
                ScopexportableIdentity.ScopexportableNameIdentity = Path.GetRandomFileName();

                ScopexportableIdentity.ScopexprotableOrdinalIdentity = ScopexportableIdentity.ScopexprotableOrdinalIdentity + 1;
            }
            else
                "false".ToString();

            var deflect = new IEnumerable[3];

            deflect[0] = Scopexportableformscan.ForgeDefault(answer_PERFORM_should);

            deflect[1] = Scopexportableformextract.ForgeDefault((Scopexportableformscansolid[])deflect[0], answer_PERFORM_should);

            deflect[2] = Scopexportableaccumulate.ForgeDefault((Scopexportableformcoordinate[])deflect[1], answer_PERFORM_should);

            if (answer_PROCESS_should is true)
            {
                Scopexportableprocess.Process((Scopexportableformbuildsolid[])deflect[2], true);
            }
            else
                "false".ToString();

            return;
        }
    }
}
