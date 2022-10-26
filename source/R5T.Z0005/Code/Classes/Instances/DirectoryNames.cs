using System;


namespace R5T.Z0005
{
    public class DirectoryNames : IDirectoryNames
    {
        #region Infrastructure

        public static IDirectoryNames Instance { get; } = new DirectoryNames();

        private DirectoryNames()
        {
        }

        #endregion
    }
}