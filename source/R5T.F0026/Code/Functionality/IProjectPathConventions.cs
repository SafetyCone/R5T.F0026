using System;
using System.Security.Cryptography;
using R5T.T0132;


namespace R5T.F0026
{
    [FunctionalityMarker]
    public partial interface IProjectPathConventions : IFunctionalityMarker
    {
        public string GetOutputAssembliesDirectoryPath(string outputAssemblyFilePath)
        {
            var outputAssembliesDirectoryPath = F0000.PathOperator.Instance.GetFileParentDirectoryPath(outputAssemblyFilePath);
            return outputAssembliesDirectoryPath;
        }

        public string GetProjectDirectoryPath(string outputAssemblyFilePath)
        {
            var outputAssembliesDirectoryPath = this.GetOutputAssembliesDirectoryPath(outputAssemblyFilePath);

            var projectDirectoryPath = F0002.PathOperator.Instance.GetDirectoryPath(
                outputAssembliesDirectoryPath,
                OutputAssembliesDirectoryRelativeDirectoryPaths.Instance.ProjectDirectory);
            
            return projectDirectoryPath;
        }

        public string GetSolutionDirectoryPath(string outputAssemblyFilePath)
        {
            var outputAssembliesDirectoryPath = this.GetOutputAssembliesDirectoryPath(outputAssemblyFilePath);

            var solutionDirectoryPath = F0002.PathOperator.Instance.GetDirectoryPath(
                outputAssembliesDirectoryPath,
                OutputAssembliesDirectoryRelativeDirectoryPaths.Instance.SolutionDirectory);

            return solutionDirectoryPath;
        }

        public string GetProjectFilePath(
            string outputAssemblyFilePath,
            string projectName)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(outputAssemblyFilePath);

            var projectFileName = F0052.ProjectFileNameOperator.Instance.GetProjectFileName_FromProjectName(projectName);

            var projectFilePath = F0002.PathOperator.Instance.GetDirectoryPath(
                projectDirectoryPath,
                projectFileName);

            return projectFilePath;
        }

        public string GetSiblingProjectFilePath(
            string outputAssemblyFilePath,
            string siblingProjectName)
        {
            var solutionDirectoryPath = this.GetSolutionDirectoryPath(outputAssemblyFilePath);

            var siblingProjectDirectoryName = F0052.ProjectDirectoryNameOperator.Instance.GetProjectDirectoryName_FromProjectName(siblingProjectName);

            var siblingProjectFileName = F0052.ProjectFileNameOperator.Instance.GetProjectFileName_FromProjectName(siblingProjectName);

            var siblingProjectFilePath = F0002.PathOperator.Instance.GetDirectoryPath(
                solutionDirectoryPath,
                siblingProjectDirectoryName,
                siblingProjectFileName);

            return siblingProjectFilePath;
        }

        public string GetExecutableProjectFilePath(
            // In case the project name is not conventional based on the output assembly file name.
            string executableProjectName)
        {
            var executableAssemblyFilePath = F0000.ExecutablePathOperator.Instance.GetExecutableFilePath();

            var executableProjectFilePath = this.GetProjectFilePath(
                executableAssemblyFilePath,
                executableProjectName);

            return executableProjectFilePath;
        }

        public string GetExecutableSiblingProjectFilePath(
            string siblingProjectName)
        {
            var executableAssemblyFilePath = F0000.ExecutablePathOperator.Instance.GetExecutableFilePath();

            var executableSiblingProjectFilePath = this.GetSiblingProjectFilePath(
                executableAssemblyFilePath,
                siblingProjectName);

            return executableSiblingProjectFilePath;
        }
    }
}
