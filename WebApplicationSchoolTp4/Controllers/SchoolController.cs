using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationSchoolTp4.Models;
using WebApplicationSchoolTp4.Models.Repositories;

namespace WebApplicationSchoolTp4.Controllers
{
    //[Authorize(Roles = "Admin,Manager")]
    public class SchoolController : Controller
    {
        readonly ISchoolRepository schoolRepository;
        public SchoolController(ISchoolRepository schoolRepository)
        {
            this.schoolRepository = schoolRepository;
        }

        [AllowAnonymous]
        // GET: SchoolController
        public ActionResult Index()
        {
            return View(schoolRepository.GetAll());
        }

        // GET: SchoolController/Details/5
        public ActionResult Details(int id)
        {
            var school = schoolRepository.GetById(id);
            return View(school);
        }

        // GET: SchoolController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SchoolController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(School s)
        {
            try
            {
                schoolRepository.Add(s);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SchoolController/Edit/5
        public ActionResult Edit(int id)
        {
            var school = schoolRepository.GetById(id);
            return View(school);
        }

        // POST: SchoolController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(School s)
        {
            try
            {
                schoolRepository.Edit(s);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SchoolController/Delete/5
        public ActionResult Delete(int id)
        {
            var school = schoolRepository.GetById(id);
            return View(school);
        }

        // POST: SchoolController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(School s)
        {
            try
            {

                schoolRepository.Delete(s);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }

}
