using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyTrackingOnTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTrackingOnTime.Controllers
{
    public class ProfileController : Controller
    {
        // GET: ProfileController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Permissions()
        {
            var token = new DevicesModel.Token { Lang = "es", UserApiHash = HttpContext.Session.GetString("token") };
            if (string.IsNullOrEmpty(token.UserApiHash))
            {
                return RedirectToAction("Login", "Authentication");
            }
            return View();
        }

        // GET: ProfileController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProfileController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProfileController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfileController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProfileController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfileController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProfileController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
