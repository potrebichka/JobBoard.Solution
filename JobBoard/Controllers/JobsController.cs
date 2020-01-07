using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using JobBoard.Models;

namespace JobBoard.Controllers
{
    public class JobsController : Controller
    {
        [HttpGet("/jobs")]
        public  ActionResult Index()
        {
            List<JobOpening> allItems = JobOpening.GetAll();
            return View(allItems);
        }
        [HttpGet("/jobs/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
        [HttpPost("/jobs")]
        public ActionResult Create(string title, string desciption, string name, string email, string phoneNumber)
        {
            JobOpening job = new JobOpening(title, desciption, new Contact(name, email, phoneNumber));
            return RedirectToAction("Index");
        }
    }
}