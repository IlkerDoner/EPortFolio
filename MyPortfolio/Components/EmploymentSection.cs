using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Entity;
using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Components
{
    public class EmploymentSection : ViewComponent
    {
        private IEmploymentRepository repository;

        public EmploymentSection(IEmploymentRepository _repository)
        {
            repository = _repository;
        }

        public IViewComponentResult Invoke()
        {
            var res = repository.GetAll();
            if (res.Count() != 0)
            {
                var employment = res.Select(i => new EmploymentModel()
                {
                    EmploymentNames = i.EmploymentNames,
                    EmploymentDescription = i.EmploymentDescription,
                    EmploymentDate = i.EmploymentDate
                });
                return View(employment);
            }
            else
            {
                return View();
            }

        }
    }
}
