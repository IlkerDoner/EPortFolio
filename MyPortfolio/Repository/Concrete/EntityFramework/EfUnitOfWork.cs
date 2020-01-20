using MyPortfolio.Entity;
using MyPortfolio.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Repository.Concrete.EntityFramework
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly MySiteDbContext mysitedbcontext;
        public EfUnitOfWork(MySiteDbContext _mysitedbcontext)
        {
            mysitedbcontext = _mysitedbcontext ?? throw new ArgumentNullException("DbContext Can not Be null");
        }
        private IPersonMainDescriptionRepository _personmaindescription;
        private IMyProjectRepository _myproject;
        private IGraduateSchoolRepository _graduateschool;
        private IGeneralSkillsRepository _generalskills;
        private IEmploymentRepository _employment;



        public IPersonMainDescriptionRepository personMainDescription
        {
            get
            {
                return _personmaindescription ?? (_personmaindescription = new EfPersonMainDescriptionRepository(mysitedbcontext));
            }
        }

        
        public IMyProjectRepository myProject
        {
            get
            {
                return _myproject ?? (_myproject = new EfMyProjectRepository(mysitedbcontext));
            }
        }
        

        public IGraduateSchoolRepository graduateSchool
        {
            get
            {
                return _graduateschool ?? (_graduateschool = new EfGraduateSchoolRepository(mysitedbcontext));
            }
        }

        public IGeneralSkillsRepository generalSkills
        {
            get
            {
                return _generalskills ?? (_generalskills = new EfGeneralSkillsRepository(mysitedbcontext));
            }
        }

        public IEmploymentRepository employment
        {
            get
            {
                return _employment ?? (_employment = new EfEmploymentRepository(mysitedbcontext));
            }
        }

        public void Dispose()
        {
            mysitedbcontext.Dispose();
        }

        public int SaveChanges()
        {
           return mysitedbcontext.SaveChanges();
        }
    }
}
