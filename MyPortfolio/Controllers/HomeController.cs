using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using MyPortfolio.Repository.Abstract;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private IUnitOfWork uow;
        public HomeController(IUnitOfWork _uow)
        {
            uow = _uow;
        }

        public IActionResult Index()
        {
            return View();
        }

      
        public IActionResult Open_Modal_For_Long_Description(int id)
        {
            MyProjectModel prjModel = new MyProjectModel();
            if (id != 0)
            {
                var modal = uow.myProject.GetById(id);
                if (modal != null)
                {
                    prjModel.MyProjectHeader = modal.MyProjectHeader;
                    prjModel.MyProjectDescription = modal.MyProjectSmallDescription;
                    prjModel.MyProjectSmallDescription = modal.MyProjectSmallDescription;
                    prjModel.MyProjectImages = modal.MyProjectImages;
                    prjModel.MyProjectLink = modal.MyProjectLink;

                }

                return PartialView("_ProjectDescription", prjModel);
            }
            else
            {
                return View("Error");
            }
            

            
        }
    }
}
