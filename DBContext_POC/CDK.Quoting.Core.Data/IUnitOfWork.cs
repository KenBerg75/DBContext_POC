using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDK.Quoting.Core.Data
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// SaveChanges will try and commit all statements that have been executed against the database inside this unit of work.
        /// </summary>
        /// <remarks>
        /// If committing fails, the underlying <see cref="IDbTransaction"/> will be rolled back instead.
        /// </remarks>
        /// <exception cref="InvalidOperationException">Thrown if this unit of work has already been committed or rolled back.</exception>
        void SaveChanges();
    }
}
