using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Reflection;

    public partial class Scopexportablefolder
    {
        public static DirectoryInfo Folder(Boolean answer_CREATE_should)
        {
            DirectoryInfo directoryInfoResult = default;

            var EntryAssemblyFileFilename____VALUE = Assembly.GetEntryAssembly().Location;

            String[] stringArray;

            stringArray = new String[4];

            stringArray[0] = String.Empty;

            stringArray[1] = Path.Combine(stringArray[0], EntryAssemblyFileFilename____VALUE);

            stringArray[2] = Path.GetDirectoryName(stringArray[1]);

            stringArray[3] = Path.Combine(stringArray[2], Scopexportablestoreextension.EntityFolderName);

            var path_DIRECTORY_full_name = stringArray[3];

            var boolean = true;

            boolean = boolean && answer_CREATE_should is true;

            boolean = boolean && Directory.Exists(path_DIRECTORY_full_name) is false;

            Boolean isEqualNegativeCheck;

            isEqualNegativeCheck = boolean is true;

            DirectoryInfo directoryInfo;

            if (isEqualNegativeCheck)
            {
                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);
            }
            else
            {
                directoryInfo = new DirectoryInfo(path_DIRECTORY_full_name);
            }

            directoryInfoResult = directoryInfo;

            return directoryInfoResult;
        }
    }
}
