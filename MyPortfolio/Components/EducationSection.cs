using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using MyPortfolio.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Components
{
    public class EducationSection : ViewComponent
    {
        private IGraduateSchoolRepository repository;

        public EducationSection(IGraduateSchoolRepository _repository)
        {
            repository = _repository;
        }

        public IViewComponentResult Invoke()
        {
            var res = repository.GetAll().ToList();
            if (res.Count() != 0)
            {
                var listOfEducation = res.Select(i => new EducationContextModel()
                {
                    GraduateDepartment = i.GraduateDepartment,
                    GraduateSchoolName = i.GraduateSchoolName,
                    GraduateDate = i.GraduateDate
                });

                return View(listOfEducation);

                //return View(res.Select(i => new EducationContextModel()
                //{
                //    GraduateDepartment = i.GraduateDepartment,
                //    GraduateSchoolName = i.GraduateSchoolName,
                //    GraduateDate = i.GraduateDate
                //}));
            }
            else
            {
                return View();
            }

        }
    }
}

