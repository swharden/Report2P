using System.Collections.Generic;

namespace PVXML;

public static class Filesystem
{
    private static bool IsNamedLike2pFolder(string dirPath)
    {
        return Path.GetFileName(dirPath).Split("-").Length >= 4;
    }

    /// <summary>
    /// Walk the filesystem two levels deep and return paths of all 2p data folders found.
    /// 2p data folders may be subfolders of the given path,
    /// or 2p data folders may be inside subfolders of the given path.
    /// </summary>
    public static string[] Get2PDataFolders(string folderPath)
    {
        if (!Directory.Exists(folderPath))
            return Array.Empty<string>();

        List<string> twoPhotonFolderPaths = new();
        foreach (string dirPath in Directory.GetDirectories(folderPath))
        {
            if (IsNamedLike2pFolder(dirPath))
            {
                twoPhotonFolderPaths.Add(dirPath);
                continue;
            }

            foreach (string subDirPath in Directory.GetDirectories(dirPath))
            {
                if (IsNamedLike2pFolder(subDirPath))
                {
                    twoPhotonFolderPaths.Add(subDirPath);
                }
            }
        }

        return twoPhotonFolderPaths.ToArray();
    }
}