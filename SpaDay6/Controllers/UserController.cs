using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;


namespace SpaDay6.Controllers
{
    public class UserController : Controller
    {

        [HttpGet("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if(newUser.Password == verify)
            {
                ViewBag.Username = newUser.Username;
                return View("Index");
            }
            else
            {
                ViewBag.error = "Password fields must match.";
                ViewBag.Username = newUser.Username;
                ViewBag.Email= newUser.Email;
                return View("add");
            }
        }
    }
}