using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;

            return View(model);
        }
        public IActionResult Apply()
        {
            return View();
        }
        
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate model)
        {
            if(Repository.Applications.Any(c => c.Email.Equals(model.Email)))
            {
                //Modelin ve model bağlama doğrulamasının durumunu içeren
                ModelState.AddModelError("", "There is already an application for you.");
            }

            //Model geçerli ise
            if(ModelState.IsValid)
            {
                Repository.Add(model);

                //return RedirectToAction("Index", "Home");
                return View("Feedback", model);
            }
            //Başarıs ise üzerine dön.
            return View();
        }
    }
}