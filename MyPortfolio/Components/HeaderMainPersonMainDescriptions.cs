using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using MyPortfolio.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Components
{
    public class HeaderMainPersonMainDescriptions : ViewComponent
    {
        private IPersonMainDescriptionRepository repository;

        public HeaderMainPersonMainDescriptions(IPersonMainDescriptionRepository _repository)
        {
            repository = _repository;
        }

        public IViewComponentResult Invoke()
        {

            var res = repository.GetAll().FirstOrDefault();
            var number = String.Format("{0:(###) ###-####}", res.PhoneNumber);
            if (res != null)
            {
                var mainhede = new MainPersonelContextModel();
                mainhede.PersonName = res.PersonName;
                mainhede.PersonWorkInstructure = res.PersonWorkInstructure;
                mainhede.Age = res.Age;
                mainhede.PhoneNumber = res.PhoneNumber;
                mainhede.Email = res.Email;
                mainhede.PersonImage = res.PersonImage;
                mainhede.Adress = res.Adress;
                mainhede.HelloHeaderDescription = res.HelloHeaderDescription;
                mainhede.HelloSectionDescription = res.HelloSectionDescription;
                mainhede.ResumeHeaderDescription = res.ResumeHeaderDescription;
                mainhede.ResumeSectionDescription = res.ResumeSectionDescription;
                mainhede.GithubLink = res.GithubLink;
                mainhede.LinkedikLink = res.LinkedikLink;
                return View(mainhede);
            }
            else
            {
                return View();
            }

        }
    }
}

//if  we want to return List Must Be Use This Section
//İlker Döner

//var mainList= res.Select(i => new MainPersonelContextModel()
// {
//     PersonName = i.PersonName,
//     PersonWorkInstructure = i.PersonWorkInstructure,
//     Age = i.Age,
//     PhoneNumber = String.Format("{0:(###) ###-####}", i.PhoneNumber) ,
//     Email = i.Email,
//     PersonImage = i.PersonImage,
//     Adress = i.Adress,
//     HelloHeaderDescription = i.HelloHeaderDescription,
//     HelloSectionDescription = i.HelloSectionDescription,
//     ResumeHeaderDescription = i.ResumeHeaderDescription,
//     ResumeSectionDescription = i.ResumeSectionDescription,
//     GithubLink=i.GithubLink,
//     LinkedikLink = i.LinkedikLink
// });

    
