using System;

using R5T.T0132;


namespace R5T.F0026
{
	[FunctionalityMarker]
	public partial interface IExecutableFileRelativePathOperator : IFunctionalityMarker
	{
		public string GetFilesDirectoryPath()
        {
			var executableDirectoryPath = Instances.ExecutablePathOperator.Get_ExecutableDirectoryPath();

			var filesDirectoryPath = Instances.PathOperator.GetDirectoryPath(
				executableDirectoryPath,
				Instances.DirectoryNames.Files);

			return filesDirectoryPath;
		}

		public string GetFilesDirectoryFilePath(string fileName)
        {
			var filesDirectoryPath = this.GetFilesDirectoryPath();

			var filePath = Instances.PathOperator.GetFilePath(
				filesDirectoryPath,
				fileName);

			return filePath;
        }
	}
}