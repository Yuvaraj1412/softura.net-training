using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Project.DAL;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Homepage()
        {
            return View();
        }

        public IActionResult AddDoctor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDoc(AddDoctor N)
        {
            ClassDAL cobj = new ClassDAL();
            int result = cobj.DoctorAd(N);
            if(result ==1)
            {
                return RedirectToAction("Homepage");
            }
            else
            {
                return View("AddDoctor");
            }
        }
        public IActionResult AddPatient()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPat(AddPatient N)
        {
            ClassDAL cobj = new ClassDAL();
            int result = cobj.PatientAd(N);
            if(result == 1)
            {
                return RedirectToAction("Homepage");
            }
            else
            {
                return View("AddPatient");
            }
        }
        public IActionResult AddApointment()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Adapo(AddApointment N)
        {
            ClassDAL cobj = new ClassDAL();
            int result = cobj.AppointmentAd(N);
            if (result == 1)
            {
                return RedirectToAction("Homepage");
            }
            else
            {
                return View("AddApointment");
            }
        }
        public IActionResult Delete()
        {
            return View();
        }
       
        public IActionResult CancelApointment()
            {
                ClassDAL cobj = new ClassDAL();
                List<AddApointment> patientList = new List<AddApointment>();
                patientList = cobj.cancelapointment();
                return View(patientList);
            }
        public IActionResult Deleting(int PatientID)
        {
            ClassDAL obj = new ClassDAL();
            int result = obj.DeleteData(PatientID);
            if (result == 1)
                return View("Homepage");
            else
                return View("CancelApointment");
        }
        //public IActionResult Deleting(AddApointment N)
        //{
        //    int result;
        //    int PatientID = N.PatientID;
        //    ClassDAL cobj = new ClassDAL();
        //    result = cobj.DeleteData(N);
        //    return RedirectToAction("Homepage", N);
        //}

        public IActionResult Validate(login us)
        {
            if(ModelState.IsValid)
            {
                ClassDAL pobj = new ClassDAL();
                int result = pobj.CheckUse(us);
                if(result==1)
                {
                    return View("Homepage");
                }
                else
                {
                    return View("valid");
                }
            }
            else
            {
                return View("Index");
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
