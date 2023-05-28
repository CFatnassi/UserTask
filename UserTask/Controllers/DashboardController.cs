using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserTask.Models;

namespace UserTask.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private ApplicationDbContext _context;
        public DashboardController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Dashboard
        public ActionResult Index()
        {
            List<User> obj = new List<User>();
            obj = _context.Users.ToList();
            return View(obj);
            
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Save(User person)
        {
            _context.Users.Add(person);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            User obj = _context.Users.Where(x => x.Id == id).SingleOrDefault();
            return View(obj);

        }

        [HttpPost]
        public ActionResult Delete(User person)
        {
            User objToDelete = _context.Users.Where(x => x.Id == person.Id).SingleOrDefault();
            _context.Users.Remove(objToDelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(User person)
        {
            return RedirectToAction("Edit", "Profile", new { id = person.Id });
        }
    }
}