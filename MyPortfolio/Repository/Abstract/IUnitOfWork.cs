using MyPortfolio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Repository.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonMainDescriptionRepository personMainDescription { get; }
        IMyProjectRepository myProject { get; }
        IGraduateSchoolRepository graduateSchool { get; }
        IGeneralSkillsRepository generalSkills { get; }
        IEmploymentRepository employment { get; }

        int SaveChanges();

    }
}
