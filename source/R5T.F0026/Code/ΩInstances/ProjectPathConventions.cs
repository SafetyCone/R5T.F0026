using System;


namespace R5T.F0026
{
    public class ProjectPathConventions : IProjectPathConventions
    {
        #region Infrastructure

        public static IProjectPathConventions Instance { get; } = new ProjectPathConventions();


        private ProjectPathConventions()
        {
        }

        #endregion
    }
}
