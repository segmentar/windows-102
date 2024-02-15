using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Bootxportableexecute
    {
        public static void Execute()
        {
            Scopexportablemessagein.Message();

            while (true)
            {
                Boolean isEqualCheck, shouldBreakCheck;

                isEqualCheck = Scopexportablemessageloop.Running() is true;

                shouldBreakCheck = isEqualCheck is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                continue;
            }

            var inflect = new Object[3];

            inflect[0] = Bootxportablefolder.Folder(true);

            foreach (FileInfo fileInfo in Bootxportableio.BootxportableioFileSetSurface((String)inflect[0], true))
            {
                inflect[1] = File.ReadAllText(fileInfo.FullName);

                inflect[2] = Expressionxportableapi.Root();

                Expressionxportableapi.ScheduleText((Expressionxportable)inflect[2], (String)inflect[1]);

                Expressionxportableapi.ReloadInExpressionFull((Expressionxportable)inflect[2], Path.GetRandomFileName());

                continue;
            }

            return;
        }
    }
}
