using System;


namespace R5T.F0026
{
	public class ProjectDirectoryRelativeDirectoryPaths : IProjectDirectoryRelativeDirectoryPaths
	{
		#region Infrastructure

	    public static IProjectDirectoryRelativeDirectoryPaths Instance { get; } = new ProjectDirectoryRelativeDirectoryPaths();

	    private ProjectDirectoryRelativeDirectoryPaths()
	    {
        }

	    #endregion
	}
}