using System;

using R5T.F0002;


namespace R5T.F0026
{
    public static class Instances
    {
        public static IDirectoryNames DirectoryNames { get; } = F0026.DirectoryNames.Instance;
        public static IExecutablePathOperator ExecutablePathOperator { get; } = F0002.ExecutablePathOperator.Instance;
        public static IPathOperator PathOperator { get; } = F0002.PathOperator.Instance;
    }
}