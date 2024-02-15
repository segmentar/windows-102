using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Studioxportableio
    {
        public static FileInfo[] StudioxportableioFileSetSurface(String DirectoryFullName___VALUE, Boolean answer_SELF_should)
        {
            FileInfo[] arrayResult = default;

            var list = StudioxportableioFileSet(DirectoryFullName___VALUE, answer_SELF_should);

            var array = new FileInfo[list.Count];

            list.CopyTo(array, StudioxportablePolicy.StudioxportableIndexPolicy);

            arrayResult = array;
            
            return arrayResult;
        }
    }
}
