using System;


namespace R5T.F0026
{
    public static class Instances
    {
        public static IDirectoryNames DirectoryNames { get; } = F0026.DirectoryNames.Instance;
        public static L0066.IExecutablePathOperator ExecutablePathOperator { get; } = L0066.ExecutablePathOperator.Instance;
        public static L0066.IPathOperator PathOperator { get; } = L0066.PathOperator.Instance;
        public static F0052.IProjectDirectoryNameOperator ProjectDirectoryNameOperator => F0052.ProjectDirectoryNameOperator.Instance;
        public static F0052.IProjectFileNameOperator ProjectFileNameOperator => F0052.ProjectFileNameOperator.Instance;
        public static IOutputAssembliesDirectoryRelativeDirectoryPaths OutputAssembliesDirectoryRelativeDirectoryPaths => F0026.OutputAssembliesDirectoryRelativeDirectoryPaths.Instance;
    }
}