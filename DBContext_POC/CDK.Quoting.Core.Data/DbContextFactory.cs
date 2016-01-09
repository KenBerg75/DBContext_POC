using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDK.Quoting.Core.Data
{
    /// <summary>
    /// Creates DbContext's for ad-hoc situations
    /// </summary>
    public static class DbContextFactory
    {
        /// <summary>
        /// Creates a DbContext using the default connetion string name for the system
        /// </summary>
        /// <returns></returns>
        public static DbContext Create()
        {
            return Create(ConfigurationManager.AppSettings["DefaultConnectionString"]);
        }
        /// <summary>
        /// Creates a DbContext using the connetion string from the name provided
        /// </summary>
        /// <param name="connectionStringName">The name of the connectionstring as defined in a app/web.config file's connectionstrings section.</param>
        /// <returns></returns>
        public static DbContext Create(string connectionStringName)
        {
            return new DbContext(connectionStringName);
        }
    }
}
