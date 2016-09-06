﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWorld.ViewModels;
using TheWorld.Services;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TheWorld.Controllers.Web
{
    public class AppController : Controller
    {
        private IMailService _mailService;
        private IConfigurationRoot _config;

        public AppController(IMailService mailService, IConfigurationRoot config)
        {
            _mailService = mailService;
            _config = config;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (!model.Email.Contains("@aucegypt.edu"))
            {
                ModelState.AddModelError("", "We need an AUC mail address");
            }
            if (ModelState.IsValid)
            {
                _mailService.SendMail(_config["MailSettings:ToAddress"], model.Email, "TheWorld", model.Message);
                ModelState.Clear();
                ViewBag.UserMessage = "Message Sent";
            }
            return View();
        }
        public IActionResult About()
        {
            
            return View();
        }
    }
}
