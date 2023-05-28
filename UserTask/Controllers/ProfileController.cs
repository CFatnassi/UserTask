using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserTask.Models;

namespace UserTask.Controllers
{
   
    public class ProfileController : Controller
    {
        private ApplicationDbContext _context;
        public ProfileController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Profile
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Edit(int id)
        {
            if (User.IsInRole("CanEditProfile"))
            {
                User person = _context.Users.Where(x => x.Id == id).SingleOrDefault();
                User p = new User
                {
                    Name = person.Name,
                    Email = person.Email,
                    Phone = person.Phone
                };

                return View(p);
            }
            else
            {
                return View("Index");
            }
        }
        public ActionResult Update(User person)
        {

            User objToUpdate = _context.Users.Where(x => x.Id == person.Id).SingleOrDefault();
            objToUpdate.Name = person.Name;
            objToUpdate.Email = objToUpdate.Email;
            objToUpdate.Phone = person.Phone;

            _context.SaveChanges();
            return RedirectToAction("Index", "Dashboard");
        }
    

        

    }
}