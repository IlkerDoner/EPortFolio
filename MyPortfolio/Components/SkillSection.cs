using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using MyPortfolio.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Components
{
    public class SkillSection :ViewComponent
    {
        private IGeneralSkillsRepository repository;
        public SkillSection(IGeneralSkillsRepository _repository)
        {
            repository = _repository;
        }

        public IViewComponentResult Invoke()
        {
            var res = repository.GetAll();
            if (res.Count() != 0)
            {
                var skills = res.Select(i => new GeneralSkillsModel()
                {
                   GeneralSkillsName = i.GeneralSkillsName,
                   GeneralSkillsPercentage = i.GeneralSkillsPercentage
                });

                return View(skills);
            }
            else
            {
                return View();
            }
        }
    }
}
