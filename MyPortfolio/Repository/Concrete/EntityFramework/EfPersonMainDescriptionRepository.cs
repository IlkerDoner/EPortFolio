using MyPortfolio.Entity;
using MyPortfolio.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Repository.Concrete.EntityFramework
{
    public class EfPersonMainDescriptionRepository :EfGenerallyRepository<PersonMainDescription>,IPersonMainDescriptionRepository
    {
        public EfPersonMainDescriptionRepository(MySiteDbContext context) : base(context)
        {

        }

        public MySiteDbContext mysitedbcontex
        {
            get { return mysitedbcontex as MySiteDbContext; }
        }
    }
}
