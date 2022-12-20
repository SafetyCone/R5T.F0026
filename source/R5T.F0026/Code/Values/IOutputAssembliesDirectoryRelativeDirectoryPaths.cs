using System;

using R5T.T0131;


namespace R5T.F0026
{
	[ValuesMarker]
	public partial interface IOutputAssembliesDirectoryRelativeDirectoryPaths : IValuesMarker
	{
        /// <summary>
        /// The /Debug or /Release or other build configuration directory.
        /// </summary>
        public string BuildConfigurationDirectory => @"..\";
        /// <summary>
        /// The /bin directory.
        /// </summary>
        public string BinariesDirectory => @"..\..\";
        public string ProjectDirectory => @"..\..\..\";
        public string SolutionDirectory => @"..\..\..\..\";
    }
}