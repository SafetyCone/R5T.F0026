using System;


namespace R5T.F0026
{
	public class OutputAssembliesDirectoryRelativeDirectoryPaths : IOutputAssembliesDirectoryRelativeDirectoryPaths
	{
		#region Infrastructure

	    public static IOutputAssembliesDirectoryRelativeDirectoryPaths Instance { get; } = new OutputAssembliesDirectoryRelativeDirectoryPaths();

	    private OutputAssembliesDirectoryRelativeDirectoryPaths()
	    {
        }

	    #endregion
	}
}