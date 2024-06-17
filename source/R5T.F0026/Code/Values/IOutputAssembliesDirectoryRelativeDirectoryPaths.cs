using System;

using R5T.T0131;


namespace R5T.F0026
{
	[ValuesMarker]
	public partial interface IOutputAssembliesDirectoryRelativeDirectoryPaths : IValuesMarker
	{
        /// <summary>
        /// The /Debug or /Release or other build configuration directory.
        /// <para><value>"..\"</value></para>
        /// </summary>
        public string BuildConfigurationDirectory => @"..\";

        /// <summary>
        /// The /bin directory.
        /// <para><value>"..\..\"</value></para>
        /// </summary>
        public string BinariesDirectory => @"..\..\";

        /// <summary>
        /// <para><value>"..\..\..\"</value></para>
        /// </summary>
        public string ProjectDirectory => @"..\..\..\";

        /// <summary>
        /// <para><value>"..\..\..\..\"</value></para>
        /// </summary>
        public string SolutionDirectory => @"..\..\..\..\";
    }
}