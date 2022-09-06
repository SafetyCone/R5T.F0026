using System;


namespace R5T.F0026
{
	public class ExecutableFileRelativePathOperator : IExecutableFileRelativePathOperator
	{
		#region Infrastructure

	    public static ExecutableFileRelativePathOperator Instance { get; } = new();

	    private ExecutableFileRelativePathOperator()
	    {
        }

	    #endregion
	}
}