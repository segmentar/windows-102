using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Studioxportableio
    {
        public static DirectoryInfo[] StudioxportableioFolderSetSurface(String DirectoryFullName___VALUE, Boolean answer_SELF_should)
        {
            DirectoryInfo[] arrayResult = default;

            var list = StudioxportableioFolderSet(DirectoryFullName___VALUE, answer_SELF_should);

            var array = new DirectoryInfo[list.Count];

            list.CopyTo(array, StudioxportablePolicy.StudioxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
