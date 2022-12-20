using System;


namespace R5T.F0026
{
	public class ExecutableFileRelativePathOperator : IExecutableFileRelativePathOperator
	{
		#region Infrastructure

	    public static IExecutableFileRelativePathOperator Instance { get; } = new ExecutableFileRelativePathOperator();

	    private ExecutableFileRelativePathOperator()
	    {
        }

	    #endregion
	}
}