using Core;

namespace Core
{
    using System;

    public partial class Studioxportableio
    {
        public static String[] StudioxportableioFilesystemSetSurface(String DirectoryFullName___VALUE, Boolean answer_SELF_should)
        {
            String[] arrayResult = default;

            var list = StudioxportableioFilesystemSet(DirectoryFullName___VALUE, answer_SELF_should);

            var array = new String[list.Count];

            list.CopyTo(array, StudioxportablePolicy.StudioxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
