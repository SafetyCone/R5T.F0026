using System;


namespace R5T.F0026
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