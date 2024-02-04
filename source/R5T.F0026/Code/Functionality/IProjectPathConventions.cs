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
            var outputAssembliesDirectoryPath = Instances.PathOperator.Get_ParentDirectoryPath_ForFile(outputAssemblyFilePath);
            return outputAssembliesDirectoryPath;
        }

        public string GetProjectDirectoryPath(string outputAssemblyFilePath)
        {
            var outputAssembliesDirectoryPath = this.GetOutputAssembliesDirectoryPath(outputAssemblyFilePath);

            var projectDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
                outputAssembliesDirectoryPath,
                OutputAssembliesDirectoryRelativeDirectoryPaths.Instance.ProjectDirectory);
            
            return projectDirectoryPath;
        }

        public string GetSolutionDirectoryPath(string outputAssemblyFilePath)
        {
            var outputAssembliesDirectoryPath = this.GetOutputAssembliesDirectoryPath(outputAssemblyFilePath);

            var solutionDirectoryPath = Instances.PathOperator.Get_DirectoryPath(
                outputAssembliesDirectoryPath,
                OutputAssembliesDirectoryRelativeDirectoryPaths.Instance.SolutionDirectory);

            return solutionDirectoryPath;
        }

        public string GetProjectFilePath(
            string outputAssemblyFilePath,
            string projectName)
        {
            var projectDirectoryPath = this.GetProjectDirectoryPath(outputAssemblyFilePath);

            var projectFileName = F0052.ProjectFileNameOperator.Instance.Get_ProjectFileName_FromProjectName(projectName);

            var projectFilePath = Instances.PathOperator.Get_DirectoryPath(
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

            var siblingProjectFileName = F0052.ProjectFileNameOperator.Instance.Get_ProjectFileName_FromProjectName(siblingProjectName);

            var siblingProjectFilePath = Instances.PathOperator.Get_DirectoryPath(
                solutionDirectoryPath,
                siblingProjectDirectoryName,
                siblingProjectFileName);

            return siblingProjectFilePath;
        }

        public string GetExecutableProjectFilePath(
            // In case the project name is not conventional based on the output assembly file name.
            string executableProjectName)
        {
            var executableAssemblyFilePath = Instances.ExecutablePathOperator.Get_ExecutableFilePath();

            var executableProjectFilePath = this.GetProjectFilePath(
                executableAssemblyFilePath,
                executableProjectName);

            return executableProjectFilePath;
        }

        public string GetExecutableSiblingProjectFilePath(
            string siblingProjectName)
        {
            var executableAssemblyFilePath = Instances.ExecutablePathOperator.Get_ExecutableFilePath();

            var executableSiblingProjectFilePath = this.GetSiblingProjectFilePath(
                executableAssemblyFilePath,
                siblingProjectName);

            return executableSiblingProjectFilePath;
        }
    }
}
