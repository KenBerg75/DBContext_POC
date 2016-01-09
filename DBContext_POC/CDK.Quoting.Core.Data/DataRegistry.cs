using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDK.Quoting.Core.Data
{
    public class DataRegistry : Registry
    {
        public DataRegistry()
        {
            // Different ways consuming apps can create the context if they do not use the Base Repository
            //For<DbContext>().Use(DbContextFactory.Create());
            
            // Create with a different connection provider
            //For<DbContext>().Use(DbContextFactory.Create("Some Connection String Name"));
        }
    }
}
