using MyPortfolio.Entity;
using MyPortfolio.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Repository.Concrete.EntityFramework
{
    public class EfGraduateSchoolRepository : EfGenerallyRepository<GraduateSchool>,IGraduateSchoolRepository
    {
        public EfGraduateSchoolRepository(MySiteDbContext contex) : base(contex)
        {

        }
        //public MySiteDbContext mysitedbcontex
        //{
        //    get { return mysitedbcontex as MySiteDbContext; }
        //}
        
    }
}
