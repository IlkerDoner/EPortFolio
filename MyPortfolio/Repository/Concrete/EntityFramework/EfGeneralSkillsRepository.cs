using MyPortfolio.Entity;
using MyPortfolio.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Repository.Concrete.EntityFramework
{
    public class EfGeneralSkillsRepository :EfGenerallyRepository<GeneralSkills> ,IGeneralSkillsRepository
    {
        public EfGeneralSkillsRepository(MySiteDbContext context) : base(context)
        {

        }
        // eger interface içinde exstra bir method varsa  burdan db ye ersişim saglayabiliriz  
        // interfacelerin hepsi ortak ama sen istersen eger top 5 i listele diye 
        //asagıdaki methodu aktif edip sorguyu yollayabilirsin
        //public MySiteDbContext mysitedbcontext
        //{
        //    get { return context as MySiteDbContext; }
        //}
    }
}
