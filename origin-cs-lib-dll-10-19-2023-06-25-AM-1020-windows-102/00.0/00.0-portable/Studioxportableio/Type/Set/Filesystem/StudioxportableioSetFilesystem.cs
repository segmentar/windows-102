﻿using Core;

namespace Core
{
    using System;

    using System.IO;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Studioxportableio
    {
        public static IList<String> StudioxportableioFilesystemSet(String DirectoryFullName___VALUE, Boolean answer_SELF_should)
        {
            ICollection<String> collectionResult = default;

            collectionResult = new Collection<String>();

            var deflect = new IEnumerable[2];

            deflect[0] = StudioxportableioFolderSetSurface(DirectoryFullName___VALUE, answer_SELF_should);

            deflect[1] = StudioxportableioFileSetSurface(DirectoryFullName___VALUE, answer_SELF_should);

            foreach (DirectoryInfo directoryInfo in deflect[0])
            {
                collectionResult.Add(directoryInfo.FullName);

                continue;
            }

            foreach (FileInfo fileInfo in deflect[1])
            {
                collectionResult.Add(fileInfo.FullName);

                continue;
            }

            return new List<String>(collectionResult);
        }
    }
}
