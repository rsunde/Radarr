﻿using System;
using System.IO;

namespace NzbDrone.Core.Providers
{
    public class DiskProvider : IDiskProvider
    {
        #region IDiskProvider Members

        public bool FolderExists(string path)
        {
            return Directory.Exists(path);
        }

        public bool FileExists(string path)
        {
            return File.Exists(path);
        }

        public string[] GetDirectories(string path)
        {
            return Directory.GetDirectories(path);
        }

        public string[] GetFiles(string path, string pattern, SearchOption searchOption)
        {
            return Directory.GetFiles(path, pattern, searchOption);
        }

        public long GetSize(string path)
        {
            var fi = new FileInfo(path);
            return fi.Length;
            //return new FileInfo(path).Length;
        }

        public String CreateDirectory(string path)
        {
            return Directory.CreateDirectory(path).FullName;
        }

        public void DeleteFile(string path)
        {
            File.Delete(path);
        }

        public void RenameFile(string sourcePath, string destinationPath)
        {
            File.Move(sourcePath, destinationPath);
        }

        public string GetFolderName(string path)
        {
            var di = new DirectoryInfo(path);
            return di.Name;
        }

        #endregion
    }
}