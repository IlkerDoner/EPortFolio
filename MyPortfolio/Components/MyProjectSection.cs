using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using MyPortfolio.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Components
{
    public class MyProjectSection : ViewComponent
    {
        private IMyProjectRepository repository;
        public MyProjectSection(IMyProjectRepository _repository)
        {
            repository = _repository;
        }

        public IViewComponentResult Invoke()
        {

            var res = repository.GetAll();
            if (res.Count() != 0)
            {
                var projectList = res.Select(i => new MyProjectModel()
                {
                    MyProjectsId =i.MyProjectsId,
                    MyProjectImages = i.MyProjectImages,
                    MyProjectHeader = i.MyProjectHeader,
                    MyProjectSmallDescription = i.MyProjectSmallDescription,
                    MyProjectLink = i.MyProjectLink
                });
                return View(projectList);

            }
            else
            {
                return View();
            }

        }
    }
}
