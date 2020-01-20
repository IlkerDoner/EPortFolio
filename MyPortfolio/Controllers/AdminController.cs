using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Entity;
using MyPortfolio.Models;
using MyPortfolio.Repository.Abstract;


namespace MyPortfolio.Controllers
{

    public class AdminController : Controller
    {
        private IUnitOfWork repository;
        public AdminController(IUnitOfWork _repository)
        {
            repository = _repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HeaderMain()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> HeaderMain(MainPersonelContextModel model, IFormFile file)
        {
            var personDescription = new PersonMainDescription();
            if (ModelState.IsValid)
            {

                personDescription.PersonName = model.PersonName;
                personDescription.PersonWorkInstructure = model.PersonWorkInstructure;
                personDescription.Age = model.Age;
                personDescription.PhoneNumber = model.PhoneNumber;
                personDescription.Email = model.Email;
                if (file != null)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", file.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                        personDescription.PersonImage = file.FileName;
                    }
                }
                personDescription.Adress = model.Adress;
                personDescription.HelloHeaderDescription = model.HelloHeaderDescription;
                personDescription.HelloSectionDescription = model.HelloSectionDescription;
                personDescription.ResumeHeaderDescription = model.ResumeHeaderDescription;
                personDescription.ResumeSectionDescription = model.ResumeSectionDescription;
                personDescription.Skype = model.Skype;
                personDescription.GithubLink = model.GithubLink;
                personDescription.LinkedikLink = model.LinkedikLink;
                repository.personMainDescription.Add(personDescription);
                TempData["Message"] = $"{model.PersonName} Kayıt Edildi";
                repository.SaveChanges();

                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Education()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Education(EducationContextModel model)
        {
            var education = new GraduateSchool();
            var dateTime = model.GraduateDate.ToString("dd/MM/yyyy");
            if (ModelState.IsValid)
            {
                education.GraduateSchoolName = model.GraduateSchoolName;
                education.GraduateDepartment = model.GraduateDepartment;
                education.GraduateDate = Convert.ToDateTime(dateTime);
                repository.graduateSchool.Add(education);
                repository.SaveChanges();
                TempData["Message"] = $"{model.GraduateSchoolName} Kayıt Edildi";
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View(model);
            }
        }
        public IActionResult Employment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Employment(EmploymentModel model)
        {
            var employment = new Employment();
            if (ModelState.IsValid)
            {
                employment.EmploymentNames = model.EmploymentNames;
                employment.EmploymentDescription = model.EmploymentDescription;
                employment.EmploymentDate = model.EmploymentDate;
                repository.employment.Add(employment);
                repository.SaveChanges();
                TempData["message"] = $"{model.EmploymentNames} Kayıt Edildi";
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View(model);
            }
        }
        public IActionResult GeneralSkills()
        { return View(); }

        [HttpPost]
        public IActionResult GeneralSkills(GeneralSkillsModel model)
        {
            var skills = new GeneralSkills();
            if (model.GeneralSkillsPercentage < 0 || model.GeneralSkillsPercentage > 100)
            {
                ModelState.AddModelError(nameof(model.GeneralSkillsPercentage), " Percentage Must Be  0 With 100 ");
                return View(model);
            }
            if (ModelState.IsValid)
            {
                skills.GeneralSkillsName = model.GeneralSkillsName;
                skills.GeneralSkillsPercentage = model.GeneralSkillsPercentage;
                repository.generalSkills.Add(skills);
                repository.SaveChanges();
                TempData["message"] = $"{model.GeneralSkillsName} Kayıt Edildi";
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View(model);
            }
        }
        public IActionResult MyProjects()
        { return View(); }

        [HttpPost]
        public async Task<IActionResult> MyProjects(MyProjectModel model ,IFormFile file)
        {
            var project = new MyProjects();
            if (ModelState.IsValid)
            {
                project.MyProjectHeader = model.MyProjectHeader;
                project.MyProjectLongDescription = model.MyProjectDescription;
                project.MyProjectSmallDescription = model.MyProjectSmallDescription;
                if (file !=null)
                {
                       var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\projectImages", file.FileName);
                    using (var stream = new FileStream (path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                        project.MyProjectImages = file.FileName;
                    }
                }
                project.MyProjectLink = model.MyProjectLink;
                repository.myProject.Add(project);
                repository.SaveChanges();
                TempData["Message"] = $"{model.MyProjectHeader} Kayıt Edildi";
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View(model);
            }

            
        }
    }
}