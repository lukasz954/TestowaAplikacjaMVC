using DbService.Repository;
using ProjektTestowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Testowy.Domain;
using Tools;

namespace ProjektTestowy.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<User> _userRepository;
   
        public HomeController(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
     
       [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = _userRepository.GetUser(new User {Login=loginViewModel.Login,Password=loginViewModel.Password});
                if(user != null)
                    return View("LoginIsSuccessfull", new SuccessfullLoginViewModel(user.Name));
            }
            
            return View("Index");
        }

        [HttpGet]
        public ActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordViewModel user)
        {
            if (ModelState.IsValid)
            {
                EmailSender.SendEmail(user.Login, user.Email);
                var isUpdatePass = _userRepository.Update(new User { Login = user.Login, Email = user.Email, Password = user.NewPassword});
                return isUpdatePass == true ? View("ChangePasswordSuccesfull") : View("ChangePasswordFail");
            }
            else
                return View("ChangePassword");
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                var isExist = _userRepository.UserExistInDatabase(user);
                if (isExist)
                    return View("Index");
                else
                {
                    _userRepository.Add(user);
                    return View("RegisterIsSuccessfull");
                }
            }
                
            return View("Register");
        }

    }
}