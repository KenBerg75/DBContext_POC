﻿using StructureMap;
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
            //ForSingletonOf<IDbConnectionFactory>().Use<DbConnectionFactory>()
            //    .Ctor<string>().Is("Quoting.Database");  // Connection String Name


        }
    }
}