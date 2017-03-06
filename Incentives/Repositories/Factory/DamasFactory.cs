using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using Damas.Domain.Interfaces.Repositories;

namespace Incentives.Repositories.Factory
{
    public class DamasFactory
    {
        public static TRepository GetRepositoryInstance<T, TRepository> () 
            where TRepository : IRepositoryBase<T>, new() 
            where T:class
        {
            return new TRepository();
        }
    }
}