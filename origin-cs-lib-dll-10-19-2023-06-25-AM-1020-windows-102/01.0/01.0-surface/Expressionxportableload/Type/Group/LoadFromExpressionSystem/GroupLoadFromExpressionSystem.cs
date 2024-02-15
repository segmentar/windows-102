﻿using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Expressionxportableload
    {
        public static Expressionxportable GroupLoadFromExpressionSystem(Expressionxportableloadcontext value_EXPRESSIONXPORTABLELOADCONTEXT, Expressionxportablereadclose value_EXPRESSIONXPORTABLEREADCLOSE)
        {
            Expressionxportable expressionxportableResult = default;

            var CurrentDirectory__PATH = Directory.GetCurrentDirectory();

            var path_DIRECTORY_full_name = Path.Combine(CurrentDirectory__PATH, Expressionxportablestoreextension.EntityFolderName);

            if (Directory.Exists(path_DIRECTORY_full_name) is false)
            {
                DirectoryInfo directoryInfo;

                directoryInfo = Directory.CreateDirectory(path_DIRECTORY_full_name);

                path_DIRECTORY_full_name = directoryInfo.FullName;
            }
            else
                "false".ToString();

            var path_FILE_filename = Path.Combine(path_DIRECTORY_full_name, Expressionxportablestoreextension.EntityFileName);

            var path_FILE_filename_with_extension = Path.ChangeExtension(path_FILE_filename, Expressionxportablestoreextension.EntityExtension);

            var array = GroupLoad(value_EXPRESSIONXPORTABLELOADCONTEXT, value_EXPRESSIONXPORTABLEREADCLOSE, path_FILE_filename_with_extension);

            var reflect = (ExpressionxportablereadbuildModule)(array[2] as Object);

            var result = reflect.ExpressionxportablereadbuildPort.Expressionxportable;

            expressionxportableResult = result;

            return expressionxportableResult;
        }
    }
}
