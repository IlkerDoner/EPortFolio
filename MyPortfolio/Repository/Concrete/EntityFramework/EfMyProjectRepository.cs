using MyPortfolio.Entity;
using MyPortfolio.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Repository.Concrete.EntityFramework
{
    public class EfMyProjectRepository : EfGenerallyRepository<MyProjects>,IMyProjectRepository
    {
        public EfMyProjectRepository(MySiteDbContext context) : base(context)
        {

        }

        //public MySiteDbContext mysitedbcontex
        //{
        //    get { return mysitedbcontex as MySiteDbContext; }
        //}
    }
}
