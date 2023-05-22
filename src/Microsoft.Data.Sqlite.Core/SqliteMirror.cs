// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.IO;

namespace Microsoft.Data.Sqlite
{

    /// <summary>
    ///     Mirror handling for sqlite.
    /// </summary>
    public static class SqliteMirror
    {
        /// <summary>
        ///     Sets the mirror directory for SQLite.
        /// </summary>
        /// <param name="slaveDir">The mirror directory.</param>
        /// <returns>Whether or not the mirror was set.</returns>
        public static bool SetMirrorDirectory(string slaveDir)
        {
            if (!Directory.Exists(slaveDir))
            {
                return false;
            }

            SQLitePCL.raw.set_mirror_directory(slaveDir);
            return true;
        }
    }
}
