using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using MyPortfolio.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Components
{
    public class ContactSection : ViewComponent
    {
        private IPersonMainDescriptionRepository repository;
        public ContactSection(IPersonMainDescriptionRepository _repository)
        {
            repository = _repository;
        }

        public IViewComponentResult Invoke()
        {
            var res = repository.GetAll().FirstOrDefault();
            if (res != null)
            {
                var contact = new ContactSectionModel();
                contact.PhoneNumber = res.PhoneNumber;
                contact.Skype = res.Skype;
                contact.Email = res.Email;
                contact.LinkedikLink = res.LinkedikLink;
                contact.GithubLink = res.GithubLink;
                return View(contact);
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
//var ContactInformation = res.Select(i => new ContactSectionModel()
//{
//    PhoneNumber = i.PhoneNumber,
//    Skype = i.Skype,
//    Email = i.Email,
//    LinkedikLink = i.LinkedikLink,
//    GithubLink = i.GithubLink

//});