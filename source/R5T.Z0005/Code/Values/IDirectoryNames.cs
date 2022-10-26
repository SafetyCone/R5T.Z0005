using System;

using R5T.T0131;


namespace R5T.Z0005
{
    [ValuesMarker]
    public interface IDirectoryNames : IValuesMarker
    {
        public string GitHiddenDirectory => ".git";
    }
}