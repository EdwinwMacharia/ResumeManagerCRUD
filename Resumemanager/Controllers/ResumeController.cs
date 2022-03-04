using Microsoft.AspNetCore.Mvc;
using Resumemanager.Data;
using Resumemanager.Models;
using System.Collections.Generic;
using System.Linq;

namespace Resumemanager.Controllers
{
    public class ResumeController : Controller
    {
        private readonly ResumeDbContext _context;

        public ResumeController(ResumeDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Application> applicants;
            applicants = _context.Applications.ToList();
            return View(applicants);
        }

        [HttpGet]

        public IActionResult Create()
        {
            Application applicant = new Application();
            applicant.Experiences.Add(new Experience() { ExperienceId = 1 });
            //applicant.Experiences.Add(new Experience() { ExperienceId = 2});
            //applicant.Experiences.Add(new Experience() { ExperienceId = 3});
            return View(applicant);
        }
        public IActionResult Create(Application application)
        {
           _context.Add(application);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
