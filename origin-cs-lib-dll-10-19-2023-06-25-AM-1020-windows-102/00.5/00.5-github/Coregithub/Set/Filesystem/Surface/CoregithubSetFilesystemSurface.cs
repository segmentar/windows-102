using Core;

namespace Core
{
    using System;

    public partial class Studioxportablegithub
    {

        public static String[] CoregithubSetFilesystemSurface(String DirectoryFullName___VALUE)
        {
            String[] arrayResult = default;

            var list = CoregithubSetFilesystem(DirectoryFullName___VALUE);

            var array = new String[list.Count];

            list.CopyTo(array, StudioxportablePolicy.StudioxportableIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
