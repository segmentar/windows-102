using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.IO.Pipes;

    public partial class ScopexportableasyncMessagein
    {
        public static void Trysafe(NamedPipeServerStream value_NAMEDPIPESERVERSTREAM)
        {
            try
            {
                StreamReader streamReader;

                streamReader = new StreamReader(value_NAMEDPIPESERVERSTREAM);

                var result = streamReader.ReadToEnd();

                Scopexportablemessageio.IO(result);

                value_NAMEDPIPESERVERSTREAM.Disconnect();

            } catch (Exception exception)
            {
                Scopexportablealert.Alert(exception);
            }

            return;
        }
    }
}
