using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Studioxportablegithub
    {

        public static IList<String> CoregithubSetFilesystem(String DirectoryFullName___VALUE)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            var value = Directory.GetDirectories(DirectoryFullName___VALUE);

            var result = CoregithubSetResourceSurface(value);

            foreach (DirectoryInfo directoryInfo in result)
            {
                var array = Studioxportableio.StudioxportableioFilesystemSetSurface(directoryInfo.FullName, true);

                foreach (String stringValue in array)
                {
                    collectionResult.Add(stringValue);

                    continue;
                }

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
