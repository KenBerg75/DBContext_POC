using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDK.Quoting.Core.Data.Repository
{
    /// <summary>
    /// Base repository class provides a method for implementors to create their contexts
    /// </summary>
    public class BaseRepository
    {
        public DbContext GetContext()
        {
            return DbContextFactory.Create();
        }

        public DbContext GetContext(string connectionStringName)
        {
            return DbContextFactory.Create(connectionStringName);
        }
    }
}
