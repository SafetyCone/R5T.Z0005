using System;


namespace R5T.Z0005
{
    public class DirectoryNames : IDirectoryNames
    {
        #region Infrastructure

        public static DirectoryNames Instance { get; } = new();

        private DirectoryNames()
        {
        }

        #endregion
    }
}