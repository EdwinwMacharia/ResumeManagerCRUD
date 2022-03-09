using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Resumemanager.Data;
using Resumemanager.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Resumemanager.Controllers
{
    public class ResumeController : Controller
    {
        private readonly ResumeDbContext _context;
        private readonly IWebHostEnvironment _webHost;

        public ResumeController(ResumeDbContext context, IWebHostEnvironment webHost)
        {
            _context = context;
            _webHost = webHost;
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

        private string GetUploadedFileName(Application applicant)
        {
            string uniqueFileName = null;

            if (applicant.ProfilePhoto !=null )
            {
                string uploadsFolder = Path.Combine(_webHost.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + applicant.ProfilePhoto.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var filestream = new FileStream(filePath, FileMode.Create))
                {
                    applicant.ProfilePhoto.CopyTo(filestream);
                }
                
            }
            return uniqueFileName;
        }
    }
}
