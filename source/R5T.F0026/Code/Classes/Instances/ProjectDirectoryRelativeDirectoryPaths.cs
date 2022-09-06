using System;


namespace R5T.F0026
{
	public class ProjectDirectoryRelativeDirectoryPaths : IProjectDirectoryRelativeDirectoryPaths
	{
		#region Infrastructure

	    public static ProjectDirectoryRelativeDirectoryPaths Instance { get; } = new();

	    private ProjectDirectoryRelativeDirectoryPaths()
	    {
        }

	    #endregion
	}
}