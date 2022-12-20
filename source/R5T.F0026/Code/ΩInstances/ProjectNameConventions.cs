using System;


namespace R5T.F0026
{
    public class ProjectNameConventions : IProjectNameConventions
    {
        #region Infrastructure

        public static IProjectNameConventions Instance { get; } = new ProjectNameConventions();


        private ProjectNameConventions()
        {
        }

        #endregion
    }
}
